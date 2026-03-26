using QLDuAnPhanMemTinHoc.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class TrangChu : Form
    {
        // Khởi tạo Context để kết nối DB
        private readonly QLDADbContext _context = new QLDADbContext();
        private string vaiTroHienTai;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public TrangChu(string vaiTro)
        {
            InitializeComponent();
            this.vaiTroHienTai = vaiTro; // Lưu vai trò lại để phân quyền

            // 1. Cấu hình FlowPanel
            this.flowPanelThongKe.Height = 160;
            this.flowPanelThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.flowPanelThongKe.FlowDirection = FlowDirection.LeftToRight;
            this.flowPanelThongKe.WrapContents = false;

            // 2. Load các con số thống kê
            LoadCards();

            // 3. Load biểu đồ và tiến độ
            TaoGiaoDienNangCao();
        }

        private void LoadCards()
        {
            flowPanelThongKe.Controls.Clear();
            int w = (flowPanelThongKe.Width / 3) - 25;

            // TRUY VẤN DỮ LIỆU THẬT
            string tongDA = _context.DuAn.Count().ToString();
            string tongNV = _context.NhanVien.Count().ToString();
            // Task trễ là task có chữ "Trễ" trong trạng thái
            string taskTre = _context.CongViec.Count(cv => cv.TrangThai.Contains("Trễ")).ToString();

            // Nếu là nhân viên, ný có thể đổi tiêu đề Card đầu tiên
            string titleCard1 = (vaiTroHienTai == "Admin") ? "TỔNG DỰ ÁN" : "DỰ ÁN HỆ THỐNG";

            AddProStatCard(titleCard1, tongDA, Color.FromArgb(52, 152, 219), "📁", w);
            AddProStatCard("NHÂN VIÊN", tongNV, Color.FromArgb(46, 204, 113), "👥", w);
            AddProStatCard("TASK TRỄ", taskTre, Color.FromArgb(231, 76, 60), "⚠️", w);
        }

        private void AddProStatCard(string title, string count, Color color, string icon, int cardWidth)
        {
            Panel p = new Panel
            {
                Size = new Size(cardWidth, 130),
                BackColor = color,
                Margin = new Padding(0, 0, 15, 0)
            };

            Label lblNum = new Label
            {
                Text = count,
                Font = new Font("Segoe UI", 35, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(15, 10),
                AutoSize = true
            };

            Label lblTitle = new Label
            {
                Text = title.ToUpper(),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(18, 85),
                AutoSize = true
            };

            Label lblIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 40),
                ForeColor = Color.FromArgb(60, 255, 255, 255),
                Size = new Size(80, 80),
                Location = new Point(p.Width - 90, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            p.Controls.Add(lblNum);
            p.Controls.Add(lblTitle);
            p.Controls.Add(lblIcon);
            flowPanelThongKe.Controls.Add(p);

            p.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 15, 15));
        }

        private void TaoGiaoDienNangCao()
        {
            // 1. Tạo Panel nền trắng bên dưới
            Panel pnlBottom = new Panel
            {
                Location = new Point(30, 350),
                Size = new Size(this.ClientSize.Width - 60, 450),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White
            };
            pnlBottom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 15, 15));
            this.Controls.Add(pnlBottom);

            // --- PHẦN BIỂU ĐỒ TRÁI (CHỈ HIỆN CHO ADMIN HOẶC HIỆN TỔNG QUAN) ---
            Chart chart = new Chart
            {
                Size = new Size(400, 350),
                Location = new Point(20, 50),
                BackColor = Color.White
            };

            ChartArea ca = new ChartArea();
            ca.InnerPlotPosition = new ElementPosition(10, 10, 80, 80);
            chart.ChartAreas.Add(ca);

            Series s = new Series { ChartType = SeriesChartType.Doughnut };
            s["DoughnutRadius"] = "55";

            // LẤY DỮ LIỆU THẬT CHO BIỂU ĐỒ
            var thongKeDA = _context.DuAn
                            .GroupBy(d => d.TrangThai)
                            .Select(g => new { TenTrangThai = g.Key ?? "Khác", SoLuong = g.Count() })
                            .ToList();

            foreach (var item in thongKeDA)
            {
                s.Points.AddXY(item.TenTrangThai, item.SoLuong);
            }

            chart.Series.Add(s);
            chart.Titles.Add(new Title("TRẠNG THÁI DỰ ÁN TOÀN CÔNG TY", Docking.Top, new Font("Segoe UI", 12, FontStyle.Bold), Color.Black));
            pnlBottom.Controls.Add(chart);

            // --- PHẦN TIẾN ĐỘ PHẢI (DỮ LIỆU THẬT) ---
            Label lblTitle = new Label
            {
                Text = "DANH SÁCH DỰ ÁN MỚI NHẤT",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(450, 30),
                AutoSize = true
            };
            pnlBottom.Controls.Add(lblTitle);

            // Lấy 5 dự án mới nhất để hiện thanh Progress
            var dsDuAn = _context.DuAn.OrderByDescending(d => d.ID).Take(5).ToList();
            int startY = 80;

            foreach (var da in dsDuAn)
            {
                // Giả lập tiến độ (Nếu ný chưa có cột % tiến độ trong DB)
                int tienDo = (da.TrangThai == "Hoàn thành") ? 100 : new Random().Next(10, 90);

                TaoTienDoItem(pnlBottom, da.TenDuAn, tienDo, 450, startY);
                startY += 70;
            }
        }

        private void TaoTienDoItem(Panel parent, string name, int val, int x, int y)
        {
            Label lbl = new Label { Text = name, Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10) };
            ProgressBar pb = new ProgressBar
            {
                Location = new Point(x, y + 25),
                Size = new Size(parent.Width - x - 50, 12),
                Value = val,
                Style = ProgressBarStyle.Continuous,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right // Để ProgressBar dài ra khi phóng to form
            };
            parent.Controls.Add(lbl);
            parent.Controls.Add(pb);
        }
    }
}