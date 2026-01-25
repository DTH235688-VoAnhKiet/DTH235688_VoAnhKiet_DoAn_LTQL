using QuanLybanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLybanHang.Forms
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;
        private void BatTatChucNang(bool giaTri)
        {
            btnluu.Enabled = giaTri;
            btnhuybo.Enabled = giaTri;
            txttenloai.Enabled = giaTri;

            btnthem.Enabled = !giaTri;
            btnsua.Enabled = !giaTri;
            btnxoa.Enabled = !giaTri;
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<Loaisanpham> lsp = new List<Loaisanpham>();
            lsp = context.LoaiSanPham.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txttenloai.DataBindings.Clear();
            txttenloai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            dgvdanhsachloai.DataSource = bindingSource;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txttenloai.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvdanhsachloai.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvdanhsachloai.CurrentRow.Cells["ID"].Value.ToString());
                Loaisanpham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    context.LoaiSanPham.Remove(lsp);
                }
                context.SaveChanges();

                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttenloai.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Loaisanpham lsp = new Loaisanpham();
                    lsp.TenLoai = txttenloai.Text;
                    context.LoaiSanPham.Add(lsp);

                    context.SaveChanges();
                }
                else
                {
                    Loaisanpham lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txttenloai.Text;
                        context.LoaiSanPham.Update(lsp);

                        context.SaveChanges();
                    }
                }

                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {

            frmLoaiSanPham_Load(sender, e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvdanhsachloai.CurrentRow.Cells["ID"].Value.ToString());
                Loaisanpham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    context.LoaiSanPham.Remove(lsp);
                }
                context.SaveChanges();

                frmLoaiSanPham_Load(sender, e);
            }
        }
    }
}
