using QLDuAnPhanMemTinHoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuAnPhanMemTinHoc.form
{

    public partial class PhanCongCongViec : Form
    {
        int idPhanCongDangChon = -1;
        int idCongViecDangChon = -1;
        private string quyenHan = "";
        QLDADbContext db = new QLDADbContext();
        public PhanCongCongViec(string vaiTro)
        {
            InitializeComponent();
            this.quyenHan = vaiTro;
            LoadData();
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            if (quyenHan == "Nhân viên")
            {
             
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLuu.Visible = false;
                btnHuy.Visible = false;
            }
        }


        private void LoadData()
        {
            var danhSachPhanCong = (from pccv in db.PhanCongCongViec
                                    join cv in db.CongViec on pccv.CongViecID equals cv.ID
                                    join nv in db.NhanVien on pccv.NhanVienID equals nv.ID
                                    join da in db.DuAn on cv.DuAnID equals da.ID
                                    select new
                                    {
                                        MaPhanCong = pccv.ID, // Lấy ID để làm mồi
                                        MaCongViec = cv.ID,   // Lấy ID công việc
                                        TenDuAn = da.TenDuAn,
                                        TenNhanVien = nv.HoVaTen,
                                        NhiemVu = cv.TenCongViec,
                                        NgayBatDau = cv.NgayBatDau,
                                        HanChot = cv.HanHoanThanh,
                                        TrangThai = cv.TrangThai
                                    }).ToList();

            dgvPhanCong.DataSource = danhSachPhanCong;

            dgvPhanCong.Columns["MaPhanCong"].Visible = false;
            dgvPhanCong.Columns["MaCongViec"].Visible = false;

            // 2. Load dự án vào ComboBox
            cboDuAn.DataSource = db.DuAn.ToList();
            cboDuAn.DisplayMember = "TenDuAn";
            cboDuAn.ValueMember = "ID";

            // 3. Load nhân viên vào ComboBox
            cboNhanVien.DataSource = db.NhanVien.ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "ID";

            cboTrangThai.Items.Clear(); // Xóa sạch trước khi thêm để khỏi bị trùng
            cboTrangThai.Items.Add("Chưa bắt đầu");
            cboTrangThai.Items.Add("Đang thực hiện");
            cboTrangThai.Items.Add("Đã hoàn thành");
            cboTrangThai.Items.Add("Tạm dừng");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenCongViec.Clear();
            cboDuAn.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            cboTrangThai.SelectedIndex = -1;
            txtTenCongViec.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(txtTenCongViec.Text))
            {
                MessageBox.Show("Chưa nhập nhiệm vụ!", "Thông báo");
                txtTenCongViec.Focus();
                return;
            }
            if (cboDuAn.SelectedValue == null || cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Ný chọn thiếu Dự án hoặc Nhân viên rồi!", "Nhắc nhở");
                return;
            }

            try
            {
                // Lấy ID dự án và ID nhân viên từ ComboBox
                int duAnId = (int)cboDuAn.SelectedValue;
                int nhanVienId = (int)cboNhanVien.SelectedValue;

                // ==========================================
                // BƯỚC 1: LƯU VÀO BẢNG CONGVIEC TRƯỚC
                // ==========================================
                CongViec cv = new CongViec();
                cv.DuAnID = duAnId;
                cv.TenCongViec = txtTenCongViec.Text; // Lưu cái ô Nhiệm vụ
                cv.NgayBatDau = dtpStart.Value;
                cv.HanHoanThanh = dtpEnd.Value;       // Lưu Hạn chót
                cv.TrangThai = cboTrangThai.Text;

                // Lưu ý: Nếu DbContext của ný đặt tên là CongViecs (có chữ s) thì thêm s vào nhé
                db.CongViec.Add(cv);
                db.SaveChanges(); // LƯU LẦN 1: Để SQL Server tự động tạo ra một cái ID mới cho công việc này

                // ==========================================
                // BƯỚC 2: GIAO VIỆC ĐÓ CHO NHÂN VIÊN (LƯU VÀO PHANCONGCONGVIEC)
                // ==========================================
                QLDuAnPhanMemTinHoc.Data.PhanCongCongViec pccv = new QLDuAnPhanMemTinHoc.Data.PhanCongCongViec();
                pccv.CongViecID = cv.ID; // Bốc cái ID của công việc vừa mới tạo ở trên xuống đây
                pccv.NhanVienID = nhanVienId;

                // Lưu ý: Nếu DbContext đặt tên là PhanCongCongViecs (có chữ s) thì thêm s vào nhé
                db.PhanCongCongViec.Add(pccv);
                db.SaveChanges(); // LƯU LẦN 2: Chốt đơn!

                MessageBox.Show("Lưu thành công ", "Chúc mừng");

                LoadData(); // Load lại bảng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi ný ơi: " + ex.Message, "Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" bạn muốn đóng form lại à !", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click trúng cái dòng chứa dữ liệu không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhanCong.Rows[e.RowIndex];

                // Lấy 2 cái ID đang bị giấu lưu vào bộ nhớ tạm
                idPhanCongDangChon = Convert.ToInt32(row.Cells["MaPhanCong"].Value);
                idCongViecDangChon = Convert.ToInt32(row.Cells["MaCongViec"].Value);

                // Bắn dữ liệu lên mấy cái ô chữ nhật trên Form
                cboDuAn.Text = row.Cells["TenDuAn"].Value.ToString();
                cboNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtTenCongViec.Text = row.Cells["NhiemVu"].Value.ToString();

                // Đẩy ngày tháng lên
                if (row.Cells["NgayBatDau"].Value != null)
                    dtpStart.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                if (row.Cells["HanChot"].Value != null)
                    dtpEnd.Value = Convert.ToDateTime(row.Cells["HanChot"].Value);

                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã click chọn dòng nào trong bảng chưa
            if (idPhanCongDangChon == -1 || idCongViecDangChon == -1)
            {
                MessageBox.Show("Ný phải click chọn một dòng trong bảng rồi mới bấm Xóa được nha!", "Nhắc nhở");
                return;
            }

            // Hỏi lại cho chắc ăn
            DialogResult dt = MessageBox.Show("Chắc chắn muốn xóa phân công này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                try
                {
                    // Tìm đúng 2 dòng dữ liệu trong Database dựa vào ID
                    var pccv = db.PhanCongCongViec.Find(idPhanCongDangChon);
                    var cv = db.CongViec.Find(idCongViecDangChon);

                    // XÓA: Gỡ thằng phân công trước, gỡ thằng công việc sau
                    if (pccv != null) db.PhanCongCongViec.Remove(pccv);
                    if (cv != null) db.CongViec.Remove(cv);

                    db.SaveChanges(); // Chốt đơn xóa!

                    MessageBox.Show("Xóa bay màu thành công!", "Thông báo");

                    // Xóa xong thì reset lại bộ nhớ ID và Load lại bảng
                    idPhanCongDangChon = -1;
                    idCongViecDangChon = -1;
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã click chọn dòng nào chưa
            if (idPhanCongDangChon == -1 || idCongViecDangChon == -1)
            {
                MessageBox.Show("Ný phải click chọn một dòng trong bảng để Sửa nha!", "Nhắc nhở");
                return;
            }

            try
            {
                // Lôi cổ 2 thằng đó từ Database lên
                var pccv = db.PhanCongCongViec.Find(idPhanCongDangChon);
                var cv = db.CongViec.Find(idCongViecDangChon);

                if (pccv != null && cv != null)
                {
                    // Cập nhật lại thông tin bảng CongViec từ mấy cái ô ný vừa sửa
                    cv.DuAnID = (int)cboDuAn.SelectedValue;
                    cv.TenCongViec = txtTenCongViec.Text;
                    cv.NgayBatDau = dtpStart.Value;
                    cv.HanHoanThanh = dtpEnd.Value;
                    cv.TrangThai = cboTrangThai.Text;

                    // Cập nhật lại thông tin bảng PhanCongCongViec (Lỡ như ný đổi Nhân viên khác)
                    pccv.NhanVienID = (int)cboNhanVien.SelectedValue;

                    db.SaveChanges(); // Chốt đơn cập nhật!

                    MessageBox.Show("Sửa thành công xịn sò!", "Thông báo");

                    // Reset ID và load lại bảng
                    idPhanCongDangChon = -1;
                    idCongViecDangChon = -1;
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message, "Lỗi");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 1. Lấy chữ mà ný vừa gõ vào ô tìm kiếm, cắt bỏ khoảng trắng 2 đầu và in thường hết cho dễ tìm
            // ⚠️ Đổi "txtTimKiem" thành tên cái ô TextBox của ný nha!
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            try
            {
                // 2. Viết LINQ y chang hàm LoadData, nhưng thêm dòng "where" để lọc dữ liệu
                var danhSachTimKiem = (from pccv in db.PhanCongCongViec
                                       join cv in db.CongViec on pccv.CongViecID equals cv.ID
                                       join nv in db.NhanVien on pccv.NhanVienID equals nv.ID
                                       join da in db.DuAn on cv.DuAnID equals da.ID
                                       // Lọc: Tên dự án CÓ CHỨA từ khóa HOẶC Tên nhân viên CÓ CHỨA từ khóa
                                       where da.TenDuAn.ToLower().Contains(tuKhoa) ||
                                             nv.HoVaTen.ToLower().Contains(tuKhoa) ||
                                             cv.TenCongViec.ToLower().Contains(tuKhoa) // Lọc luôn cả nhiệm vụ
                                       select new
                                       {
                                           MaPhanCong = pccv.ID,
                                           MaCongViec = cv.ID,
                                           TenDuAn = da.TenDuAn,
                                           TenNhanVien = nv.HoVaTen,
                                           NhiemVu = cv.TenCongViec,
                                           NgayBatDau = cv.NgayBatDau,
                                           HanChot = cv.HanHoanThanh,
                                           TrangThai = cv.TrangThai
                                       }).ToList();

                // 3. Quăng danh sách đã lọc lên bảng
                dgvPhanCong.DataSource = danhSachTimKiem;

                // Vẫn phải dùng tà đạo giấu 2 cái cột ID đi cho đẹp
                dgvPhanCong.Columns["MaPhanCong"].Visible = false;
                dgvPhanCong.Columns["MaCongViec"].Visible = false;

                // Nếu tìm không ra thằng nào thì báo cho người ta biết
                if (danhSachTimKiem.Count == 0)
                {
                    MessageBox.Show("Tìm đỏ con mắt không thấy ný ơi!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi");
            }
        }
    }
}
