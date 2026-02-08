using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms // Đã bỏ dấu ';' dư thừa và khớp với tên thư mục 'Forms'
{
    public partial class frmLoaiSanPham : Form // Đảm bảo tên lớp khớp với file
    {
        //  Khai báo biến toàn cục
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;

        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        //  Hàm bật/tắt các điều khiển để tránh bấm nhầm
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        // Sự kiện chạy khi Form bắt đầu mở lên
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            try
            {
                // Tải dữ liệu từ CSDL
                var lsp = context.LoaiSanPham.ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = lsp;

                // Xóa các liên kết cũ để tránh lỗi dữ liệu đè lên nhau
                txtTenLoai.DataBindings.Clear();
                // Liên kết TextBox với cột TenLoai
                txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

                // Gán dữ liệu vào lưới hiển thị
                dataGridView.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
            txtTenLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần sửa!");
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);
            // Lấy ID từ dòng đang chọn trên lưới
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    LoaiSanPham lsp = new LoaiSanPham { TenLoai = txtTenLoai.Text };
                    context.LoaiSanPham.Add(lsp);
                }
                else
                {
                    var lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenLoai.Text;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Đã lưu thành công!");
                frmLoaiSanPham_Load(sender, e); // Tải lại danh sách mới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa loại sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                    var lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        context.LoaiSanPham.Remove(lsp);
                        context.SaveChanges();
                        frmLoaiSanPham_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}