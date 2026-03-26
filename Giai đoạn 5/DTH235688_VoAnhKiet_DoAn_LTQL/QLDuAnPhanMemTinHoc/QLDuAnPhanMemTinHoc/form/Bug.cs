using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class Bug : Form
    {
        private string strKetNoi = @"Server=.\SQLEXPRESS;Database=QLDA;Integrated Security=True;TrustServerCertificate=True";
        private int maNhanVienDangNhap;
        private int maBugDangChon = -1;

        private DataGridView dgvBug;
        private ComboBox cboTrangThai, cboMucDo;
        private TextBox txtTimKiem;
        private Label lblTongBug, lblDangFix, lblDaFix;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Bug(int maNV)
        {
            InitializeComponent();
            this.maNhanVienDangNhap = maNV;
            this.Load += Bug_Load;
        }

        private void Bug_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(245, 246, 250);
            XayDungGiaoDien();
            LoadDuLieu();
        }

        private void XayDungGiaoDien()
        {
            // Tiêu đề
            Label lblTitle = new Label { Text = "QUẢN LÝ LỖI (BUG)", Font = new Font("Segoe UI", 20, FontStyle.Bold), Location = new Point(30, 20), AutoSize = true };
            this.Controls.Add(lblTitle);

            // Thẻ thống kê
            lblTongBug = TaoTheThongKe("Tổng Bug", Color.FromArgb(231, 76, 60), 30, 70);
            lblDangFix = TaoTheThongKe("Đang Fix", Color.FromArgb(243, 156, 18), 170, 70);
            lblDaFix = TaoTheThongKe("Đã Xong", Color.FromArgb(46, 204, 113), 310, 70);

            // Khung thao tác Cập nhật
            Panel pnlCapNhat = new Panel { Location = new Point(420, 20), Size = new Size(350, 120), BackColor = Color.White, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            pnlCapNhat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCapNhat.Width, pnlCapNhat.Height, 15, 15));

            Label lblTT = new Label { Text = "Trạng thái:", Location = new Point(20, 15), AutoSize = true };
            cboTrangThai = new ComboBox { Location = new Point(20, 35), Width = 140, DropDownStyle = ComboBoxStyle.DropDownList };
            cboTrangThai.Items.AddRange(new string[] { "Chưa fix", "Đang fix", "Đã fix" });

            Label lblMD = new Label { Text = "Mức độ:", Location = new Point(180, 15), AutoSize = true };
            cboMucDo = new ComboBox { Location = new Point(180, 35), Width = 140, DropDownStyle = ComboBoxStyle.DropDownList };
            cboMucDo.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });

            Button btnCapNhat = new Button
            {
                Text = "LƯU CẬP NHẬT",
                Location = new Point(20, 70),
                Size = new Size(300, 35),
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCapNhat.Click += BtnCapNhat_Click;

            pnlCapNhat.Controls.Add(lblTT); pnlCapNhat.Controls.Add(cboTrangThai);
            pnlCapNhat.Controls.Add(lblMD); pnlCapNhat.Controls.Add(cboMucDo);
            pnlCapNhat.Controls.Add(btnCapNhat);
            this.Controls.Add(pnlCapNhat);

            // Khung Tìm kiếm
            Label lblSearch = new Label { Text = "Tìm nhanh:", Location = new Point(30, 155), AutoSize = true };
            txtTimKiem = new TextBox { Location = new Point(110, 152), Width = 250 };
            txtTimKiem.TextChanged += (s, e) => {
                if (dgvBug.DataSource != null)
                    (dgvBug.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Tên Bug] LIKE '%{0}%'", txtTimKiem.Text);
            };
            this.Controls.Add(lblSearch); this.Controls.Add(txtTimKiem);

            // NÚT THÊM BUG MỚI
            Button btnThemBug = new Button
            {
                Text = "➕ THÊM BUG MỚI",
                Location = new Point(380, 148), // Nằm ngay cạnh ô tìm kiếm
                Size = new Size(150, 30),
                BackColor = Color.FromArgb(46, 204, 113), // Màu xanh lá cho tươi
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnThemBug.Click += BtnThemBug_Click;
            this.Controls.Add(btnThemBug);

            // Bảng DataGridView
            dgvBug = new DataGridView
            {
                Location = new Point(30, 190),
                Size = new Size(740, 300),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                ReadOnly = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            dgvBug.CellClick += DgvBug_CellClick;
            this.Controls.Add(dgvBug);
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

        private void LoadDuLieu()
        {
            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT ID AS [Mã Bug], TieuDe AS [Tên Bug], MucDo AS [Mức độ], TrangThai AS [Trạng thái] 
                                     FROM Bug 
                                     WHERE NguoiXuLyID = @NV OR @NV = 0";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@NV", maNhanVienDangNhap);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBug.DataSource = dt;

                    lblTongBug.Text = dt.Rows.Count.ToString();
                    lblDangFix.Text = dt.Select("[Trạng thái] = 'Đang fix'").Length.ToString();
                    lblDaFix.Text = dt.Select("[Trạng thái] = 'Đã fix'").Length.ToString();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi load dữ liệu: " + ex.Message); }
            }
        }

        private void DgvBug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBug.Rows[e.RowIndex];
                maBugDangChon = Convert.ToInt32(row.Cells["Mã Bug"].Value);
                cboMucDo.Text = row.Cells["Mức độ"].Value.ToString();
                cboTrangThai.Text = row.Cells["Trạng thái"].Value.ToString();
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (maBugDangChon == -1) { MessageBox.Show("Chọn một lỗi trong bảng bên dưới để cập nhật ný ơi!"); return; }

            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE Bug SET TrangThai = @tt, MucDo = @md WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tt", cboTrangThai.Text);
                    cmd.Parameters.AddWithValue("@md", cboMucDo.Text);
                    cmd.Parameters.AddWithValue("@id", maBugDangChon);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật Bug thành công!", "Thông báo");
                    LoadDuLieu();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi lưu: " + ex.Message); }
            }
        }

        // --- CÁC HÀM MỚI PHỤC VỤ CHỨC NĂNG THÊM BUG ---

        private void BtnThemBug_Click(object sender, EventArgs e)
        {
            HienThiFormThemBug();
        }

        private void HienThiFormThemBug()
        {
            // Dựng cái form nhỏ
            Form frmThem = new Form
            {
                Text = "Thêm Báo Cáo Lỗi (Bug)",
                Size = new Size(400, 480),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };

            // Tiêu đề
            frmThem.Controls.Add(new Label { Text = "Tiêu đề lỗi:", Location = new Point(20, 20), AutoSize = true });
            TextBox txtTD = new TextBox { Location = new Point(20, 40), Width = 340 };
            frmThem.Controls.Add(txtTD);

            // Mô tả
            frmThem.Controls.Add(new Label { Text = "Mô tả chi tiết:", Location = new Point(20, 75), AutoSize = true });
            TextBox txtMT = new TextBox { Location = new Point(20, 95), Width = 340, Height = 80, Multiline = true };
            frmThem.Controls.Add(txtMT);

            // Mức độ
            frmThem.Controls.Add(new Label { Text = "Mức độ nghiêm trọng:", Location = new Point(20, 190), AutoSize = true });
            ComboBox cboMD = new ComboBox { Location = new Point(20, 210), Width = 340, DropDownStyle = ComboBoxStyle.DropDownList };
            cboMD.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });
            cboMD.SelectedIndex = 1; // Mặc định là Medium
            frmThem.Controls.Add(cboMD);

            // Dự án
            frmThem.Controls.Add(new Label { Text = "Thuộc dự án:", Location = new Point(20, 250), AutoSize = true });
            ComboBox cboDA = new ComboBox { Location = new Point(20, 270), Width = 340, DropDownStyle = ComboBoxStyle.DropDownList };
            frmThem.Controls.Add(cboDA);

            // Người xử lý
            frmThem.Controls.Add(new Label { Text = "Giao cho nhân viên:", Location = new Point(20, 310), AutoSize = true });
            ComboBox cboNXL = new ComboBox { Location = new Point(20, 330), Width = 340, DropDownStyle = ComboBoxStyle.DropDownList };
            frmThem.Controls.Add(cboNXL);

            // ĐỔ DỮ LIỆU VÀO COMBOBOX 
            LoadDuLieuVaoComboBox(cboDA, "SELECT ID, TenDuAn FROM DuAn", "TenDuAn", "ID");

            // Lọc chỉ lấy Nhân viên (QuyenHan = 0), giấu Admin (QuyenHan = 1) đi
            LoadDuLieuVaoComboBox(cboNXL, "SELECT ID, HoVaTen + N' - Nhân viên' AS TenHienThi FROM NhanVien WHERE QuyenHan = 0", "TenHienThi", "ID");

            // Nút Lưu
            Button btnLuu = new Button
            {
                Text = "LƯU BÁO LỖI",
                Location = new Point(20, 380),
                Size = new Size(340, 40),
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            frmThem.Controls.Add(btnLuu);

            // Sự kiện lưu dữ liệu vào Database
            btnLuu.Click += (s, ev) => {
                if (string.IsNullOrWhiteSpace(txtTD.Text)) { MessageBox.Show("Ný phải nhập tiêu đề lỗi nha!"); return; }
                if (cboDA.SelectedValue == null) { MessageBox.Show("Chưa có dự án nào để chọn!"); return; }
                if (cboNXL.SelectedValue == null) { MessageBox.Show("Chưa có nhân viên nào để giao việc!"); return; }

                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    try
                    {
                        conn.Open();
                        string sql = @"INSERT INTO Bug (TieuDe, MoTa, MucDo, TrangThai, NgayBaoCao, DuAnID, NguoiBaoCaoID, NguoiXuLyID) 
                                       VALUES (@td, @mt, @md, N'Chưa fix', GETDATE(), @da, @nbc, @nxl)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@td", txtTD.Text);
                        cmd.Parameters.AddWithValue("@mt", txtMT.Text);
                        cmd.Parameters.AddWithValue("@md", cboMD.Text);
                        cmd.Parameters.AddWithValue("@da", Convert.ToInt32(cboDA.SelectedValue));

                        // Nếu test bằng ID 0 thì tự mượn ID 5 (Admin) để chèn
                        int idBaoCao = (maNhanVienDangNhap <= 0) ? 5 : maNhanVienDangNhap;
                        cmd.Parameters.AddWithValue("@nbc", idBaoCao);

                        cmd.Parameters.AddWithValue("@nxl", Convert.ToInt32(cboNXL.SelectedValue));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm Bug mới thành công! Sếp đã giao việc thành công.", "Thông báo");
                        frmThem.Close(); // Đóng form nhỏ
                        LoadDuLieu();    // Load lại bảng ở form lớn
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi khi chèn dữ liệu: " + ex.Message); }
                }
            };

            frmThem.ShowDialog();
        }

        private void LoadDuLieuVaoComboBox(ComboBox cbo, string query, string displayMember, string valueMember)
        {
            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbo.DataSource = dt;
                    cbo.DisplayMember = displayMember; // Tên hiển thị ra cho ný xem
                    cbo.ValueMember = valueMember;     // ID giấu ngầm bên dưới để Insert vào DB
                }
                catch (Exception ex) { MessageBox.Show("Lỗi load ComboBox: " + ex.Message); }
            }
        }
    }
}