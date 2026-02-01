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
    public partial class frmHangSanXuat : Form
    {
        public frmHangSanXuat()
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
            txttenhangsanxuat.Enabled = giaTri;

            btnthem.Enabled = !giaTri;
            btnsua.Enabled = !giaTri;
            btnxoa.Enabled = !giaTri;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<Hangsanxuat> hsx = new List<Hangsanxuat>();
            hsx = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = hsx;

            txttenhangsanxuat.DataBindings.Clear();
            txttenhangsanxuat.DataBindings.Add("Text", bindingSource, "Tenhangsanxuat", false, DataSourceUpdateMode.Never);

            dgvdanhsachhang.DataSource = bindingSource;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txttenhangsanxuat.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvdanhsachhang.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hãng sản xuất?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvdanhsachhang.CurrentRow.Cells["ID"].Value.ToString());
                Hangsanxuat hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    context.HangSanXuat.Remove(hsx);
                }
                context.SaveChanges();

                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttenhangsanxuat.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Hangsanxuat hsx = new Hangsanxuat();
                    hsx.Tenhangsanxuat = txttenhangsanxuat.Text;
                    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Hangsanxuat> entityEntry = context.HangSanXuat.Add(hsx);

                    context.SaveChanges();
                }
                else
                {
                    Hangsanxuat hsx = context.HangSanXuat.Find(id);
                    if (hsx != null)
                    {
                        hsx.Tenhangsanxuat = txttenhangsanxuat.Text;
                        context.HangSanXuat.Update(hsx);

                        context.SaveChanges();
                    }
                }

                frmHangSanXuat_Load(sender, e);
            }

        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hãng sản xuất?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvdanhsachhang.CurrentRow.Cells["ID"].Value.ToString());
                Hangsanxuat hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    context.HangSanXuat.Remove(hsx);
                }
                context.SaveChanges();

                frmHangSanXuat_Load(sender, e);
            }
        }
    }
}
