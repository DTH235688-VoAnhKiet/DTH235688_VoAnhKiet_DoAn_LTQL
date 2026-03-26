using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class NhanVien : Form
    {
        private Data.QLDADbContext _context = new Data.QLDADbContext();
        public NhanVien()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            try
            {
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
                    nv.GhiChu     
                }).ToList();

                dgvNhanVien.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtGhiChu.Clear();

            cboGioiTinh.SelectedIndex = -1;
            cboPhongBan.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            dtpNgaySinh.Value = DateTime.Now;
            txtHoTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và SĐT!");
                return;
            }

            // GHI CHÚ QUAN TRỌNG: Thêm "Models." hoặc tên Project vào trước chữ NhanVien 
            // để code không bị nhầm lẫn với cái Form NhanVien hiện tại!
            var nvMoi = new Data.NhanVien()
            {
                HoVaTen = txtHoTen.Text,
                DienThoai = txtSDT.Text,
                Email = txtEmail.Text,
                ChucVu = cboChucVu.Text,
                TenDangNhap = txtHoTen.Text,
                MatKhau = "123",
                QuyenHan = false,
                // Cột mới thêm nè:
                GioiTinh = cboGioiTinh.Text,
                NgaySinh = dtpNgaySinh.Value,
                PhongBan = cboPhongBan.Text,
                TrangThai = cboTrangThai.Text,
                GhiChu = txtGhiChu.Text
            };

            _context.NhanVien.Add(nvMoi);
            _context.SaveChanges();

            LoadDataGrid();
            ClearForm();
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["ID"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoVaTen"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value?.ToString();

                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                cboPhongBan.Text = row.Cells["PhongBan"].Value?.ToString();
                cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên dưới danh sách để sửa!");
                return;
            }

            int id = int.Parse(txtMaNV.Text);
            // Ép kiểu rõ ràng Model NhanVien
            Data.NhanVien nvSua = _context.NhanVien.Find(id);

            if (nvSua != null)
            {
                nvSua.HoVaTen = txtHoTen.Text;
                nvSua.Email = txtEmail.Text;
                nvSua.DienThoai = txtSDT.Text;
                nvSua.NgaySinh = dtpNgaySinh.Value;
                nvSua.GhiChu = txtGhiChu.Text;
                nvSua.GioiTinh = cboGioiTinh.Text;
                nvSua.PhongBan = cboPhongBan.Text;
                nvSua.ChucVu = cboChucVu.Text;
                nvSua.TrangThai = cboTrangThai.Text;

                _context.SaveChanges();
                LoadDataGrid();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn nhân viên nào chưa
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa từ danh sách!", "Thông báo");
                return;
            }

            // 2. Hiện bảng hỏi xác nhận
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtMaNV.Text);
                    var nvXoa = _context.NhanVien.Find(id);

                    if (nvXoa != null)
                    {
                        _context.NhanVien.Remove(nvXoa);
                        _context.SaveChanges(); // Lưu thay đổi xuống Database

                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadDataGrid(); // Tải lại bảng để cập nhật danh sách mới
                        ClearForm();    // Xóa trắng các ô nhập liệu
                    }
                }
                catch (Exception ex)
                {
                    // Lỗi này thường xảy ra nếu Nhân viên này đang được phân công trong Dự án
                    MessageBox.Show("Không thể xóa nhân viên này vì đang có dữ liệu liên quan ở bảng khác!\nChi tiết: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
