using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class NhanVien : Form
    {
        private Data.QLDADbContext _context = new Data.QLDADbContext();
        private bool isThem = false;

        public NhanVien()
        {
            InitializeComponent();
            LoadDataGrid();
            SetStatus(false);
        }

        private void LoadDataGrid()
        {
            try
            {
                _context = new Data.QLDADbContext();
                var data = _context.NhanVien.Select(nv => new
                {
                    nv.ID,
                    nv.HoVaTen,
                    nv.DienThoai,
                    nv.Email,
                    nv.ChucVu,
                    nv.TrangThai,
                    nv.GioiTinh,
                    nv.PhongBan,
                    nv.NgaySinh,
                    nv.TenDangNhap,
                    nv.QuyenHan, // Trong DB cái này là bool
                    nv.GhiChu
                }).ToList();

                dgvNhanVien.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private void SetStatus(bool editing)
        {
            // Cho tất cả hiện lên luôn, không quan tâm biến editing nữa
            txtHoTen.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            cboGioiTinh.Enabled = true;
            cboPhongBan.Enabled = true;
            cboChucVu.Enabled = true;
            cboTrangThai.Enabled = true;
            cboQuyenHan.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtGhiChu.Enabled = true;

            // Các nút bấm cũng cho hiện hết luôn
            btnLuu.Enabled = true;
            btnHuyBo.Enabled = true;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void ClearForm()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtGhiChu.Text = "";

            // Reset các ComboBox về dòng đầu tiên hoặc trống
            cboGioiTinh.SelectedIndex = -1;
            cboPhongBan.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            cboQuyenHan.SelectedIndex = -1;

            // Reset ngày tháng về ngày hiện tại
            dtpNgaySinh.Value = DateTime.Now;

            // Đưa con trỏ chuột về ô Họ tên để bắt đầu nhập luôn
            txtHoTen.Focus();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

        }

        // --- ĐÂY LÀ CHỖ QUAN TRỌNG NÈ NÝ ---
        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            var result = _context.NhanVien
                .Where(nv => nv.HoVaTen.ToLower().Contains(keyword) || nv.DienThoai.Contains(keyword))
                .ToList();
            dgvNhanVien.DataSource = result;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Nhập họ tên ný ơi!");
                return;
            }

            try
            {
                if (isThem) // --- CHẾ ĐỘ THÊM MỚI ---
                {
                    var nvMoi = new Data.NhanVien()
                    {
                        HoVaTen = txtHoTen.Text,
                        DienThoai = txtSDT.Text,
                        Email = txtEmail.Text,
                        TenDangNhap = txtTenDangNhap.Text,
                        MatKhau = txtMatKhau.Text,
                        GioiTinh = cboGioiTinh.Text,
                        PhongBan = cboPhongBan.Text,
                        ChucVu = cboChucVu.Text,
                        TrangThai = cboTrangThai.Text,
                        NgaySinh = dtpNgaySinh.Value,
                        GhiChu = txtGhiChu.Text,
                        QuyenHan = (cboQuyenHan.Text == "Admin") // Sửa lỗi ép kiểu
                    };
                    _context.NhanVien.Add(nvMoi);
                }
                else // --- CHẾ ĐỘ SỬA ---
                {
                    int id = int.Parse(txtMaNV.Text);
                    var nvSua = _context.NhanVien.Find(id);
                    if (nvSua != null)
                    {
                        nvSua.HoVaTen = txtHoTen.Text;
                        nvSua.DienThoai = txtSDT.Text;
                        nvSua.Email = txtEmail.Text;
                        nvSua.TenDangNhap = txtTenDangNhap.Text;
                        if (!string.IsNullOrEmpty(txtMatKhau.Text)) nvSua.MatKhau = txtMatKhau.Text;
                        nvSua.GioiTinh = cboGioiTinh.Text;
                        nvSua.PhongBan = cboPhongBan.Text;
                        nvSua.ChucVu = cboChucVu.Text;
                        nvSua.TrangThai = cboTrangThai.Text;
                        nvSua.NgaySinh = dtpNgaySinh.Value;
                        nvSua.GhiChu = txtGhiChu.Text;
                        nvSua.QuyenHan = (cboQuyenHan.Text.Trim() == "Admin");
                    }
                }

                _context.SaveChanges(); // Chốt hạ lưu vào Database
                MessageBox.Show("Lưu thành công rồi nha!");
                LoadDataGrid(); // Load lại bảng
                SetStatus(false); // Lưu xong thì khóa lại cho an toàn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chọn nhân viên muốn xóa đã ný!");
                return;
            }

            if (MessageBox.Show("Ný có chắc muốn xóa người này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(txtMaNV.Text);
                var nv = _context.NhanVien.Find(id);
                if (nv != null)
                {
                    _context.NhanVien.Remove(nv);
                    _context.SaveChanges();
                    LoadDataGrid(); // Load lại bảng sau khi xóa
                    ClearForm();    // Xóa trắng form
                    MessageBox.Show("Xóa xong rồi nha!");
                }
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;
            isThem = false; // Đánh dấu là đang sửa chứ không phải thêm mới
            SetStatus(true); // Mở khóa các ô TextBox, ComboBox để nhập
            txtHoTen.Focus();
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            isThem = true; // Đánh dấu là đang thêm mới
            ClearForm();   // Xóa trắng các ô nhập liệu
            SetStatus(true); // Mở khóa các ô để ný nhập
            txtMaNV.Text = string.Empty; // Mã NV để trống vì DB tự tăng
            txtHoTen.Focus();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            SetStatus(false);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                // Đổ dữ liệu lên các ô
                txtMaNV.Text = row.Cells["ID"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoVaTen"].Value?.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                cboPhongBan.Text = row.Cells["PhongBan"].Value?.ToString();
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();

                // Xử lý Quyền hạn (Admin/Nhân viên)
                if (row.Cells["QuyenHan"].Value != null)
                {
                    string qh = row.Cells["QuyenHan"].Value.ToString().ToLower();
                    cboQuyenHan.Text = (qh == "true" || qh == "1") ? "Admin" : "Nhân viên";
                }

                // Sau khi hiện dữ liệu, khóa các ô lại cho tới khi bấm "Sửa"
                SetStatus(false);
            }
        }
    }
}