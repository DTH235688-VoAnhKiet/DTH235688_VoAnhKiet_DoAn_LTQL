using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace QuanLyBanHang.Forms
{
    public partial class frmSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext();     // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false;                          // Kiểm tra có nhấn vào nút Thêm hay không?
        int id;                                         // Lấy mã sản phẩm (dùng cho Sửa và Xóa)
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Images");
        public frmSanPham()
        {
            InitializeComponent();
        }


        
        public class DanhSachSanPham
        {
            public int ID { get; set; }
            public int HangSanXuatID { get; set; }
            public string TenHangSanXuat { get; set; }  // Thêm 
            public int LoaiSanPhamID { get; set; }
            public string TenLoai { get; set; }         // Thêm 
            public string TenSanPham { get; set; }
            public int DonGia { get; set; }
            public int SoLuong { get; set; }
            public string? HinhAnh { get; set; }
            public string? MoTa { get; set; }
        } 
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = null;
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
            cboLoaiSanPham.SelectedIndex = -1;
        }
        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = null;
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
            cboHangSanXuat.SelectedIndex = -1;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {


            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();
            BatTatChucNang(false);

            dataGridView.AutoGenerateColumns = false;

            List<DanhSachSanPham> sp = context.SanPham
                .Select(r => new DanhSachSanPham
                {
                    ID = r.ID,
                    LoaiSanPhamID = r.LoaiSanPhamID,
                    TenLoai = r.LoaiSanPham.TenLoai,
                    HangSanXuatID = r.HangSanXuatID,
                    TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                    TenSanPham = r.TenSanPham,
                    SoLuong = r.SoLuong,
                    DonGia = r.DonGia,
                    MoTa = r.MoTa,
                    HinhAnh = r.HinhAnh
                }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            // Loại sản phẩm
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add(
                "SelectedValue",
                bindingSource,
                "LoaiSanPhamID",
                false,
                DataSourceUpdateMode.Never
            );

            // Hãng sản xuất
            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add(
                "SelectedValue",
                bindingSource,
                "HangSanXuatID",
                false,
                DataSourceUpdateMode.Never
            );

            // Tên sản phẩm
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add(
                "Text",
                bindingSource,
                "TenSanPham",
                false,
                DataSourceUpdateMode.Never
            );

            //Mô tả
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add(
                "Text",
                bindingSource,
                "MoTa",
                false,
                DataSourceUpdateMode.Never
            );

            // Số lượng
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add(
                "Value",
                bindingSource,
                "SoLuong",
                false,
                DataSourceUpdateMode.Never
            );

            // Đơn giá
            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add(
                "Value",
                bindingSource,
                "DonGia",
                false,
                DataSourceUpdateMode.Never
            );

            // Hình ảnh
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                if (e.Value != null)
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            dataGridView.DataSource = bindingSource;
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                Image image = Image.FromFile(Path.Combine(imagesFolder, e.Value.ToString()));
                image = new Bitmap(image, 24, 24);
                e.Value = image;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.SelectedIndex = -1;
            cboHangSanXuat.SelectedIndex = -1;
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();
                    // Tương tự với các form đã thực hiện
                    context.SaveChanges();
                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        // Tương tự với các form đã thực hiện
                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID sản phẩm đang chọn
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            xuLyThem = false; // Đang xử lý sửa
            BatTatChucNang(true);

            txtTenSanPham.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName.GenerateSlug() + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                SanPham sp = context.SanPham.Find(id); sp.HinhAnh = fileName.GenerateSlug() + ext;
                context.SanPham.Update(sp);
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
