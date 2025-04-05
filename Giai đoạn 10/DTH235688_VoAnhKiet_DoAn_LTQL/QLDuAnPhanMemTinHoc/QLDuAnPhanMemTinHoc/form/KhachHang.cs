using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Thêm thư viện này để dùng Regex validate SĐT, Email
using OfficeOpenXml;
using System.IO;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class KhachHang : Form
    {
        Data.QLDADbContext _context = new Data.QLDADbContext();
        private bool isThem = false;
        public KhachHang()
        {
            InitializeComponent();
            this.Load += KhachHang_Load;
            
            // Gắn sự kiện cho các nút chưa được gắn trong Designer
            btnLuu.Click += btnLuu_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            StylizeForm();
            // Bỏ màu chói khi chọn ô trong bảng
            dgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvKhachHang.DefaultCellStyle.SelectionForeColor = Color.Black;
            LoadData();
            SetStatus(true); // KHÔNG KHÓA - Mở hết
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

        private void SetStatus(bool status)
        {
            // Yêu cầu: bỏ hết mấy kiểu khóa đi -> luôn dùng true
            txtMaKH.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtNguoiDaiDien.Enabled = true;
            
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void LoadData()
        {
            try
            {
                // Lấy danh sách từ bảng KhachHang
                var danhSachKhachHang = _context.KhachHang
                    .Select(kh => new
                    {
                        kh.ID,
                        kh.MaKhachHang,
                        kh.TenKhachHang,
                        kh.DienThoai,
                        kh.Email,
                        kh.DiaChi,
                        kh.NguoiDaiDien
                    }).ToList();

                // Đổ dữ liệu vào DataGridView
                dgvKhachHang.DataSource = danhSachKhachHang;

                // --- BẮT ĐẦU CHỈNH CHO KHÍT FORM ---
                if (dgvKhachHang.Columns["ID"] != null)
                {
                    dgvKhachHang.Columns["ID"].Visible = false;

                    // Cho toàn bộ các cột tự động dãn ra để khít form
                    dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Chỉnh lại Tiêu đề và độ rộng từng cột cho hợp lý
                    dgvKhachHang.Columns["MaKhachHang"].HeaderText = "Mã KH";
                    dgvKhachHang.Columns["MaKhachHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Vừa đủ nội dung

                    dgvKhachHang.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";

                    dgvKhachHang.Columns["DienThoai"].HeaderText = "Điện Thoại";
                    dgvKhachHang.Columns["DienThoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    dgvKhachHang.Columns["Email"].HeaderText = "Email";

                    dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";

                    dgvKhachHang.Columns["NguoiDaiDien"].HeaderText = "Người Đại Diện";
                    dgvKhachHang.Columns["NguoiDaiDien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                // --- KẾT THÚC CHỈNH CHO KHÍT FORM ---
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachHang.CurrentRow != null)
                {
                    DialogResult hoiNhe = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hoiNhe == DialogResult.Yes)
                    {
                        int idCanXoa = (int)dgvKhachHang.CurrentRow.Cells["ID"].Value;
                        var khXoa = _context.KhachHang.Find(idCanXoa);

                        if (khXoa != null)
                        {
                            _context.KhachHang.Remove(khXoa);
                            _context.SaveChanges();

                            LoadData();
                            ClearForm(); // Gọi hàm xóa trắng
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Bấm Hủy thì xóa trắng các ô nhập liệu
            ClearForm();
            SetStatus(true);
        }

        // Tạo một hàm riêng để xóa trắng các textbox cho gọn code
        private void ClearForm()
        {
            txtMaKH.Clear();
            txtTenKhachHang.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtNguoiDaiDien.Clear();
        }

        private bool KiemTraHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên khách hàng và Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string phonePattern = @"^(0[3|5|7|8|9])+([0-9]{8})$";
            if (!Regex.IsMatch(txtSDT.Text, phonePattern))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (Phải là số Việt Nam, gồm 10 số)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra Email (nếu có nhập thì mới kiểm tra)
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Email không đúng định dạng (Ví dụ: ten@gmail.com)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            ClearForm();
            SetStatus(true);
            txtMaKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Gọi hàm Validate trước khi thêm/sửa
                if (!KiemTraHopLe()) return;

                if (isThem)
                {
                    // Tự động sinh mã KH mới
                    int nextID = 1;
                    if (_context.KhachHang.Any())
                    {
                        nextID = _context.KhachHang.Max(x => x.ID) + 1;
                    }
                    string maMoi = "KH" + nextID.ToString("D3");

                    // 2. Tạo một đối tượng Khách hàng mới
                    var khachHangMoi = new Data.KhachHang()
                    {
                        MaKhachHang = maMoi,
                        TenKhachHang = txtTenKhachHang.Text,
                        DienThoai = txtSDT.Text,
                        Email = txtEmail.Text,
                        DiaChi = txtDiaChi.Text,
                        NguoiDaiDien = txtNguoiDaiDien.Text
                    };

                    // 3. Thêm vào Context và lưu
                    _context.KhachHang.Add(khachHangMoi);
                    MessageBox.Show("Thêm khách hàng thành công! Mã mới: " + maMoi);
                }
                else
                {
                    if (dgvKhachHang.CurrentRow != null)
                    {
                        int idCanTim = (int)dgvKhachHang.CurrentRow.Cells["ID"].Value;
                        var khSua = _context.KhachHang.Find(idCanTim);

                        if (khSua != null)
                        {
                            khSua.MaKhachHang = txtMaKH.Text;
                            khSua.TenKhachHang = txtTenKhachHang.Text;
                            khSua.DienThoai = txtSDT.Text;
                            khSua.Email = txtEmail.Text;
                            khSua.DiaChi = txtDiaChi.Text;
                            khSua.NguoiDaiDien = txtNguoiDaiDien.Text;
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                    _context.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearForm();
                SetStatus(true); // Luôn mở
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                isThem = false;
                SetStatus(true);
                txtTenKhachHang.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng dưới bảng để sửa!", "Nhắc nhở");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi form Quản lý khách hàng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["MaKhachHang"].Value?.ToString() ?? "";
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

                // Đã bổ sung đẩy dữ liệu lên ô Địa chỉ và Người đại diện
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                txtNguoiDaiDien.Text = row.Cells["NguoiDaiDien"].Value?.ToString() ?? "";

                SetStatus(true); // Bỏ khóa luôn
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(tuKhoa))
                {
                    LoadData();
                    return;
                }

                var ketQua = _context.KhachHang
                    .Where(kh => kh.TenKhachHang.ToLower().Contains(tuKhoa)
                              || kh.DienThoai.Contains(tuKhoa)
                              || kh.MaKhachHang.ToLower().Contains(tuKhoa))
                    .Select(kh => new
                    {
                        kh.ID,
                        kh.MaKhachHang,
                        kh.TenKhachHang,
                        kh.DienThoai,
                        kh.Email,
                        kh.DiaChi,
                        kh.NguoiDaiDien
                    }).ToList();

                dgvKhachHang.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào khớp với từ khóa!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 0)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                sfd.Title = "Chọn nơi lưu file Khách hàng";
                sfd.FileName = "DanhSachKhachHang_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("DanhSachKhachHang");

                            // In Headers
                            int excelColIndex = 1;
                            for (int i = 0; i < dgvKhachHang.Columns.Count; i++)
                            {
                                if (dgvKhachHang.Columns[i].Visible)
                                {
                                    ws.Cells[1, excelColIndex].Value = dgvKhachHang.Columns[i].HeaderText;
                                    ws.Cells[1, excelColIndex].Style.Font.Bold = true;
                                    excelColIndex++;
                                }
                            }

                            // In Data
                            for (int i = 0; i < dgvKhachHang.Rows.Count; i++)
                            {
                                excelColIndex = 1;
                                for (int j = 0; j < dgvKhachHang.Columns.Count; j++)
                                {
                                    if (dgvKhachHang.Columns[j].Visible)
                                    {
                                        ws.Cells[i + 2, excelColIndex].Value = dgvKhachHang.Rows[i].Cells[j].Value?.ToString() ?? "";
                                        excelColIndex++;
                                    }
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

        // Các Event trống không dùng đến nhưng vẫn giữ lại để WinForms Designer không bị lỗi
        private void txtMaKH_TextChanged(object sender, EventArgs e) { }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtTimKiem_TextChanged(object sender, EventArgs e) { }
    }
}