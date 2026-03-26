using QLDuAnPhanMemTinHoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class TrangChu : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public TrangChu(string vaiTro)
        {
            InitializeComponent();

            // 1. Cố định chiều cao FlowPanel để không đè xuống dưới
            this.flowPanelThongKe.Height = 160;
            this.flowPanelThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.flowPanelThongKe.FlowDirection = FlowDirection.LeftToRight;
            this.flowPanelThongKe.WrapContents = false;

            // 2. Clear và Add Card (Hàm AddCard tui đã tối ưu Width)
            LoadCards();

            // 3. Tạo vùng chứa biểu đồ nằm NGAY DƯỚI FlowPanel
            TaoGiaoDienNangCao();
        }

        private void LoadCards()
        {
            flowPanelThongKe.Controls.Clear();
            // Tính toán Width chuẩn để 3 cái khít khìn khịt
            int w = (flowPanelThongKe.Width / 3) - 25;
            AddProStatCard("TỔNG DỰ ÁN", "12", Color.FromArgb(52, 152, 219), "📁", w);
            AddProStatCard("NHÂN VIÊN", "45", Color.FromArgb(46, 204, 113), "👥", w);
            AddProStatCard("TASK TRỄ", "03", Color.FromArgb(231, 76, 60), "⚠️", w);
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
                Anchor = AnchorStyles.Top | AnchorStyles.Right // Icon luôn bám bên phải
            };

            p.Controls.Add(lblNum);
            p.Controls.Add(lblTitle);
            p.Controls.Add(lblIcon);
            flowPanelThongKe.Controls.Add(p);

            p.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 15, 15));
        }

        private void TaoGiaoDienNangCao()
        {
            // Tạo pnlBottom bắt đầu từ Y=320 để CHẮC CHẮN không đè lên 3 cái card
            Panel pnlBottom = new Panel
            {
                Location = new Point(30, 350),
                Size = new Size(this.ClientSize.Width - 60, 450), // Khống chế chiều cao 450 thôi
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White
            };
            pnlBottom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 15, 15));
            this.Controls.Add(pnlBottom);
            pnlBottom.BringToFront();

            // 2. Chia đôi pnlBottom ra: Trái chứa Chart, Phải chứa Tiến độ

            // BIỂU ĐỒ BÊN TRÁI
            Chart chart = new Chart
            {
                Size = new Size(400, 350), // ÉP CỨNG KÍCH THƯỚC CHART
                Location = new Point(20, 50),
                BackColor = Color.White
            };

            ChartArea ca = new ChartArea();
            // Khống chế vùng vẽ Donuts nằm gọn trong lòng Chart
            ca.InnerPlotPosition = new ElementPosition(10, 10, 80, 80);
            chart.ChartAreas.Add(ca);

            Series s = new Series { ChartType = SeriesChartType.Doughnut };
            s["DoughnutRadius"] = "55";
            s.Points.AddXY("Xong", 7); s.Points.AddXY("Làm", 5); s.Points.AddXY("Trễ", 2);
            chart.Series.Add(s);

            chart.Titles.Add(new Title("TRẠNG THÁI DỰ ÁN", Docking.Top, new Font("Segoe UI", 12, FontStyle.Bold), Color.Black));

            pnlBottom.Controls.Add(chart);

            // TIẾN ĐỘ BÊN PHẢI (Bắt đầu từ giữa Panel trở đi)
            Label lblTitle = new Label
            {
                Text = "TIẾN ĐỘ THỰC TẾ",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(450, 30),
                AutoSize = true
            };
            pnlBottom.Controls.Add(lblTitle);

            // Gọi các hàm TaoTienDoItem với toạ độ X = 450
            TaoTienDoItem(pnlBottom, "Web Tin Học", 75, 450, 80);
            TaoTienDoItem(pnlBottom, "App Quản Lý", 40, 450, 150);
        }

        private void TaoTienDoItem(Panel parent, string name, int val, int x, int y)
        {
            Label lbl = new Label { Text = name, Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10) };
            ProgressBar pb = new ProgressBar
            {
                Location = new Point(x, y + 25),
                Size = new Size(parent.Width - x - 80, 12),
                Value = val,
                Style = ProgressBarStyle.Continuous
            };
            parent.Controls.Add(lbl);
            parent.Controls.Add(pb);
        }
    }
}