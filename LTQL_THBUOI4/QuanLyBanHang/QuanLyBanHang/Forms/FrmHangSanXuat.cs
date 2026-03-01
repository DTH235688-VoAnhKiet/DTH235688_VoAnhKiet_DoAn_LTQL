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
    public partial class FrmHangSanXuat : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;
        public FrmHangSanXuat()
        {
            InitializeComponent();
        }

        private void dgvHangSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHangSanXuat.Rows[e.RowIndex];
                txtTenHangSanXuat.Text = row.Cells["TenHangSanXuat"].Value?.ToString();

            }
        }
        public void Reset()
        {
            txtTenHangSanXuat.Text = string.Empty;
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHangSanXuat.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void FrmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<HangSanXuat> lsp = new List<HangSanXuat>();
            lsp = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            dgvHangSanXuat.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            xuLyThem = true;
            BatTatChucNang(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHangSanXuat.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvHangSanXuat.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    HangSanXuat lsp = new HangSanXuat();
                    lsp.TenHangSanXuat = txtTenHangSanXuat.Text;
                    context.HangSanXuat.Add(lsp);

                    context.SaveChanges();
                }
                else
                {
                    HangSanXuat lsp = context.HangSanXuat.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenHangSanXuat = txtTenHangSanXuat.Text;
                        context.HangSanXuat.Update(lsp);

                        context.SaveChanges();
                    }
                }

                FrmHangSanXuat_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvHangSanXuat.CurrentRow.Cells["ID"].Value.ToString());
                HangSanXuat lsp = context.HangSanXuat.Find(id);
                if (lsp != null)
                {
                    context.HangSanXuat.Remove(lsp);
                }
                context.SaveChanges();

                FrmHangSanXuat_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            FrmHangSanXuat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }
    }
}
