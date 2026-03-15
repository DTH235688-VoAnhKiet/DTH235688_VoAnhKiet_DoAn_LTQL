using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{


    public partial class frmMain : Form
    {

        FrmLoaiSanPham loaiSanPham = null;
        FrmHangSanXuat hangSanXuat = null;
        FrmSanPham sanPham = null;
        FrmKhachHang khachHang = null;
        FrmNhanVien nhanVien = null;
        FrmHoaDon hoaDon = null;
        string hoVaTenNhanVien = "";
        public void DangNhap()
        {
            frmDangNhap frm = new frmDangNhap();
            frm.MainForm = this;
            frm.ShowDialog();
            frmDangNhap dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                Application.Exit();
            }
        }
        public string HoVaTenNhanVien
        {
            get { return hoVaTenNhanVien; }
            set { hoVaTenNhanVien = value; }
        }
        public frmMain()
        {
            InitializeComponent();

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaiSanPham == null || loaiSanPham.IsDisposed)
            {
                loaiSanPham = new FrmLoaiSanPham();
                loaiSanPham.MdiParent = this;
                loaiSanPham.Show();
            }
            else
                loaiSanPham.Activate();
        }
        public void ChuaDangNhap()
        {
            // Sáng đăng nhập 
            mnuDangNhap.Enabled = true;

            // Mờ tất cả 
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;

            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenQuanLy()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng quản lý không được phép 


            // Sáng đăng xuất và các chức năng quản lý được phép 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuLoaiSanPham.Enabled = true;
            mnuHangSanXuat.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng nhân viên không được phép 
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhanVien.Enabled = false;

            // Sáng đăng xuất và các chức năng nhân viên được phép 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;

        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }
    }
}
