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
using QLDuAnPhanMemTinHoc.Data;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class DuAn : Form
    {
        private readonly QLDADbContext _context = new QLDADbContext();
        private bool isThem = false;
        public DuAn()
        {
            InitializeComponent();
            this.Load += DuAn_Load;
            LoadDataToCombobox();
        }



        private void DuAn_Load(object sender, EventArgs e)
        {
            LoadDataToCombobox();
            LoadDataGrid();
        }

        private void LoadDataToCombobox()
        {
            try
            {
                // 1. Kéo danh sách Khách hàng từ Database đổ vào cbbKhachHang
                var listKH = _context.KhachHang.ToList();
                cboKhachHang.DataSource = listKH;
                cboKhachHang.DisplayMember = "TenKhachHang"; // Hiện Tên để người dùng dễ nhìn
                cboKhachHang.ValueMember = "ID";             // Lưu ngầm ID để code xử lý

                // 2. Kéo danh sách Nhân viên từ Database đổ vào cbbNguoiQuanLy
                var listNV = _context.NhanVien.ToList();
                cboNguoiQuanLy.DataSource = listNV;
                cboNguoiQuanLy.DisplayMember = "HoVaTen";// Hiện Họ tên
                cboNguoiQuanLy.ValueMember = "ID";           // Lưu ngầm ID

                // Xóa chọn mặc định ban đầu để tránh lỗi lưu nhầm
                cboKhachHang.SelectedIndex = -1;
                cboNguoiQuanLy.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message);
            }
        }

        private void LoadDataGrid()
        {
            try
            {
                var data = _context.DuAn.Select(d => new
                {
                    d.ID,
                    TenDuAn = d.TenDuAn,
                    // Sử dụng d.KhachHang và d.QuanLy theo đúng Model của bạn
                    KhachHang = d.KhachHang != null ? d.KhachHang.TenKhachHang : "Chưa có",
                    NguoiQuanLy = d.QuanLy != null ? d.QuanLy.HoVaTen : "Chưa có",
                    d.NgayBatDau,
                    d.NgayKetThuc,
                    UuTien = d.DoUuTien,
                    d.TrangThai
                }).ToList();

                dgvDuAn.DataSource = data;

                // Ẩn cột ID sau khi đã gán DataSource để tránh lỗi Null
                if (dgvDuAn.Columns["ID"] != null) ;
                //dgvDuAn.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load bảng: " + ex.Message);
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true; // Đánh dấu đang ở chế độ Thêm mới
            ClearForm();   // Hàm xóa trắng các ô nhập liệu (txtTenDA.Text = "", ...)
            SetStatus(true); // Mở khóa các ô TextBox, ComboBox
            txtMaDA.Text = string.Empty; // Mã tự tăng nên để trống
            txtTenDA.Focus(); // Đưa con trỏ vào ô Tên dự án
        }

        private void ClearForm()
        {
            txtMaDA.Text = "";
            txtTenDA.Text = "";
            cboKhachHang.SelectedIndex = -1;
            cboNguoiQuanLy.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void SetStatus(bool status)
        {
            txtTenDA.Enabled = status;
            cboKhachHang.Enabled = status;
            cboNguoiQuanLy.Enabled = status;
            cboTrangThai.Enabled = status;
            dtpNgayBatDau.Enabled = status;
            dtpNgayKetThuc.Enabled = status;

            // Nút Lưu và Hủy chỉ hiện khi đang thêm/sửa
            btnLuu.Enabled = status;
            btnHuy.Enabled = status;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaDA.Text); // Lấy ID từ ô Mã dự án
                var da = _context.DuAn.Find(id);

                if (da != null)
                {
                    da.TenDuAn = txtTenDA.Text;
                    da.NgayBatDau = dtpNgayBatDau.Value;
                    da.NgayKetThuc = dtpNgayKetThuc.Value;
                    da.TrangThai = cboTrangThai.Text;
                    da.KhachHangID = (int)cboKhachHang.SelectedValue;
                    da.QuanLyID = (int)cboNguoiQuanLy.SelectedValue;
                    da.DoUuTien = cboUuTien.Text;

                    _context.SaveChanges();
                    LoadDataGrid(); // Load lại bảng
                    MessageBox.Show("Cập nhật dự án thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void dgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDuAn.Rows[e.RowIndex];

                // Lấy ID ẩn để dùng cho việc Sửa/Xóa
                int id = (int)row.Cells["ID"].Value;
                var da = _context.DuAn.Find(id);

                if (da != null)
                {
                    txtMaDA.Text = row.Cells["ID"].Value?.ToString();
                    txtTenDA.Text = da.TenDuAn;
                    dtpNgayBatDau.Value = da.NgayBatDau ?? DateTime.Now;
                    dtpNgayKetThuc.Value = da.NgayKetThuc ?? DateTime.Now;
                    cboTrangThai.Text = da.TrangThai;
                    cboKhachHang.SelectedValue = da.KhachHangID;
                    cboNguoiQuanLy.SelectedValue = da.QuanLyID;

                }
            }
        }

        // Nút Tìm kiếm theo tên+
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.ToLower();
            var kq = _context.DuAn
                .Where(d => d.TenDuAn.ToLower().Contains(tuKhoa))
                .Select(d => new { d.ID, d.TenDuAn, KhachHang = d.KhachHang.TenKhachHang, d.TrangThai })
                .ToList();
            dgvDuAn.DataSource = kq;
        }

        // ComboBox Lọc trạng thái (Tự động lọc khi chọn)
        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cboLocTrangThai.Text;
            var query = _context.DuAn.AsQueryable();

            if (status != "Tất cả")
            {
                query = query.Where(d => d.TrangThai == status);
            }

            dgvDuAn.DataSource = query.Select(d => new { d.ID, d.TenDuAn, KhachHang = d.KhachHang.TenKhachHang, d.TrangThai }).ToList();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenDA.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên dự án!");
                    return;
                }

                var moi = new QLDuAnPhanMemTinHoc.Data.DuAn()
                {
                    TenDuAn = txtTenDA.Text,
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayKetThuc = dtpNgayKetThuc.Value,
                    TrangThai = cboTrangThai.Text,
                    // Gán trực tiếp vào 2 biến ID này
                    KhachHangID = (int)cboKhachHang.SelectedValue,
                    QuanLyID = (int)cboNguoiQuanLy.SelectedValue,
                    DoUuTien = cboUuTien.Text
                };

                _context.DuAn.Add(moi);
                _context.SaveChanges();

                LoadDataGrid();
                MessageBox.Show("Thêm dự án thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        private void cboNguoiQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDuAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDuAn_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem người dùng đã chọn dòng nào chưa (dựa vào ô Mã dự án)
                if (string.IsNullOrEmpty(txtMaDA.Text))
                {
                    MessageBox.Show("Vui lòng chọn dự án muốn xóa từ bảng bên dưới!", "Thông báo");
                    return;
                }

                // 2. Hỏi xác nhận trước khi xóa (tránh bấm nhầm)
                DialogResult dr = MessageBox.Show("Ný có chắc chắn muốn xóa dự án này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(txtMaDA.Text);
                    var da = _context.DuAn.Find(id);

                    if (da != null)
                    {
                        // 3. Thực hiện xóa
                        _context.DuAn.Remove(da);
                        _context.SaveChanges();

                        // 4. Cập nhật lại giao diện
                        LoadDataGrid();
                        ClearForm(); // Xóa trắng form sau khi xóa xong
                        MessageBox.Show("Đã xóa dự án thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Lỗi này thường xảy ra nếu dự án đang được dùng ở bảng khác (như bảng Công Việc)
                MessageBox.Show("Không thể xóa dự án này! Lỗi: " + ex.Message);
            }
        }
    }
}
