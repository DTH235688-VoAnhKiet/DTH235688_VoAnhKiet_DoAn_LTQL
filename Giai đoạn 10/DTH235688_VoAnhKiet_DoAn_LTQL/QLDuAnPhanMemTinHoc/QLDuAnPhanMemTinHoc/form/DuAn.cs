using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDuAnPhanMemTinHoc.Data;
using OfficeOpenXml;
using System.IO;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class DuAn : Form
    {
        private readonly QLDADbContext _context = new QLDADbContext();
        private bool isThem = false;
        private int idDuAnDangChon = -1; // Biến ngầm lưu ID thật của dự án

        public DuAn()
        {
            InitializeComponent();
            this.Load += DuAn_Load;
            LoadDataToCombobox();
        }

        private void DuAn_Load(object sender, EventArgs e)
        {
            StylizeForm();
            dgvDuAn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvDuAn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            // Bắt sự kiện tự động format tiền khi gõ
            txtChiPhi.TextChanged += txtChiPhi_TextChanged;

            LoadDataToCombobox();
            LoadDataGrid();
        }

        private void StylizeForm()
        {
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            foreach (Control c in this.Controls)
            {
                StylizeControls(c);
            }
        }

        private void StylizeControls(Control parent)
        {
            if (parent is System.Windows.Forms.Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;

                string text = btn.Text.ToLower();
                if (text.Contains("thêm")) btn.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
                else if (text.Contains("sửa") || text.Contains("cập nhật")) btn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
                else if (text.Contains("xóa")) btn.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
                else if (text.Contains("lưu")) btn.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
                else if (text.Contains("hủy") || text.Contains("thoát")) btn.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
                else if (text.Contains("tìm") || text.Contains("search")) btn.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
                else if (text.Contains("excel")) btn.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
                else btn.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            }
            else if (parent is DataGridView dgv)
            {
                dgv.BackgroundColor = System.Drawing.Color.White;
                dgv.BorderStyle = BorderStyle.None;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            }

            foreach (Control c in parent.Controls)
            {
                StylizeControls(c);
            }
        }

        // --- HÀM TỰ ĐỘNG FORMAT SỐ TIỀN CÓ DẤU CHẤM (1.000.000) LÚC ĐANG NHẬP ---
        private void txtChiPhi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtChiPhi.Text)) return;

                // Tạm thời gỡ event để tránh bị lặp vô tận
                txtChiPhi.TextChanged -= txtChiPhi_TextChanged;

                int selectionStart = txtChiPhi.SelectionStart;
                int lengthBefore = txtChiPhi.Text.Length;

                // Xóa hết các dấu chấm, phẩy, chữ, khoảng trắng để lấy lại số nguyên chất
                string cleanText = txtChiPhi.Text.Replace(".", "").Replace(",", "").Replace("đ", "").Replace(" ", "").Trim();

                if (decimal.TryParse(cleanText, out decimal chiPhi))
                {
                    // Format lại theo chuẩn Việt Nam: có dấu chấm phân cách hàng nghìn
                    txtChiPhi.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0}", chiPhi);

                    // Giữ vị trí con trỏ chuột không bị nhảy lung tung khi gõ
                    int lengthAfter = txtChiPhi.Text.Length;
                    txtChiPhi.SelectionStart = Math.Max(0, selectionStart + (lengthAfter - lengthBefore));
                }

                // Gắn lại event
                txtChiPhi.TextChanged += txtChiPhi_TextChanged;
            }
            catch { }
        }

        private void LoadDataToCombobox()
        {
            try
            {
                var listKH = _context.KhachHang.ToList();
                cboKhachHang.DataSource = listKH;
                cboKhachHang.DisplayMember = "TenKhachHang";
                cboKhachHang.ValueMember = "ID";

                var listNV = _context.NhanVien.ToList();
                cboNguoiQuanLy.DataSource = listNV;
                cboNguoiQuanLy.DisplayMember = "HoVaTen";
                cboNguoiQuanLy.ValueMember = "ID";

                cboKhachHang.SelectedIndex = -1;
                cboNguoiQuanLy.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message);
            }
        }

        private void LoadDataGrid()
        {
            try
            {
                // Bước 1: Lấy dữ liệu thô từ Database
                var dataRaw = _context.DuAn.Select(d => new
                {
                    ID_Goc = d.ID,
                    MaDA = d.MaDuAn ?? "Chưa có",
                    TenDuAn = d.TenDuAn,
                    KhachHang = d.KhachHang != null ? d.KhachHang.TenKhachHang : "Chưa có",
                    NguoiQuanLy = d.QuanLy != null ? d.QuanLy.HoVaTen : "Chưa có",
                    d.NgayBatDau,
                    d.NgayKetThuc,
                    UuTien = d.DoUuTien,
                    d.TrangThai,
                    d.ChiPhi
                }).ToList();

                // Bước 2: Format cột Chi phí thành tiền tệ chuẩn VN (5.000.000 đ) trước khi đưa lên bảng
                var dataFormatted = dataRaw.Select(d => new
                {
                    d.ID_Goc,
                    d.MaDA,
                    d.TenDuAn,
                    d.KhachHang,
                    d.NguoiQuanLy,
                    d.NgayBatDau,
                    d.NgayKetThuc,
                    d.UuTien,
                    d.TrangThai,
                    ChiPhi = d.ChiPhi != null ? string.Format(new CultureInfo("vi-VN"), "{0:N0} đ", d.ChiPhi) : "0 đ"
                }).ToList();

                dgvDuAn.DataSource = dataFormatted;

                // Giấu ID gốc và hiển thị mã DA đẹp trai
                if (dgvDuAn.Columns["ID_Goc"] != null) dgvDuAn.Columns["ID_Goc"].Visible = false;
                if (dgvDuAn.Columns["MaDA"] != null) dgvDuAn.Columns["MaDA"].HeaderText = "Mã Dự Án";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load bảng: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            ClearForm();
            SetStatus(true);
            txtMaDA.Text = string.Empty;
            txtTenDA.Focus();
        }

        private void ClearForm()
        {
            txtMaDA.Text = "";
            txtTenDA.Text = "";
            txtChiPhi.Text = "";
            cboKhachHang.SelectedIndex = -1;
            cboNguoiQuanLy.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void SetStatus(bool status)
        {
            // Bỏ chế độ khóa
            txtTenDA.Enabled = true;
            txtChiPhi.Enabled = true;
            cboKhachHang.Enabled = true;
            cboNguoiQuanLy.Enabled = true;
            cboTrangThai.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (idDuAnDangChon == -1)
                {
                    MessageBox.Show("Vui lòng chọn một dự án để sửa!");
                    return;
                }
                var da = _context.DuAn.Find(idDuAnDangChon);

                if (da != null)
                {
                    da.TenDuAn = txtTenDA.Text;
                    da.NgayBatDau = dtpNgayBatDau.Value;
                    da.NgayKetThuc = dtpNgayKetThuc.Value;
                    da.TrangThai = cboTrangThai.Text;
                    da.KhachHangID = (int)cboKhachHang.SelectedValue;
                    da.QuanLyID = (int)cboNguoiQuanLy.SelectedValue;
                    da.DoUuTien = cboUuTien.Text;

                    // Lọc chữ và dấu chấm để chuyển lại thành số chuẩn lưu DB
                    decimal chiPhiSua = 0;
                    if (!string.IsNullOrEmpty(txtChiPhi.Text))
                    {
                        string cleanText = txtChiPhi.Text.Replace(".", "").Replace(",", "").Replace("đ", "").Replace(" ", "").Trim();
                        decimal.TryParse(cleanText, out chiPhiSua);
                    }
                    da.ChiPhi = chiPhiSua;

                    _context.SaveChanges();
                    LoadDataGrid();
                    MessageBox.Show("Cập nhật dự án thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void dgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDuAn.Rows[e.RowIndex];
                idDuAnDangChon = (int)row.Cells["ID_Goc"].Value;
                var da = _context.DuAn.Find(idDuAnDangChon);

                if (da != null)
                {
                    txtMaDA.Text = da.MaDuAn ?? "Chưa có";
                    txtTenDA.Text = da.TenDuAn;
                    dtpNgayBatDau.Value = da.NgayBatDau ?? DateTime.Now;
                    dtpNgayKetThuc.Value = da.NgayKetThuc ?? DateTime.Now;
                    cboTrangThai.Text = da.TrangThai;
                    cboKhachHang.SelectedValue = da.KhachHangID;
                    cboNguoiQuanLy.SelectedValue = da.QuanLyID;

                    // Hiển thị Chi phí lên Textbox khi nhấn vào (Vẫn hiển thị dạng có dấu chấm)
                    txtChiPhi.Text = da.ChiPhi != null ? string.Format(new CultureInfo("vi-VN"), "{0:N0}", da.ChiPhi) : "";
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.ToLower();

            var rawKq = _context.DuAn
                .Where(d => d.TenDuAn.ToLower().Contains(tuKhoa))
                .Select(d => new {
                    d.ID,
                    d.TenDuAn,
                    KhachHang = d.KhachHang.TenKhachHang,
                    NguoiQuanLy = d.QuanLy.HoVaTen,
                    d.NgayBatDau,
                    d.NgayKetThuc,
                    UuTien = d.DoUuTien,
                    d.TrangThai,
                    d.ChiPhi
                }).ToList();

            var formatKq = rawKq.Select(d => new {
                d.ID,
                d.TenDuAn,
                d.KhachHang,
                d.NguoiQuanLy,
                d.NgayBatDau,
                d.NgayKetThuc,
                d.UuTien,
                d.TrangThai,
                ChiPhi = d.ChiPhi != null ? string.Format(new CultureInfo("vi-VN"), "{0:N0} đ", d.ChiPhi) : "0 đ"
            }).ToList();

            dgvDuAn.DataSource = formatKq;
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cboLocTrangThai.Text;
            var query = _context.DuAn.AsQueryable();

            if (status != "Tất cả")
            {
                query = query.Where(d => d.TrangThai == status);
            }

            var rawData = query.Select(d => new {
                d.ID,
                d.TenDuAn,
                KhachHang = d.KhachHang.TenKhachHang,
                NguoiQuanLy = d.QuanLy.HoVaTen,
                d.NgayBatDau,
                d.NgayKetThuc,
                UuTien = d.DoUuTien,
                d.TrangThai,
                d.ChiPhi
            }).ToList();

            var formatData = rawData.Select(d => new {
                d.ID,
                d.TenDuAn,
                d.KhachHang,
                d.NguoiQuanLy,
                d.NgayBatDau,
                d.NgayKetThuc,
                d.UuTien,
                d.TrangThai,
                ChiPhi = d.ChiPhi != null ? string.Format(new CultureInfo("vi-VN"), "{0:N0} đ", d.ChiPhi) : "0 đ"
            }).ToList();

            dgvDuAn.DataSource = formatData;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
            SetStatus(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenDA.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên dự án!");
                    return;
                }

                // Lọc bỏ dấu chấm, khoảng trắng, chữ 'đ' trước khi lưu
                decimal chiPhiMoi = 0;
                if (!string.IsNullOrEmpty(txtChiPhi.Text))
                {
                    string cleanText = txtChiPhi.Text.Replace(".", "").Replace(",", "").Replace("đ", "").Replace(" ", "").Trim();
                    decimal.TryParse(cleanText, out chiPhiMoi);
                }

                // Tự động sinh mã DA mới
                int nextID = 1;
                if (_context.DuAn.Any())
                {
                    nextID = _context.DuAn.Max(x => x.ID) + 1;
                }
                string maMoi = "DA" + nextID.ToString("D3");

                var moi = new QLDuAnPhanMemTinHoc.Data.DuAn()
                {
                    MaDuAn = maMoi,
                    TenDuAn = txtTenDA.Text,
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayKetThuc = dtpNgayKetThuc.Value,
                    TrangThai = cboTrangThai.Text,
                    KhachHangID = (int)cboKhachHang.SelectedValue,
                    QuanLyID = (int)cboNguoiQuanLy.SelectedValue,
                    DoUuTien = cboUuTien.Text,
                    ChiPhi = chiPhiMoi
                };

                _context.DuAn.Add(moi);
                _context.SaveChanges();

                LoadDataGrid();
                idDuAnDangChon = moi.ID;
                MessageBox.Show("Thêm dự án thành công! Mã dự án mới: " + maMoi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        private void cboNguoiQuanLy_SelectedIndexChanged(object sender, EventArgs e) { }

        private void dgvDuAn_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvDuAn_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaDA.Text))
                {
                    MessageBox.Show("Vui lòng chọn dự án cần xóa từ danh sách!", "Thông báo");
                    return;
                }

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa dự án này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (idDuAnDangChon == -1)
                    {
                        MessageBox.Show("Vui lòng chọn dự án cần xóa!", "Thông báo");
                        return;
                    }
                    var da = _context.DuAn.Find(idDuAnDangChon);

                    if (da != null)
                    {
                        _context.DuAn.Remove(da);
                        _context.SaveChanges();

                        LoadDataGrid();
                        ClearForm();
                        MessageBox.Show("Đã xóa dự án thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa dự án này! Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát form Quản lý Dự án không?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvDuAn.Rows.Count > 0)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                sfd.Title = "Chọn nơi lưu file Dự án";
                sfd.FileName = "DanhSachDuAn_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("DanhSachDuAn");

                            // In Headers
                            for (int i = 0; i < dgvDuAn.Columns.Count; i++)
                            {
                                ws.Cells[1, i + 1].Value = dgvDuAn.Columns[i].HeaderText;
                                ws.Cells[1, i + 1].Style.Font.Bold = true;
                            }

                            // In Data
                            for (int i = 0; i < dgvDuAn.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvDuAn.Columns.Count; j++)
                                {
                                    ws.Cells[i + 2, j + 1].Value = dgvDuAn.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            ws.Cells.AutoFitColumns();
                            File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}