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
    public partial class KhachHang : Form
    {
        Data.QLDADbContext _context = new Data.QLDADbContext();
        public KhachHang()
        {
            InitializeComponent();
            this.Load += KhachHang_Load;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Lấy danh sách từ bảng KhachHang

                var danhSachKhachHang = _context.KhachHang
                    .Select(kh => new
                    {
                        kh.ID,
                        kh.MaKhachHang, // Thêm dòng này
                        kh.TenKhachHang,
                        kh.DienThoai,
                        kh.Email,
                        kh.DiaChi,
                        kh.NguoiDaiDien
                    }).ToList();

                // Đổ dữ liệu vào DataGridView
                dgvKhachHang.DataSource = danhSachKhachHang;

                //  Cho phép hiện cả thanh cuộn ngang và dọc
                dgvKhachHang.ScrollBars = ScrollBars.Both;

                // Chế độ cột: Đừng dùng Fill nếu bạn muốn kéo ngang. 
                // Dùng None hoặc AllCells để cột giữ đúng độ rộng của nó và hiện thanh cuộn.
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                // Đặt độ rộng cố định cho các cột dài
                dgvKhachHang.Columns["ID"].Visible = false;
                dgvKhachHang.Columns["MaKhachHang"].Width = 100;
                dgvKhachHang.Columns["TenKhachHang"].Width = 250; // Tên dài nên cho rộng ra
                dgvKhachHang.Columns["DienThoai"].Width = 120;
                dgvKhachHang.Columns["Email"].Width = 180;
                dgvKhachHang.Columns["DiaChi"].Width = 350; // Địa chỉ thường rất dài, cho rộng để kéo ngang xem



                // Căn chỉnh lại tiêu đề cột cho đẹp mắt
                // Căn chỉnh lại tiêu đề cột cho đẹp mắt
                // Lưu ý: Tên trong ngoặc phải khớp 100% với tên biến trong class KhachHang
                dgvKhachHang.Columns["MaKhachHang"].HeaderText = "Mã KH";
                dgvKhachHang.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
                dgvKhachHang.Columns["TenKhachHang"].Width = 200;
                dgvKhachHang.Columns["DienThoai"].HeaderText = "Điện Thoại"; // Trong class bạn đặt là DienThoai chứ không phải SDT
                dgvKhachHang.Columns["Email"].HeaderText = "Email";
                dgvKhachHang.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgvKhachHang.Columns["DiaChi"] != null)
                {
                    dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    dgvKhachHang.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                if (dgvKhachHang.Columns["NguoiDaiDien"] != null)
                {
                    dgvKhachHang.Columns["NguoiDaiDien"].HeaderText = "Người Đại Diện";
                    dgvKhachHang.Columns["NguoiDaiDien"].Width = 150;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachHang.CurrentRow != null)
                {
                    // Hỏi xác nhận trước khi xóa
                    var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        int idCanXoa = (int)dgvKhachHang.CurrentRow.Cells["ID"].Value;
                        var khXoa = _context.KhachHang.Find(idCanXoa);

                        if (khXoa != null)
                        {
                            _context.KhachHang.Remove(khXoa);
                            _context.SaveChanges();

                            LoadData(); // Load lại bảng
                                        // Xóa trắng các ô nhập sau khi xóa thành công
                            txtMaKH.Clear();
                            txtTenKhachHang.Clear();
                            txtSDT.Clear();
                            txtEmail.Clear();
                            txtDiaChi.Clear();
                            txtNguoiDaiDien.Clear();

                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem người dùng đã nhập đủ thông tin bắt buộc chưa (các ô có dấu *)
                // LƯU Ý: Bạn hãy thay đổi "txtTenCongTy" và "txtSDT" thành đúng Tên (Name) của các ô TextBox trên form của bạn nhé!
                if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập Tên công ty và Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng lại không làm tiếp
                }

                // 2. Tạo một đối tượng Khách hàng mới để chuẩn bị lưu vào Database
                var khachHangMoi = new Data.KhachHang()
                {
                    // Gán dữ liệu từ TextBox vào các cột trong Database
                    MaKhachHang = txtMaKH.Text,
                    TenKhachHang = txtTenKhachHang.Text,
                    DienThoai = txtSDT.Text,
                    Email = txtEmail.Text,
                    DiaChi = txtDiaChi.Text,
                    NguoiDaiDien = txtNguoiDaiDien.Text

                    // Lưu ý: Nếu cột ID của bạn là kiểu chuỗi (String) và bạn muốn tự nhập mã, hãy mở comment dòng dưới:
                    // ID = txtMaKH.Text 
                    // Còn nếu ID trong Database của bạn là kiểu số nguyên (Int) tự động tăng thì không cần dòng trên.
                };

                // 3. Thêm vào Context và lưu xuống Database
                _context.KhachHang.Add(khachHangMoi);
                _context.SaveChanges();

                // 4. Thông báo và làm mới lại DataGridView
                MessageBox.Show("Đã thêm khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Gọi lại hàm LoadData để lưới (Grid) cập nhật dòng dữ liệu vừa thêm
                LoadData();

                // (Tùy chọn) Xóa trắng các ô nhập liệu để chuẩn bị nhập người khác
                txtMaKH.Clear();
                txtTenKhachHang.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                txtNguoiDaiDien.Clear();
                txtDiaChi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem người dùng đã chọn dòng nào dưới bảng chưa
                if (dgvKhachHang.CurrentRow != null)
                {
                    // 2. Lấy ID "xịn" (kiểu số) từ cột ID ẩn dưới bảng
                    int idCanTim = (int)dgvKhachHang.CurrentRow.Cells["ID"].Value;

                    // 3. Tìm khách hàng đó trong Database bằng ID
                    var khSua = _context.KhachHang.Find(idCanTim);

                    if (khSua != null)
                    {
                        // 4. Cập nhật thông tin mới từ các ô TextBox vào đối tượng
                        khSua.MaKhachHang = txtMaKH.Text;

                        // Lưu ý: Kiểm tra tên TextBox của bạn là txtTenKhachHang hay txtTenCongTy nhé!
                        khSua.TenKhachHang = txtTenKhachHang.Text;

                        khSua.DienThoai = txtSDT.Text;
                        khSua.Email = txtEmail.Text;
                        khSua.DiaChi = txtDiaChi.Text;

                        // THÊM DÒNG NÀY: Để lưu luôn cả Người đại diện
                        khSua.NguoiDaiDien = txtNguoiDaiDien.Text;

                        // 5. Lưu lại thay đổi vào CSDL
                        _context.SaveChanges();

                        // 6. Tải lại bảng để thấy kết quả mới
                        LoadData();

                        MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng dưới bảng để sửa!", "Nhắc nhở");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra để chắc chắn người dùng không bấm vào tiêu đề cột
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                // Dùng toán tử ?. và ?? "" để nếu dữ liệu bị Null thì nó hiện ô trống, không bị báo lỗi
                // Nhớ kiểm tra kỹ tên "MaKhachHang", "TenKhachHang"... có khớp với cột trong bảng không nhé!
                txtMaKH.Text = row.Cells["MaKhachHang"].Value?.ToString() ?? "";
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim().ToLower(); // Lấy chữ người dùng gõ, viết thường hết cho dễ so sánh

                if (string.IsNullOrEmpty(tuKhoa))
                {
                    // Nếu ô tìm kiếm trống, hiện lại toàn bộ danh sách
                    LoadData();
                    return;
                }

                // Thực hiện lọc trong Database
                var ketQua = _context.KhachHang
                    .Where(kh => kh.TenKhachHang.ToLower().Contains(tuKhoa)
                              || kh.DienThoai.Contains(tuKhoa)
                              || kh.MaKhachHang.ToLower().Contains(tuKhoa))
                    .Select(kh => new
                    {
                        kh.ID,
                        kh.MaKhachHang,
                        kh.TenKhachHang,
                        kh.DienThoai,
                        kh.Email,
                        kh.DiaChi,
                        kh.NguoiDaiDien
                    }).ToList();

                // Đổ kết quả lọc được vào bảng
                dgvKhachHang.DataSource = ketQua;

                // Nếu không tìm thấy ai thì báo một câu
                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào khớp với từ khóa!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
