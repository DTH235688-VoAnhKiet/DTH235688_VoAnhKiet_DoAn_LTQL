using QLDuAnPhanMemTinHoc.Data;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class MainForm : Form
    {
        // Biến lưu trữ form con đang được mở
        private Form activeForm = null;
        private string quyenHan = "";
        private int idDangNhap = 1;

        public MainForm(string vaiTro, int idDuocTruyenVao)
        {

            InitializeComponent();
            this.quyenHan = vaiTro;
            this.idDangNhap = idDuocTruyenVao;
            PhanQuyenGiaoDien();

        }


        private void PhanQuyenGiaoDien()
        {
            // Giờ so sánh với chữ "Admin" đã được chuẩn hóa từ DangNhap
            if (this.quyenHan == "Admin")
            {
                // HIỆN HẾT CHO ADMIN
                btnNhanVien.Visible = true;
                btnKhachHang.Visible = true;
                btnDuAn.Visible = true;
                btnBug.Visible = true;
                btnPhanCong.Text = "📋 Phân công công việc";
            }
            else
            {
                // NHÂN VIÊN: Nếu là "false" hoặc "0"
                btnNhanVien.Visible = false;
                btnKhachHang.Visible = false;
                btnDuAn.Visible = false;
                btnBug.Visible = true;
                btnPhanCong.Text = "📝 Công việc của tôi";
            }
        }



        // Hàm này là "phép thuật" để nhét Form con vào Form cha
        private void OpenChildForm(Form childForm)
        {
            // Nếu có form nào đang mở thì đóng nó lại trước
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false; // Bỏ đặc quyền Form độc lập đi
            childForm.FormBorderStyle = FormBorderStyle.None; // Xóa viền của Form con
            childForm.Dock = DockStyle.Fill; // Phóng to form con cho vừa khít khu vực bên phải

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(childForm); // Thêm form con vào panel bên phải
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); // Hiển thị ra

        }

        // --- CÁC NÚT BẤM BÊN MENU ---

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DuAn());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            OpenChildForm(new KhachHang());
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (this.quyenHan == "Admin") // Nếu là ADMIN
            {
                // Mở form sếp đi giao việc
                OpenChildForm(new QLDuAnPhanMemTinHoc.form.PhanCongCongViec(this.quyenHan));
            }
            else // Nếu là NHÂN VIÊN
            {
                // Mở form nhân viên cập nhật tiến độ
                OpenChildForm(new QLDuAnPhanMemTinHoc.form.CongViecCuaToi(this.idDangNhap));
            }

        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CongViecCuaToi(this.idDangNhap));
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            string tenVaiTro = (this.quyenHan == "1" || this.quyenHan.ToLower() == "true") ? "Admin" : "Nhân viên";
            OpenChildForm(new QLDuAnPhanMemTinHoc.form.TrangChu(tenVaiTro));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string tenVaiTro = (this.quyenHan == "1" || this.quyenHan.ToLower() == "true") ? "Admin" : "Nhân viên";
            OpenChildForm(new QLDuAnPhanMemTinHoc.form.TrangChu(tenVaiTro));
           
        }

        // --- NÚT QUẢN LÝ LỖI (BUG) ---
        private void btnBug_Click(object sender, EventArgs e)
        {
            if (this.quyenHan == "Admin") // NẾU LÀ ADMIN
            {
                // Admin thì truyền số 0 để xem TẤT CẢ Bug
                OpenChildForm(new QLDuAnPhanMemTinHoc.form.Bug(0));
            }
            else // NẾU LÀ NHÂN VIÊN
            {
                // Nhân viên thì truyền ID của họ (idDangNhap) vào để xem Bug CỦA RIÊNG HỌ
                OpenChildForm(new QLDuAnPhanMemTinHoc.form.Bug(this.idDangNhap));
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

    }
}