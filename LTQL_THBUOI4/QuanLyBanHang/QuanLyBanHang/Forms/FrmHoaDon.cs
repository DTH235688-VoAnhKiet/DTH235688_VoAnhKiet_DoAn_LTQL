using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Forms
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        int id;

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataHoaDon();
        }

        private void LoadDataHoaDon()
        {
            // Khởi tạo lại DbContext để đảm bảo luôn lấy dữ liệu mới nhất từ SQL Server
            context = new QLBHDbContext();

            dgvHoaDon.AutoGenerateColumns = false;

            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(x => (double)x.SoLuongBan * x.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dgvHoaDon.DataSource = hd;
        }
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (FrmHoaDon_ChiTiet frmHoaDon_ChiTiet = new FrmHoaDon_ChiTiet())
            {
                // Code sẽ tạm dừng ở đây chờ bạn thao tác bên form Chi tiết
                frmHoaDon_ChiTiet.ShowDialog();

                // Ngay sau khi form Chi tiết đóng lại, dòng này sẽ chạy để làm mới DataGridView
                LoadDataHoaDon();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["cotID"].Value.ToString());
                using (FrmHoaDon_ChiTiet chiTiet = new FrmHoaDon_ChiTiet(id))
                {
                    chiTiet.ShowDialog();

                    // Cập nhật lại lưới sau khi sửa xong và đóng form
                    LoadDataHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                // Hiện MessageBox xác nhận xóa 
                var traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không? Dữ liệu chi tiết hóa đơn cũng sẽ bị xóa.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Khi xác nhận thành công thì tiến hành xóa 
                if (traloi == DialogResult.Yes)
                {
                    int maHoaDon = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["cotID"].Value.ToString());

                    // Tìm hóa đơn trong CSDL
                    var hoaDon = context.HoaDon.Find(maHoaDon);

                    if (hoaDon != null)
                    {
                        // Khi xóa hóa đơn thì cũng xóa luôn dữ liệu chi tiết hóa đơn 
                        var chiTiet = context.HoaDon_ChiTiet.Where(ct => ct.HoaDonID == maHoaDon).ToList();
                        if (chiTiet.Any())
                        {
                            context.HoaDon_ChiTiet.RemoveRange(chiTiet);
                        }

                        // Xóa hóa đơn chính
                        context.HoaDon.Remove(hoaDon);

                        // Lưu các thay đổi vào CSDL
                        context.SaveChanges();

                        MessageBox.Show("Đã xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tải lại form để cập nhật DataGridView 
                        FrmHoaDon_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào đúng cột "XemChiTiet" và không click vào tiêu đề cột (RowIndex >= 0)
            if (e.RowIndex >= 0 && dgvHoaDon.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                // Lấy ID hóa đơn từ dòng được click
                int maHoaDon = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["cotID"].Value.ToString());

                // Mở form chi tiết và truyền ID sang (giống như chức năng Sửa)
                using (FrmHoaDon_ChiTiet chiTiet = new FrmHoaDon_ChiTiet(maHoaDon, true))
                {
                    chiTiet.ShowDialog();

                    // Tải lại dữ liệu sau khi đóng form chi tiết (nếu bạn có chỉnh sửa gì đó bên trong)
                    LoadDataHoaDon();
                }
            }
        }
    }
}
