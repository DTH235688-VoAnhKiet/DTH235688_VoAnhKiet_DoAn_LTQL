using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
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
using BC = BCrypt.Net.BCrypt;
using ClosedXML.Excel;

namespace QuanLyBanHang.Forms
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false;
        int id;
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTiemKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvNhanVien.AutoGenerateColumns = false;

            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            // Tương tự đối với txtDienThoai, txtDiaChi, txtTenDangNhap 

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            dgvNhanVien.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();

                FrmNhanVien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text); // Mã hóa mật khẩu 
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Add(nv);

                        context.SaveChanges();
                    }
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Update(nv);

                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ 
                        else
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text); // Cập nhật mật khẩu mới
                        context.SaveChanges();
                    }
                }

                FrmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            FrmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    bool firstRow = true; // KHAI BÁO Ở ĐÂY để không bị lỗi context

                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                    } // Kết thúc using

                    // Bây giờ biến firstRow đã có thể sử dụng ở đây
                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow r in table.Rows)
                        {
                            // Tùy theo form mà bạn đổi Class tương ứng (NhanVien, KhachHang...)
                            NhanVien nv = new NhanVien();
                            nv.HoVaTen = r["HoVaTen"].ToString();
                            nv.DienThoai = r["DienThoai"].ToString();
                            nv.DiaChi = r["DiaChi"].ToString();
                            nv.TenDangNhap = r["TenDangNhap"].ToString();
                            if(table.Columns.Contains("MatKhau") && !string.IsNullOrWhiteSpace(r["MatKhau"].ToString()))
                            {
                                nv.MatKhau = BC.HashPassword(r["MatKhau"].ToString());
                            }
                            else
                            {
                                nv.MatKhau = BC.HashPassword("123456");
                            }
                            string quyen = r["QuyenHan"].ToString().ToLower().Trim();
                            nv.QuyenHan = (quyen == "true " || quyen == "1" || quyen == "quản trị");

                            context.NhanVien.Add(nv);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Gọi lại hàm load của form tương ứng
                        FrmNhanVien_Load(sender, e);
                    }
                    else if (firstRow) // Không còn bị lỗi "does not exist" nữa
                    {
                        MessageBox.Show("Tập tin Excel rỗng hoặc không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "Nhân viên_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("HoVaTen", typeof(string)),
                new DataColumn("DienThoai", typeof(string)),
                new DataColumn("DiaChi", typeof(string)),
                new DataColumn("TenDangNhap", typeof(string)),
                new DataColumn("QuyenHan", typeof(string))
            });

                    var listNhanVien = context.NhanVien.ToList();
                    foreach (var item in listNhanVien)
                    {
                        table.Rows.Add(
                            item.ID,
                            item.HoVaTen,
                            item.DienThoai,
                            item.DiaChi,
                            item.TenDangNhap,
                            item.QuyenHan == true ? "Quản trị" : "Nhân viên"
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
                        sheet.Columns().AdjustToContents(); // Tự động căn chỉnh độ rộng cột [cite: 104]
                        wb.SaveAs(saveFileDialog.FileName); // Lưu file [cite: 105]
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
