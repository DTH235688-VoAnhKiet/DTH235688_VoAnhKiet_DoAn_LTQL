using OfficeOpenXml; // Thêm cái này để xài EPPlus
using QLDuAnPhanMemTinHoc.Data;
using System;
using System.Data;
using System.Drawing;
using System.IO; // Thêm cái này để thao tác file
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml;
using System.IO;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class TrangChu : Form
    {
        private readonly QLDADbContext _context = new QLDADbContext();
        private string vaiTroHienTai;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public TrangChu(string vaiTro)
        {
            InitializeComponent();
            this.vaiTroHienTai = vaiTro;

            // 1. Cấu hình FlowPanel
            this.flowPanelThongKe.Height = 160;
            this.flowPanelThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.flowPanelThongKe.FlowDirection = FlowDirection.LeftToRight;
            this.flowPanelThongKe.WrapContents = false;

            // 2. Load các con số thống kê
            LoadCards();

            // 3. Load biểu đồ và tiến độ
            TaoGiaoDienNangCao();

            // 4. Gọi hàm thêm nút xuất báo cáo
            ThemNutXuatBaoCao();
        }

        private void LoadCards()
        {
            flowPanelThongKe.Controls.Clear();
            int w = (flowPanelThongKe.Width / 3) - 25;

            string tongDA = _context.DuAn.Count().ToString();
            string tongNV = _context.NhanVien.Count().ToString();
            string taskTre = _context.CongViec.Count(cv => cv.TrangThai.Contains("Trễ")).ToString();

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
            // Tọa độ Y = 390 để đẩy khung trắng xích xuống dưới cho thoáng
            Panel pnlBottom = new Panel
            {
                Location = new Point(30, 390),
                Size = new Size(this.ClientSize.Width - 60, 450),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White
            };
            pnlBottom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlBottom.Width, pnlBottom.Height, 15, 15));
            this.Controls.Add(pnlBottom);

            // --- PHẦN BIỂU ĐỒ TRÁI ---
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

            // --- PHẦN TIẾN ĐỘ PHẢI ---
            Label lblTitle = new Label
            {
                Text = "DANH SÁCH DỰ ÁN MỚI NHẤT",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(450, 30),
                AutoSize = true
            };
            pnlBottom.Controls.Add(lblTitle);

            var dsDuAn = _context.DuAn.OrderByDescending(d => d.ID).Take(5).ToList();
            int startY = 80;

            foreach (var da in dsDuAn)
            {
                int tienDo = (da.TrangThai == "Hoàn thành") ? 100 : new Random().Next(10, 90);

                // Tự động tính toán chiều rộng của ProgressBar
                int pbWidth = pnlBottom.Width - 450 - 50;
                TaoTienDoItem(pnlBottom, da.TenDuAn, tienDo, 450, startY, pbWidth);

                startY += 70; // Giữ khoảng cách chuẩn để không đè nhau
            }
        }

        private void TaoTienDoItem(Panel parent, string name, int val, int x, int y, int pbWidth)
        {
            Label lbl = new Label { Text = name, Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10) };
            ProgressBar pb = new ProgressBar
            {
                Location = new Point(x, y + 25),
                Size = new Size(pbWidth > 150 ? pbWidth : 300, 12), // Tránh lỗi Width bị quá nhỏ
                Value = val,
                Style = ProgressBarStyle.Continuous,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            parent.Controls.Add(lbl);
            parent.Controls.Add(pb);
        }

        // --- PHẦN NÚT XUẤT BÁO CÁO ---
        private void ThemNutXuatBaoCao()
        {
            Button btnXuat = new Button
            {
                Text = "📥 XUẤT BÁO CÁO",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                Size = new Size(200, 40),
                Location = new Point(this.ClientSize.Width - 250, 20),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnXuat.FlatAppearance.BorderSize = 0;
            // Bo tròn nút cho đẹp
            btnXuat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnXuat.Width, btnXuat.Height, 20, 20));

            // Gắn sự kiện Click 
            btnXuat.Click += BtnXuat_Click;

            this.Controls.Add(btnXuat);
            btnXuat.BringToFront(); // Đưa lên lớp trên cùng
        }

        // --- HÀM XUẤT EXCEL CHUẨN XỊN (.XLSX) DÙNG EPPLUS ---
        private void BtnXuat_Click(object sender, EventArgs e)
        {
            // Bắt buộc khai báo cái này để xài EPPlus bản Free
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.Title = "Chọn nơi lưu Báo Cáo Thống Kê";
            sfd.FileName = "BaoCaoThongKe_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("BaoCaoThongKe");

                        // 1. HEADER (Làm tiêu đề bự bự cho ngầu)
                        ws.Cells["A1:C1"].Merge = true;
                        ws.Cells["A1"].Value = "BÁO CÁO THỐNG KÊ HỆ THỐNG QUẢN LÝ DỰ ÁN";
                        ws.Cells["A1"].Style.Font.Bold = true;
                        ws.Cells["A1"].Style.Font.Size = 14;
                        ws.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        ws.Cells["A3"].Value = "Ngày xuất báo cáo:";
                        ws.Cells["B3"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                        ws.Cells["A4"].Value = "Người xuất:";
                        ws.Cells["B4"].Value = vaiTroHienTai;

                        // 2. THỐNG KÊ TỔNG QUAN
                        ws.Cells["A6"].Value = "1. THỐNG KÊ TỔNG QUAN";
                        ws.Cells["A6"].Style.Font.Bold = true;

                        ws.Cells["A7"].Value = "Tổng số dự án:";
                        ws.Cells["B7"].Value = _context.DuAn.Count();

                        ws.Cells["A8"].Value = "Tổng nhân viên:";
                        ws.Cells["B8"].Value = _context.NhanVien.Count();

                        ws.Cells["A9"].Value = "Số Task đang trễ:";
                        ws.Cells["B9"].Value = _context.CongViec.Count(cv => cv.TrangThai.Contains("Trễ"));

                        // 3. CHI TIẾT DỰ ÁN
                        ws.Cells["A11"].Value = "2. DANH SÁCH CHI TIẾT DỰ ÁN";
                        ws.Cells["A11"].Style.Font.Bold = true;

                        // Dòng tiêu đề cho bảng chi tiết (Tô nền màu xám)
                        ws.Cells["A12"].Value = "Mã Dự Án";
                        ws.Cells["B12"].Value = "Tên Dự Án";
                        ws.Cells["C12"].Value = "Trạng Thái";
                        ws.Cells["A12:C12"].Style.Font.Bold = true;
                        ws.Cells["A12:C12"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        ws.Cells["A12:C12"].Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                        // Đổ dữ liệu thật từ Database vào
                        var dsDuAn = _context.DuAn.OrderBy(d => d.ID).ToList();
                        int row = 13;
                        foreach (var da in dsDuAn)
                        {
                            ws.Cells[row, 1].Value = da.ID;
                            ws.Cells[row, 2].Value = da.TenDuAn;
                            ws.Cells[row, 3].Value = da.TrangThai;
                            row++;
                        }

                        // Phép thuật: Tự động kéo giãn cột cho vừa khít với chữ
                        ws.Cells.AutoFitColumns();

                        // Lưu file
                        FileInfo fi = new FileInfo(sfd.FileName);
                        package.SaveAs(fi);
                    }

                    MessageBox.Show("Đã xuất báo cáo thành công ra file Excel xịn (.xlsx)!\n\nĐường dẫn: " + sfd.FileName,
                                    "Ngon lành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra lúc lưu file: " + ex.Message,
                                    "Báo động đỏ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}