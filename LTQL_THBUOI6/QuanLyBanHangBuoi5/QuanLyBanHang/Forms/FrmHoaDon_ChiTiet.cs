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

    public partial class FrmHoaDon_ChiTiet : Form
    {
        
        QLBHDbContext context = new QLBHDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        int id;                                         // Lấy mã hóa đơn (dùng cho Sửa và Xóa) 
        bool isViewMode;
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();

        private void FrmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {

            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();

            dataGridView1.AutoGenerateColumns = false;
            if (id != 0) // Đã tồn tại chi tiết 
            {
                var hoaDon = context.HoaDon.Where(r => r.ID == id).SingleOrDefault();
                cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;

                var ct = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();

                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }
            if (isViewMode == true)
            {
                // Khóa thông tin chung
                cboNhanVien.Enabled = false;
                cboKhachHang.Enabled = false;
                txtGhiChuHoaDon.ReadOnly = true; // Dùng ReadOnly cho TextBox sẽ đẹp hơn Enabled

                // Đã là chế độ xem thì khóa luôn các chỗ thêm/xóa sản phẩm và nút Lưu
                cboSanPham.Enabled = false;
                numDonGiaBan.Enabled = false;
                numSoLuongBan.Enabled = false;

                btnXacNhanBan.Visible = false;
                btnXoa.Visible = false;
                btnLuuHoaDon.Visible = false;
            }

            dataGridView1.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }
        public FrmHoaDon_ChiTiet(int maHoaDon = 0, bool viewMode = false)
        {
            InitializeComponent();
            id = maHoaDon;
            isViewMode = viewMode;
        }
        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }
        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }

        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView1.Rows.Count == 0) // Thêm 
            {
                // Xóa trắng các trường 
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
            }

            // Nút lưu và xóa chỉ sáng khi có sản phẩm 
            btnLuuHoaDon.Enabled = dataGridView1.Rows.Count > 0;
            btnXoa.Enabled = dataGridView1.Rows.Count > 0;
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongBan.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);

                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin  
                if (chiTiet != null)
                {
                    chiTiet.SoLuongBan = Convert.ToInt16(numSoLuongBan.Value);
                    chiTiet.DonGiaBan = Convert.ToInt32(numDonGiaBan.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value);
                    dataGridView1.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào 
                {
                    // Nếu chưa có sản phẩm nào 
                    DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuongBan = Convert.ToInt16(numSoLuongBan.Value),
                        DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value)
                    };
                    hoaDonChiTiet.Add(ct);
                }
                BatTatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SanPhamID"].Value.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0) // Đã tồn tại chi tiết thì chỉ cập nhật 
                {
                    HoaDon hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                        hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                        context.HoaDon.Update(hd);
                    }
                    // Xóa chi tiết cũ 
                    var old = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                    context.HoaDon_ChiTiet.RemoveRange(old);

                    // Thêm lại chi tiết mới 
                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                        ct.HoaDonID = id;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuongBan = item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        context.HoaDon_ChiTiet.Add(ct);
                    }

                    context.SaveChanges();
                }

                else // Thêm mới 
                {
                    HoaDon hd = new HoaDon();
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    // Thêm chi tiết 
                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                        ct.HoaDonID = hd.ID;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuongBan = item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        context.HoaDon_ChiTiet.Add(ct);
                    }
                    context.SaveChanges();
                }

                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
            var sanPham = context.SanPham.Find(maSanPham);
            numDonGiaBan.Value = sanPham.DonGia;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chọn 1 dòng trên lưới thì dữ liệu sẽ đổ lên các combobox


        }
    }
}
