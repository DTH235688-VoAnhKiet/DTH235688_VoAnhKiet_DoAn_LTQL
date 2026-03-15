using QuanLyBanHang.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using BCrypt.Net;

namespace QuanLyBanHang.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmMain MainForm;
        QLBHDbContext context = new QLBHDbContext();

        public string HoVaTenNhanVien = "";
        public bool QuyenHan = false;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (tenDangNhap == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi");
                txtTenDangNhap.Focus();
                return;
            }

            if (matKhau == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi");
                txtMatKhau.Focus();
                return;
            }

            var nhanVien = context.NhanVien
                .SingleOrDefault(r => r.TenDangNhap == tenDangNhap);

            if (nhanVien == null)
            {
                MessageBox.Show("Tên đăng nhập không đúng!", "Lỗi");
                txtTenDangNhap.Focus();
            }
            else
            {
                if (BCrypt.Net.BCrypt.Verify(matKhau, nhanVien.MatKhau))
                {
                    HoVaTenNhanVien = nhanVien.HoVaTen;
                    QuyenHan = nhanVien.QuyenHan;

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng!", "Lỗi");
                    txtMatKhau.Focus();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}