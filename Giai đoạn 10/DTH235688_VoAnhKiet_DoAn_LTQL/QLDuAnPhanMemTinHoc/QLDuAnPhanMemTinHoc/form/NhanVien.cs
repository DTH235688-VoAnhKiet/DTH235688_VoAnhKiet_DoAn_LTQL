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
        private int idNhanVienDangChon = -1; // Lưu ID thực tế trong cơ sở dữ liệu

        public NhanVien()
        {
            InitializeComponent();
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            
            // Lưu ý: Tên bảng trong DbSet phải khớp với code bên dưới
            btnThemMoi.Click += btnThemMoi_Click_1;
            btnSua.Click += btnSua_Click_1;
            btnXoa.Click += btnXoa_Click_1;
            btnLuu.Click += btnLuu_Click_1;
            btnHuyBo.Click += btnHuyBo_Click_1;
            btnThoat.Click += btnThoat_Click_1;
            btnTimKiem.Click += btnTimKiem_Click;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick_1;

            StylizeForm();
            LoadDataGrid();
            SetStatus(true); // Luôn mở khóa 
        }

        private void StylizeForm()
        {
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            foreach (Control c in this.Controls)
            {
                StylizeControls(c);
            }
        }

        private void StylizeControls(Control parent)
        {
            if (parent is System.Windows.Forms.Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;

                string text = btn.Text.ToLower();
                if (text.Contains("thêm")) btn.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
                else if (text.Contains("sửa") || text.Contains("cập nhật")) btn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
                else if (text.Contains("xóa")) btn.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
                else if (text.Contains("lưu")) btn.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
                else if (text.Contains("hủy") || text.Contains("thoát")) btn.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
                else if (text.Contains("tìm") || text.Contains("search")) btn.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
                else if (text.Contains("excel")) btn.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
                else btn.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            }
            else if (parent is DataGridView dgv)
            {
                dgv.BackgroundColor = System.Drawing.Color.White;
                dgv.BorderStyle = BorderStyle.None;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            }

            foreach (Control c in parent.Controls)
            {
                StylizeControls(c);
            }
        }

        private void LoadDataGrid()
        {
            try
            {
                _context = new Data.QLDADbContext();
                var data = _context.NhanVien.Select(nv => new
                {
                    ID_Goc = nv.ID, 
                    MaNV = nv.MaNhanVien ?? "Chưa có",
                    nv.HoVaTen,
                    nv.DienThoai,
                    nv.Email,
                    nv.ChucVu,
                    nv.TrangThai,
                    nv.GioiTinh,
                    nv.PhongBan,
                    nv.NgaySinh,
                    nv.TenDangNhap,
                    nv.QuyenHan,
                    nv.GhiChu
                }).ToList();

                dgvNhanVien.DataSource = data;
                
                if (dgvNhanVien.Columns["ID_Goc"] != null) dgvNhanVien.Columns["ID_Goc"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private void SetStatus(bool editing)
        {
            // Chỉ mở khóa các ô nhập liệu khi đang trong chế độ Thêm hoặc Sửa
            txtHoTen.Enabled = editing;
            txtEmail.Enabled = editing;
            txtSDT.Enabled = editing;
            txtTenDangNhap.Enabled = editing;
            txtMatKhau.Enabled = editing;
            cboGioiTinh.Enabled = editing;
            cboPhongBan.Enabled = editing;
            cboChucVu.Enabled = editing;
            cboTrangThai.Enabled = editing;
            cboQuyenHan.Enabled = editing;
            dtpNgaySinh.Enabled = editing;
            txtGhiChu.Enabled = editing;

            // Nút Lưu và Hủy chỉ hiện khi đang sửa
            btnLuu.Enabled = editing;
            btnHuyBo.Enabled = editing;

            // Các nút chức năng chính
            btnThemMoi.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
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

            // 1. Lấy từ khóa tìm kiếm, chuẩn hóa chuỗi để tìm chính xác hơn
            cboGioiTinh.SelectedIndex = -1;
            cboPhongBan.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            cboQuyenHan.SelectedIndex = -1;

            dtpNgaySinh.Value = DateTime.Now;

            txtHoTen.Focus();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnThemMoi_Click_1(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua_Click_1(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            btnHuyBo_Click_1(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu_Click_1(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa_Click_1(sender, e);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhanVien_CellClick_1(sender, e);
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
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi form Quản lý nhân viên?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên nhân viên!");
                return;
            }

            if (!string.IsNullOrEmpty(txtSDT.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! (Phải có 10 chữ số và bắt đầu bằng số 0)", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ! (Ví dụ: abc@gmail.com)", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                if (isThem) // --- CHẾ ĐỘ THÊM MỚI ---
                {
                    // Cập nhật lại thông tin bảng CongViec từ dữ liệu trên Form
                    int nextID = 1;
                    if (_context.NhanVien.Any())
                    {
                        nextID = _context.NhanVien.Max(x => x.ID) + 1;
                    }
                    string maMoi = "NV" + nextID.ToString("D3");

                    var nvMoi = new Data.NhanVien()
                    {
                        MaNhanVien = maMoi,
                        HoVaTen = txtHoTen.Text,
                        DienThoai = txtSDT.Text,
                        Email = txtEmail.Text,
                        TenDangNhap = txtTenDangNhap.Text,
                        MatKhau = txtMatKhau.Text,
                        GioiTinh = cboGioiTinh.Text,
                        // Cập nhật lại thông tin bảng PhanCongCongViec (Nếu thay đổi Nhân viên)
                        PhongBan = cboPhongBan.Text,
                        ChucVu = cboChucVu.Text,
                        TrangThai = cboTrangThai.Text,
                        NgaySinh = dtpNgaySinh.Value,
                        GhiChu = txtGhiChu.Text,
                        QuyenHan = (cboQuyenHan.Text == "Admin")
                    };
                    _context.NhanVien.Add(nvMoi);
                }
                else // --- CHẾ ĐỘ SỬA ---
                {
                    if (idNhanVienDangChon == -1)
                    {
                        MessageBox.Show("Vui lòng chọn một nhân viên để thực hiện thay đổi!");
                        return;
                    }

                    var nvSua = _context.NhanVien.Find(idNhanVienDangChon);
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

                _context.SaveChanges(); 
                MessageBox.Show("Dữ liệu đã được lưu thành công.");
                LoadDataGrid(); 
                SetStatus(false); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (idNhanVienDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa từ danh sách!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này? Dữ liệu đã xóa sẽ không thể khôi phục.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var nv = _context.NhanVien.Find(idNhanVienDangChon);
                    if (nv != null)
                    {
                        _context.NhanVien.Remove(nv);
                        _context.SaveChanges();
                        
                        LoadDataGrid(); 
                        ClearForm();    
                        idNhanVienDangChon = -1;
                        MessageBox.Show("Đã xóa nhân viên thành công.");
                    }
                }
                catch (Exception)
                {
                    // Lỗi này thường do vướng Khóa ngoại (Foreign Key)
                    MessageBox.Show("Không thể xóa nhân viên này vì họ đang có dữ liệu liên quan (Dự án, Công việc hoặc Bug).\n\nGợi ý: Bạn nên chuyển Trạng thái của nhân viên sang 'Đã nghỉ việc' thay vì xóa hoàn toàn để giữ lại lịch sử hệ thống.", "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;
            isThem = false; 
            SetStatus(true); 
            txtHoTen.Focus();
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            isThem = true; 
            ClearForm();   
            SetStatus(true); 
            txtMaNV.Text = string.Empty; 
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
                // Lấy ID gốc để làm việc dưới nền
                idNhanVienDangChon = int.Parse(row.Cells["ID_Goc"].Value?.ToString() ?? "-1");

                // Sử dụng TextBox tìm kiếm tương ứng trên form
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
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