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
        private string strKetNoi = @"Data Source=DESKTOP-AH4SISS\SQLEXPRESS;Initial Catalog=QLDA;Integrated Security=True";

        // Tạm thời fix cứng ID nhân viên = 1 để test. 
        // Mai mốt ný lấy ID này từ Form Đăng Nhập truyền qua nha!
        private int maNhanVienDangNhap ;

        // Biến lưu lại Mã công việc đang được click chọn trong bảng
        private int maCongViecDangChon = -1;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private DataGridView dgvCongViec;
        private ComboBox cboTrangThai;
        private NumericUpDown nudTienDo;

        public CongViecCuaToi(int maNhanVienDuocTruyenVao)
        {
            InitializeComponent();
            this.maNhanVienDangNhap = maNhanVienDuocTruyenVao;
            this.Load += CongViecCuaToi_Load;

        }

        private void CongViecCuaToi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(245, 246, 250);

            XayDungGiaoDien();
            LoadDuLieuTuDatabase();
        }

        private void XayDungGiaoDien()
        {
            // 1. TIÊU ĐỀ
            Label lblTitle = new Label { Text = "CÔNG VIỆC CỦA TÔI", Font = new Font("Segoe UI", 20, FontStyle.Bold), Location = new Point(30, 25), AutoSize = true };
            this.Controls.Add(lblTitle);

            // 2. KHU VỰC CẬP NHẬT TIẾN ĐỘ
            Panel pnlCapNhat = new Panel { Location = new Point(450, 20), Size = new Size(530, 80), BackColor = Color.White };
            pnlCapNhat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCapNhat.Width, pnlCapNhat.Height, 10, 10));

            Label lblTrangThai = new Label { Text = "Trạng thái:", Location = new Point(15, 30), AutoSize = true, Font = new Font("Segoe UI", 10) };
            cboTrangThai = new ComboBox { Location = new Point(100, 28), Width = 130, Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };
            cboTrangThai.Items.AddRange(new string[] { "Chưa làm", "Đang làm", "Hoàn thành" });
            cboTrangThai.SelectedIndex = 1;

            Label lblTienDo = new Label { Text = "Tiến độ (%):", Location = new Point(250, 30), AutoSize = true, Font = new Font("Segoe UI", 10) };
            nudTienDo = new NumericUpDown { Location = new Point(340, 28), Width = 60, Font = new Font("Segoe UI", 10), Minimum = 0, Maximum = 100, Value = 50 };

            Button btnCapNhat = new Button
            {
                Text = "CẬP NHẬT",
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(420, 20),
                Size = new Size(110, 40), // FIX 1: Tăng chiều rộng lên 110
                Cursor = Cursors.Hand
            };
            btnCapNhat.FlatAppearance.BorderSize = 0;
            btnCapNhat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCapNhat.Width, btnCapNhat.Height, 8, 8));
            btnCapNhat.Click += btnCapNhat_Click;

            pnlCapNhat.Controls.Add(lblTrangThai); pnlCapNhat.Controls.Add(cboTrangThai);
            pnlCapNhat.Controls.Add(lblTienDo); pnlCapNhat.Controls.Add(nudTienDo); pnlCapNhat.Controls.Add(btnCapNhat);
            this.Controls.Add(pnlCapNhat);
            // 3. BẢNG DANH SÁCH CÔNG VIỆC
            Panel pnlGrid = new Panel
            {
                Location = new Point(30, 120),
                Size = new Size(700, 300), // Cho cái size ban đầu nhỏ gọn lại
                BackColor = Color.White,
                Padding = new Padding(15),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            // FIX 2: Bắt sự kiện Resize! Mỗi khi bảng bị kéo giãn, tự động vẽ lại khuôn bo góc!
            pnlGrid.Resize += (sender, e) =>
            {
                pnlGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlGrid.Width, pnlGrid.Height, 15, 15));
            };

            // Khởi tạo Region lần đầu tiên
            pnlGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlGrid.Width, pnlGrid.Height, 15, 15));

            dgvCongViec = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                Font = new Font("Segoe UI", 10),
                RowTemplate = { Height = 40 }
            };

            dgvCongViec.EnableHeadersVisualStyles = false; dgvCongViec.ColumnHeadersHeight = 45;
            dgvCongViec.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvCongViec.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCongViec.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCongViec.CellClick += dgvCongViec_CellClick;

            pnlGrid.Controls.Add(dgvCongViec);
            this.Controls.Add(pnlGrid);
        }

        private void LoadDuLieuTuDatabase()
        {
            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                // Câu SQL lấy Công việc của nhân viên đang đăng nhập + Lấy Tiến độ mới nhất
                string query = @"
                    SELECT 
                        cv.ID AS [Mã Task], 
                        cv.TenCongViec AS [Tên Công Việc], 
                        da.TenDuAn AS [Thuộc Dự Án], 
                        cv.HanHoanThanh AS [Deadline], 
                        cv.TrangThai AS [Trạng Thái], 
                        ISNULL((SELECT TOP 1 PhanTram FROM TienDo td WHERE td.CongViecID = cv.ID ORDER BY NgayCapNhat DESC), 0) AS [Tiến Độ]
                    FROM CongViec cv
                    INNER JOIN PhanCongCongViec pccv ON cv.ID = pccv.CongViecID
                    INNER JOIN DuAn da ON cv.DuAnID = da.ID
                    WHERE pccv.NhanVienID = @NhanVienID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@NhanVienID", maNhanVienDangNhap);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCongViec.DataSource = dt;

                foreach (DataGridViewColumn column in dgvCongViec.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra có click trúng dòng chứa dữ liệu không
            {
                DataGridViewRow row = dgvCongViec.Rows[e.RowIndex];

                // Lấy ID công việc đang chọn
                maCongViecDangChon = Convert.ToInt32(row.Cells["Mã Task"].Value);

                // Gán dữ liệu lên ComboBox Trạng Thái
                string trangThai = row.Cells["Trạng Thái"].Value?.ToString();
                if (!string.IsNullOrEmpty(trangThai)) cboTrangThai.SelectedItem = trangThai;

                // Gán dữ liệu lên cục NumericUpDown Tiến độ
                if (row.Cells["Tiến Độ"].Value != DBNull.Value)
                {
                    nudTienDo.Value = Convert.ToInt32(row.Cells["Tiến Độ"].Value);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (maCongViecDangChon == -1)
            {
                MessageBox.Show("Vui lòng click chọn một công việc trong bảng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                conn.Open();

                // 1. Update Trạng Thái vào bảng CongViec
                string updateCV = "UPDATE CongViec SET TrangThai = @TrangThai WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(updateCV, conn))
                {
                    cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID", maCongViecDangChon);
                    cmd.ExecuteNonQuery();
                }

                // 2. Thêm mới lịch sử vào bảng TienDo
                string insertTienDo = "INSERT INTO TienDo (CongViecID, PhanTram, NgayCapNhat) VALUES (@CongViecID, @PhanTram, GETDATE())";
                using (SqlCommand cmd = new SqlCommand(insertTienDo, conn))
                {
                    cmd.Parameters.AddWithValue("@CongViecID", maCongViecDangChon);
                    cmd.Parameters.AddWithValue("@PhanTram", nudTienDo.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật tiến độ thành công nha ný!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật xong thì load lại cái bảng cho nó mới
            LoadDuLieuTuDatabase();
        }
    }
}