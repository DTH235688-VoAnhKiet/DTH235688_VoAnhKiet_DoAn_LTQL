using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class CongViecCuaToi : Form
    {
        private string strKetNoi = System.Configuration.ConfigurationManager.ConnectionStrings["QLDAConnection"].ConnectionString;
        private int maNhanVienDangNhap;
        private int maCongViecDangChon = -1;

        // Khai báo các control
        private DataGridView dgvCongViec;
        private ComboBox cboTrangThai;
        private NumericUpDown nudTienDo;
        private TextBox txtTimKiem;
        private Label lblTongViec, lblHoanThanh, lblDangLam;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public CongViecCuaToi(int maNhanVienDuocTruyenVao)
        {
            InitializeComponent();
            this.maNhanVienDangNhap = maNhanVienDuocTruyenVao;
            this.Load += CongViecCuaToi_Load;
        }

        private void CongViecCuaToi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(245, 246, 250);
            XayDungGiaoDien();
            LoadDuLieuTuDatabase();
        }

        private void XayDungGiaoDien()
        {
            // 1. TIÊU ĐỀ
            Label lblTitle = new Label { Text = "CÔNG VIỆC CỦA TÔI", Font = new Font("Segoe UI", 20, FontStyle.Bold), Location = new Point(30, 20), AutoSize = true };
            this.Controls.Add(lblTitle);

            // 2. CÁC THẺ THỐNG KÊ
            lblTongViec = TaoTheThongKe("Tổng Task", Color.FromArgb(52, 152, 219), 30, 70);
            lblDangLam = TaoTheThongKe("Đang làm", Color.FromArgb(241, 196, 15), 170, 70);
            lblHoanThanh = TaoTheThongKe("Hoàn thành", Color.FromArgb(46, 204, 113), 310, 70);

            // 3. KHU VỰC CẬP NHẬT (Đã xích qua trái 1 lóng tay cho đẹp lề phải)
            Panel pnlCapNhat = new Panel
            {
                Location = new Point(420, 20), // Xích qua trái
                Size = new Size(350, 120),
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            pnlCapNhat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCapNhat.Width, pnlCapNhat.Height, 15, 15));

            Label lblTT = new Label { Text = "Trạng thái:", Location = new Point(20, 15), AutoSize = true, Font = new Font("Segoe UI", 9) };
            cboTrangThai = new ComboBox { Location = new Point(20, 35), Width = 140, Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };
            cboTrangThai.Items.AddRange(new string[] { "Chưa làm", "Đang làm", "Hoàn thành" });

            Label lblTD = new Label { Text = "Tiến độ (%):", Location = new Point(180, 15), AutoSize = true, Font = new Font("Segoe UI", 9) };
            nudTienDo = new NumericUpDown { Location = new Point(180, 35), Width = 80, Font = new Font("Segoe UI", 10) };

            Button btnCapNhat = new Button
            {
                Text = "CẬP NHẬT",
                Location = new Point(20, 70),
                Size = new Size(240, 35),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCapNhat.FlatAppearance.BorderSize = 0;
            btnCapNhat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCapNhat.Width, btnCapNhat.Height, 5, 5));
            btnCapNhat.Click += btnCapNhat_Click;

            pnlCapNhat.Controls.Add(lblTT); pnlCapNhat.Controls.Add(cboTrangThai);
            pnlCapNhat.Controls.Add(lblTD); pnlCapNhat.Controls.Add(nudTienDo); pnlCapNhat.Controls.Add(btnCapNhat);
            this.Controls.Add(pnlCapNhat);

            // 4. Ô TÌM KIẾM
            Label lblSearch = new Label { Text = "Tìm nhanh:", Location = new Point(30, 155), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Italic) };
            txtTimKiem = new TextBox { Location = new Point(110, 152), Width = 250, Font = new Font("Segoe UI", 10) };
            txtTimKiem.TextChanged += (s, e) => {
                if (dgvCongViec.DataSource != null)
                {
                    (dgvCongViec.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Tên Công Việc] LIKE '%{0}%'", txtTimKiem.Text);
                }
            };
            this.Controls.Add(lblSearch); this.Controls.Add(txtTimKiem);

            // 5. BẢNG DỮ LIỆU (Đã bóp chiều rộng lại để hở lề phải ra)
            Panel pnlGrid = new Panel
            {
                Location = new Point(30, 190),
                Size = new Size(740, 300), // Bóp bề rộng lại cho hở lề
                BackColor = Color.White,
                Padding = new Padding(10),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            pnlGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlGrid.Width, pnlGrid.Height, 15, 15));
            pnlGrid.Resize += (s, e) => pnlGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlGrid.Width, pnlGrid.Height, 15, 15));

            dgvCongViec = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                ReadOnly = true
            };
            dgvCongViec.EnableHeadersVisualStyles = false;
            dgvCongViec.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvCongViec.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
            // Đổi màu nền khi click chọn thành màu trắng / xám nhạt để đỡ chói
            dgvCongViec.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvCongViec.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCongViec.CellClick += dgvCongViec_CellClick;

            pnlGrid.Controls.Add(dgvCongViec);
            this.Controls.Add(pnlGrid);
        }

        private Label TaoTheThongKe(string tieuDe, Color mau, int x, int y)
        {
            Panel pnl = new Panel { Size = new Size(130, 70), Location = new Point(x, y), BackColor = mau };
            pnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl.Width, pnl.Height, 10, 10));
            Label lblTitle = new Label { Text = tieuDe, ForeColor = Color.White, Location = new Point(10, 10), AutoSize = true, Font = new Font("Segoe UI", 8, FontStyle.Bold) };
            Label lblValue = new Label { Text = "0", ForeColor = Color.White, Location = new Point(10, 30), AutoSize = true, Font = new Font("Segoe UI", 15, FontStyle.Bold) };
            pnl.Controls.Add(lblTitle); pnl.Controls.Add(lblValue);
            this.Controls.Add(pnl);
            return lblValue;
        }

        private void LoadDuLieuTuDatabase()
        {
            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                string query = @"
                    SELECT cv.ID AS [Mã Task], cv.TenCongViec AS [Tên Công Việc], da.TenDuAn AS [Thuộc Dự Án], 
                           cv.HanHoanThanh AS [Deadline], cv.TrangThai AS [Trạng Thái], 
                           ISNULL((SELECT TOP 1 PhanTram FROM TienDo td WHERE td.CongViecID = cv.ID ORDER BY NgayCapNhat DESC), 0) AS [Tiến Độ]
                    FROM CongViec cv
                    INNER JOIN PhanCongCongViec pccv ON cv.ID = pccv.CongViecID
                    INNER JOIN DuAn da ON cv.DuAnID = da.ID
                    WHERE pccv.NhanVienID = @NhanVienID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@NhanVienID", maNhanVienDangNhap);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Cập nhật dữ liệu mới vào bảng
                dgvCongViec.DataSource = dt;

                // Cập nhật số liệu trên thẻ
                if (dt != null)
                {
                    lblTongViec.Text = dt.Rows.Count.ToString();
                    lblHoanThanh.Text = dt.Select("[Trạng Thái] = 'Hoàn thành'").Length.ToString();
                    lblDangLam.Text = dt.Select("[Trạng Thái] = 'Đang làm'").Length.ToString();
                }

                // Giữ nguyên focus ở dòng vừa cập nhật
                if (maCongViecDangChon != -1 && dgvCongViec.Rows.Count > 0)
                {
                    dgvCongViec.ClearSelection();
                    foreach (DataGridViewRow row in dgvCongViec.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["Mã Task"].Value) == maCongViecDangChon)
                        {
                            row.Selected = true;
                            dgvCongViec.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
            }
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCongViec.Rows[e.RowIndex];
                maCongViecDangChon = Convert.ToInt32(row.Cells["Mã Task"].Value);
                cboTrangThai.Text = row.Cells["Trạng Thái"].Value.ToString();
                nudTienDo.Value = Convert.ToInt32(row.Cells["Tiến Độ"].Value);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (maCongViecDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn công việc từ danh sách để thực hiện!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTrangThai.SelectedItem == null) return;

            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                conn.Open();

                // 1. Update bảng CongViec
                string sqlUpdate = "UPDATE CongViec SET TrangThai = @tt WHERE ID = @id";
                using (SqlCommand cmd1 = new SqlCommand(sqlUpdate, conn))
                {
                    cmd1.Parameters.AddWithValue("@tt", cboTrangThai.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@id", maCongViecDangChon);
                    cmd1.ExecuteNonQuery();
                }

                // 2. Ghi lịch sử vào bảng TienDo
                string sqlInsert = "INSERT INTO TienDo (CongViecID, PhanTram, NgayCapNhat) VALUES (@id, @pt, GETDATE())";
                using (SqlCommand cmd2 = new SqlCommand(sqlInsert, conn))
                {
                    cmd2.Parameters.AddWithValue("@id", maCongViecDangChon);
                    cmd2.Parameters.AddWithValue("@pt", nudTienDo.Value);
                    cmd2.ExecuteNonQuery();
                }
            }

            // Gọi lại load để cập nhật cả bảng dữ liệu lẫn thẻ thống kê
            LoadDuLieuTuDatabase();

            MessageBox.Show("Đã cập nhật tiến độ thành công.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}