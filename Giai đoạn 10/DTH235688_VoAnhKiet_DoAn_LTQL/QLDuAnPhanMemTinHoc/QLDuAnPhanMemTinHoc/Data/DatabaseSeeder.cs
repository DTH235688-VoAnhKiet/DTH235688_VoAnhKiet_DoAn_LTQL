using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QLDuAnPhanMemTinHoc.Data;

namespace QLDuAnPhanMemTinHoc.Data
{
    public static class DatabaseSeeder
    {
        public static void ResetDatabase()
        {
            using (var context = new QLDADbContext())
            {
                Console.WriteLine("Đang dọn dẹp Database để làm mới...");
                try
                {
                    // Xóa dữ liệu cũ theo thứ tự để không vi phạm khóa ngoại
                    context.Database.ExecuteSqlRaw("DELETE FROM TienDo");
                    context.Database.ExecuteSqlRaw("DELETE FROM Bug");
                    context.Database.ExecuteSqlRaw("DELETE FROM PhanCongCongViec");
                    context.Database.ExecuteSqlRaw("DELETE FROM PhanCong");
                    context.Database.ExecuteSqlRaw("DELETE FROM CongViec");
                    context.Database.ExecuteSqlRaw("DELETE FROM DuAn");
                    context.Database.ExecuteSqlRaw("DELETE FROM NhanVien");
                    context.Database.ExecuteSqlRaw("DELETE FROM KhachHang");
                    context.Database.ExecuteSqlRaw("DELETE FROM PhongBan");
                    context.Database.ExecuteSqlRaw("DELETE FROM ChucVu");

                    // Reset IDENTITY về 0 để dữ liệu mới bắt đầu từ 1
                    string[] tables = { "TienDo", "Bug", "PhanCongCongViec", "PhanCong", "CongViec", "DuAn", "NhanVien", "KhachHang", "PhongBan", "ChucVu" };
                    foreach (var table in tables)
                    {
                        try { context.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('{table}', RESEED, 0)"); } catch { }
                    }
                    Console.WriteLine("Dọn dẹp xong!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi dọn dẹp: " + ex.Message);
                }
            }
        }

        public static void Seed()
        {
            using (var context = new QLDADbContext())
            {
                // Kiểm tra nếu đã có dữ liệu chuẩn (NV001) thì thôi
                if (context.NhanVien.Any(nv => nv.MaNhanVien == "NV001" && nv.TenDangNhap == "admin"))
                {
                    return;
                }

                Console.WriteLine("Đang bơm SIÊU DỮ LIỆU MẪU (20+ NV, 10+ Dự án, 30+ Task, 20+ Bug)...");

                // 1. Tạo Phòng Ban
                var phongBans = new List<PhongBan>
                {
                    new PhongBan { TenPhongBan = "Phòng Kỹ Thuật", MoTa = "Phát triển phần mềm & Bảo trì" },
                    new PhongBan { TenPhongBan = "Phòng Nhân Sự", MoTa = "Tuyển dụng, Đào tạo & Văn hóa" },
                    new PhongBan { TenPhongBan = "Phòng Kinh Doanh", MoTa = "Kinh doanh & Marketing" },
                    new PhongBan { TenPhongBan = "Phòng QA/QC", MoTa = "Đảm bảo chất lượng & Kiểm thử" },
                    new PhongBan { TenPhongBan = "Ban Giám Đốc", MoTa = "Lãnh đạo và Điều hành" }
                };
                context.PhongBan.AddRange(phongBans);
                context.SaveChanges();

                // 2. Tạo Chức Vụ
                var chucVus = new List<ChucVu>
                {
                    new ChucVu { TenChucVu = "Giám đốc", MoTa = "Lãnh đạo cao nhất" },
                    new ChucVu { TenChucVu = "Trưởng phòng", MoTa = "Quản lý phòng ban" },
                    new ChucVu { TenChucVu = "Technical Lead", MoTa = "Dẫn dắt kỹ thuật" },
                    new ChucVu { TenChucVu = "Lập trình viên Senior", MoTa = "Code chức năng khó" },
                    new ChucVu { TenChucVu = "Lập trình viên Junior", MoTa = "Code chức năng cơ bản" },
                    new ChucVu { TenChucVu = "Kiểm thử viên (Tester)", MoTa = "Tìm lỗi sản phẩm" },
                    new ChucVu { TenChucVu = "Thực tập viên", MoTa = "Hỗ trợ và học tập" }
                };
                context.ChucVu.AddRange(chucVus);
                context.SaveChanges();

                // 3. Tạo Khách hàng
                var khachHangs = new List<KhachHang>
                {
                    new KhachHang { MaKhachHang = "KH001", TenKhachHang = "Tập đoàn Vingroup", DienThoai = "02439749999", Email = "info@vingroup.net", DiaChi = "Hà Nội" },
                    new KhachHang { MaKhachHang = "KH002", TenKhachHang = "Ngân hàng Vietcombank", DienThoai = "1900545413", Email = "contact@vietcombank.com.vn", DiaChi = "TP. HCM" },
                    new KhachHang { MaKhachHang = "KH003", TenKhachHang = "Công ty CP FPT", DienThoai = "02473007300", Email = "fpt_care@fpt.com.vn", DiaChi = "Hà Nội" },
                    new KhachHang { MaKhachHang = "KH004", TenKhachHang = "Tập đoàn Viettel", DienThoai = "18008098", Email = "support@viettel.vn", DiaChi = "Hà Nội" },
                    new KhachHang { MaKhachHang = "KH005", TenKhachHang = "Shopee Vietnam", DienThoai = "19001221", Email = "hr@shopee.vn", DiaChi = "TP. HCM" }
                };
                context.KhachHang.AddRange(khachHangs);
                context.SaveChanges();

                // 4. Tạo Nhân viên (20+ người)
                var nvs = new List<NhanVien>();
                string[] hoDem = { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Phan", "Vũ", "Đặng", "Bùi", "Đỗ" };
                string[] ten = { "Anh", "Bình", "Cường", "Dũng", "Em", "Hùng", "Hải", "Linh", "Minh", "Nam", "Sơn", "Tùng", "Vinh", "Xuân", "Yến" };
                Random r = new Random();

                // Cố định admin đầu tiên
                var admin = new NhanVien { MaNhanVien = "NV001", HoVaTen = "Nguyễn Văn Admin", TenDangNhap = "admin", MatKhau = "123", QuyenHan = true, ChucVu = "Giám đốc", ChucVuID = chucVus[0].ID, PhongBan = "Ban Giám Đốc", PhongBanID = phongBans[4].ID, TrangThai = "Đang làm việc" };
                nvs.Add(admin);

                for (int i = 2; i <= 25; i++)
                {
                    string hoTen = hoDem[r.Next(hoDem.Length)] + " " + hoDem[r.Next(hoDem.Length)] + " " + ten[r.Next(ten.Length)];
                    int pbIdx = r.Next(phongBans.Count);
                    int cvIdx = r.Next(chucVus.Count);
                    string gioiTinh = r.Next(2) == 0 ? "Nam" : "Nữ";
                    nvs.Add(new NhanVien 
                    { 
                        MaNhanVien = "NV" + i.ToString("D3"), 
                        HoVaTen = hoTen, 
                        TenDangNhap = "user" + i, 
                        MatKhau = "123", 
                        QuyenHan = (i <= 5), // 5 người đầu làm quản lý
                        ChucVu = chucVus[cvIdx].TenChucVu, 
                        ChucVuID = chucVus[cvIdx].ID, 
                        PhongBan = phongBans[pbIdx].TenPhongBan, 
                        PhongBanID = phongBans[pbIdx].ID, 
                        TrangThai = "Đang làm việc",
                        DienThoai = "09" + r.Next(10000000, 99999999).ToString(),
                        Email = "user" + i + "@company.com",
                        GioiTinh = gioiTinh,
                        NgaySinh = DateTime.Now.AddYears(-r.Next(22, 45)).AddDays(r.Next(365)),
                        GhiChu = i % 5 == 0 ? "Nhân viên xuất sắc tháng" : "Kỹ năng chuyên môn tốt"
                    });
                }
                context.NhanVien.AddRange(nvs);
                context.SaveChanges();

                // 5. Tạo Dự án (10+ cái, có trễ hạn)
                var daList = new List<DuAn>();
                string[] names = { "E-Commerce Web", "AI Chatbot", "Hệ thống ERP", "App Giao đồ ăn", "Blockchain Wallet", "Quản lý Bệnh viện", "Smart Home App", "Cổng thông tin SV", "Data Analytics Platform", "Game Mobile 2D" };
                for (int i = 0; i < names.Length; i++)
                {
                    string trangThai = "Đang triển khai";
                    DateTime ngayBD = DateTime.Now.AddDays(-r.Next(60, 120));
                    DateTime ngayKT = DateTime.Now.AddDays(r.Next(30, 90));
                    
                    // Cố tình tạo 3 dự án trễ hạn (Ngày kết thúc đã qua nhưng vẫn đang triển khai)
                    if (i < 3) 
                    {
                        ngayKT = DateTime.Now.AddDays(-r.Next(5, 20)); 
                        trangThai = "Đang triển khai";
                    }
                    else if (i % 3 == 0)
                    {
                        trangThai = "Hoàn thành";
                        ngayKT = DateTime.Now.AddDays(-r.Next(1, 10));
                    }

                    daList.Add(new DuAn 
                    { 
                        MaDuAn = "DA" + (i+1).ToString("D3"), 
                        TenDuAn = names[i], 
                        KhachHangID = khachHangs[r.Next(khachHangs.Count)].ID, 
                        QuanLyID = nvs[r.Next(1, 5)].ID, 
                        NgayBatDau = ngayBD, 
                        NgayKetThuc = ngayKT, 
                        TrangThai = trangThai, 
                        DoUuTien = i % 2 == 0 ? "Cao" : "Trung bình", 
                        ChiPhi = r.Next(50, 900) * 1000000 
                    });
                }
                context.DuAn.AddRange(daList);
                context.SaveChanges();

                // 6. Tạo Công việc & Phân công (Rất nhiều)
                var cvList = new List<CongViec>();
                string[] taskNames = { "Phân tích yêu cầu", "Thiết kế Database", "Code Backend API", "Thiết kế UI/UX", "Code Frontend", "Viết Unit Test", "Deploy Server", "Viết tài liệu HDSD", "Fix Bug tồn đọng", "Họp khách hàng" };
                foreach (var da in daList)
                {
                    int tasksPerProject = r.Next(3, 6);
                    for (int j = 0; j < tasksPerProject; j++)
                    {
                        var cv = new CongViec 
                        { 
                            TenCongViec = taskNames[r.Next(taskNames.Length)] + " " + da.MaDuAn, 
                            DuAnID = da.ID, 
                            NgayBatDau = da.NgayBatDau, 
                            HanHoanThanh = da.NgayKetThuc?.AddDays(-10), 
                            TrangThai = da.TrangThai == "Hoàn thành" ? "Hoàn thành" : "Đang thực hiện", 
                            DoUuTien = da.DoUuTien 
                        };
                        cvList.Add(cv);
                        context.CongViec.Add(cv);
                        context.SaveChanges();

                        // Phân công luôn cho 1-2 nhân viên
                        context.PhanCongCongViec.Add(new PhanCongCongViec { CongViecID = cv.ID, NhanVienID = nvs[r.Next(5, nvs.Count)].ID });
                    }
                }
                context.SaveChanges();

                // 7. Tạo Bug (Rất nhiều cho Admin dòm)
                var bugList = new List<Bug>();
                string[] bugNames = { "Lỗi crash khi login", "Nút Lưu không phản hồi", "Sai font chữ ở trang chủ", "Database timeout", "Ảnh nhân viên bị vỡ", "Không xuất được Excel", "Lỗi phân quyền", "Chạy chậm khi load data" };
                for (int i = 0; i < 20; i++)
                {
                    bugList.Add(new Bug 
                    { 
                        TieuDe = bugNames[r.Next(bugNames.Length)], 
                        DuAnID = daList[r.Next(daList.Count)].ID, 
                        NguoiBaoCaoID = nvs[r.Next(nvs.Count)].ID, 
                        NguoiXuLyID = nvs[r.Next(nvs.Count)].ID, 
                        NgayBaoCao = DateTime.Now.AddDays(-r.Next(1, 15)), 
                        MucDo = r.Next(3) == 0 ? "Nghiêm trọng" : "Trung bình", 
                        TrangThai = r.Next(2) == 0 ? "Đang xử lý" : "Mới tạo",
                        MoTa = "Phát hiện lỗi trong quá trình test alpha."
                    });
                }
                context.Bug.AddRange(bugList);
                context.SaveChanges();

                Console.WriteLine("Đã bơm SIÊU DỮ LIỆU MẪU thành công!");
            }
        }

        public static void FixOldData()
        {
            using (var context = new QLDADbContext())
            {
                // Tạo bảng TienDo nếu chưa có để Cập nhật tiến độ không bị lỗi (Invalid object name 'TienDo')
                context.Database.ExecuteSqlRaw(@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TienDo' and xtype='U')
                    BEGIN
                        CREATE TABLE TienDo (
                            ID INT IDENTITY(1,1) PRIMARY KEY,
                            CongViecID INT FOREIGN KEY REFERENCES CongViec(ID) ON DELETE CASCADE,
                            PhanTram INT,
                            NgayCapNhat DATETIME
                        )
                    END
                ");

                // Tạo bảng PhongBan nếu chưa có
                context.Database.ExecuteSqlRaw(@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='PhongBan' and xtype='U')
                    BEGIN
                        CREATE TABLE PhongBan (
                            ID INT IDENTITY(1,1) PRIMARY KEY,
                            TenPhongBan NVARCHAR(100) NOT NULL,
                            MoTa NVARCHAR(MAX)
                        )
                    END
                ");

                // Tạo bảng ChucVu nếu chưa có
                context.Database.ExecuteSqlRaw(@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ChucVu' and xtype='U')
                    BEGIN
                        CREATE TABLE ChucVu (
                            ID INT IDENTITY(1,1) PRIMARY KEY,
                            TenChucVu NVARCHAR(100) NOT NULL,
                            MoTa NVARCHAR(MAX)
                        )
                    END
                ");

                // Thêm cột PhongBanID và ChucVuID vào bảng NhanVien nếu chưa có
                try {
                    context.Database.ExecuteSqlRaw(@"
                        IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.NhanVien') AND name = 'PhongBanID')
                        BEGIN
                            ALTER TABLE dbo.NhanVien ADD PhongBanID INT NULL;
                        END
                    ");
                    context.Database.ExecuteSqlRaw(@"
                        IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.NhanVien') AND name = 'ChucVuID')
                        BEGIN
                            ALTER TABLE dbo.NhanVien ADD ChucVuID INT NULL;
                        END
                    ");
                } catch (Exception ex) {
                    Console.WriteLine("Lỗi khi thêm cột: " + ex.Message);
                }

                // Thay vì chỉ sửa thằng trống, ta đánh số lại TOÀN BỘ cho đẹp!
                
                // 1. Nhân viên - Vừa đánh số lại, vừa ánh xạ sang 10 bảng (PhongBanID, ChucVuID)
                var allNv = context.NhanVien.OrderBy(x => x.ID).ToList();
                var allPb = context.PhongBan.ToList();
                var allCv = context.ChucVu.ToList();
                int nvCounter = 1;

                foreach(var nv in allNv)
                {
                    nv.MaNhanVien = "NV" + nvCounter.ToString("D3");
                    
                    // Ánh xạ Phòng Ban (Nếu cột ID đang trống thì mới điền)
                    if (nv.PhongBanID == null && !string.IsNullOrEmpty(nv.PhongBan))
                    {
                        var pbMatch = allPb.FirstOrDefault(p => nv.PhongBan.Contains(p.TenPhongBan) || p.TenPhongBan.Contains(nv.PhongBan));
                        if (pbMatch != null) nv.PhongBanID = pbMatch.ID;
                    }

                    // Ánh xạ Chức Vụ
                    if (nv.ChucVuID == null && !string.IsNullOrEmpty(nv.ChucVu))
                    {
                        var cvMatch = allCv.FirstOrDefault(c => nv.ChucVu.Contains(c.TenChucVu) || c.TenChucVu.Contains(nv.ChucVu));
                        if (cvMatch != null) nv.ChucVuID = cvMatch.ID;
                    }

                    nvCounter++;
                }

                // 2. Dự án
                var allDa = context.DuAn.OrderBy(x => x.ID).ToList();
                int daCounter = 1;
                decimal[] randomCosts = { 50000000, 120000000, 85000000, 300000000, 450000000, 75000000, 90000000, 200000000, 150000000 };
                Random rng = new Random();
                foreach(var da in allDa)
                {
                    da.MaDuAn = "DA" + daCounter.ToString("D3");
                    // Cập nhật lại số tiền Chi phí mẫu cho trọn vẹn, số tiền chẵn to (50tr - 450tr)
                    if (da.ChiPhi == null || da.ChiPhi < 1000000) 
                    {
                        da.ChiPhi = randomCosts[rng.Next(randomCosts.Length)];
                    }
                    daCounter++;
                }

                // Bổ sung thêm dữ liệu mẫu xịn xò nếu hệ thống đang ít data (<= 2 dự án)
                if (context.DuAn.Count() <= 2)
                {
                    var kh1 = new KhachHang { MaKhachHang = "KH004", TenKhachHang = "Công ty CP Đầu tư ABC", DienThoai = "0988776655", Email = "abc@company.com", DiaChi = "Cần Thơ" };
                    var kh2 = new KhachHang { MaKhachHang = "KH005", TenKhachHang = "Tập đoàn Đại Dương", DienThoai = "0912345678", Email = "contact@daiduong.net", DiaChi = "Hà Nội" };
                    var kh3 = new KhachHang { MaKhachHang = "KH006", TenKhachHang = "Ngân hàng ACB", DienThoai = "0922334455", Email = "support@acb.vn", DiaChi = "TP. HCM" };
                    context.KhachHang.AddRange(kh1, kh2, kh3);
                    context.SaveChanges();

                    var quanLy = context.NhanVien.FirstOrDefault(x => x.QuyenHan == true) ?? context.NhanVien.First();
                    var nhanVien1 = context.NhanVien.FirstOrDefault(x => x.HoVaTen.Contains("Dev")) ?? context.NhanVien.First();
                    var nhanVien2 = context.NhanVien.FirstOrDefault(x => x.HoVaTen.Contains("Coder")) ?? context.NhanVien.First();
                    var nhanVien3 = context.NhanVien.FirstOrDefault(x => x.HoVaTen.Contains("Tester")) ?? context.NhanVien.First();

                    var da3 = new DuAn { MaDuAn = "DA003", TenDuAn = "Tool Auto Post FB", KhachHangID = kh1.ID, QuanLyID = quanLy.ID, NgayBatDau = DateTime.Now.AddDays(-10), NgayKetThuc = DateTime.Now.AddDays(20), TrangThai = "Đang triển khai", DoUuTien = "Cao", ChiPhi = 85000000 };
                    var da4 = new DuAn { MaDuAn = "DA004", TenDuAn = "Thiết kế Web Mỹ Phẩm", KhachHangID = kh2.ID, QuanLyID = quanLy.ID, NgayBatDau = DateTime.Now.AddDays(-5), NgayKetThuc = DateTime.Now.AddDays(30), TrangThai = "Mới tạo", DoUuTien = "Trung bình", ChiPhi = 120000000 };
                    var da5 = new DuAn { MaDuAn = "DA005", TenDuAn = "Thiết lập Cloud Server", KhachHangID = kh1.ID, QuanLyID = quanLy.ID, NgayBatDau = DateTime.Now.AddDays(-2), NgayKetThuc = DateTime.Now.AddDays(15), TrangThai = "Đang triển khai", DoUuTien = "Cao", ChiPhi = 250000000 };
                    var da6 = new DuAn { MaDuAn = "DA006", TenDuAn = "Phần mềm Kế toán Nội bộ", KhachHangID = kh3.ID, QuanLyID = quanLy.ID, NgayBatDau = DateTime.Now.AddMonths(-1), NgayKetThuc = DateTime.Now.AddMonths(3), TrangThai = "Đang triển khai", DoUuTien = "Cao", ChiPhi = 750000000 };
                    var da7 = new DuAn { MaDuAn = "DA007", TenDuAn = "App Giao hàng Nhanh", KhachHangID = kh2.ID, QuanLyID = quanLy.ID, NgayBatDau = DateTime.Now.AddDays(-20), NgayKetThuc = DateTime.Now.AddDays(-2), TrangThai = "Hoàn thành", DoUuTien = "Trung bình", ChiPhi = 95000000 };
                    
                    context.DuAn.AddRange(da3, da4, da5, da6, da7);
                    context.SaveChanges();

                    var cv1 = new CongViec { TenCongViec = "Khảo sát và lấy yêu cầu", DuAnID = da3.ID, NgayBatDau = DateTime.Now.AddDays(-10), HanHoanThanh = DateTime.Now.AddDays(-5), TrangThai = "Hoàn thành", DoUuTien = "Cao" };
                    var cv2 = new CongViec { TenCongViec = "Code chức năng Đăng nhập/Quyền", DuAnID = da3.ID, NgayBatDau = DateTime.Now.AddDays(-4), HanHoanThanh = DateTime.Now.AddDays(1), TrangThai = "Đang thực hiện", DoUuTien = "Cao" };
                    var cv3 = new CongViec { TenCongViec = "Thực hiện Mockup UI", DuAnID = da4.ID, NgayBatDau = DateTime.Now.AddDays(-2), HanHoanThanh = DateTime.Now.AddDays(6), TrangThai = "Mới tạo", DoUuTien = "Trung bình" };
                    var cv4 = new CongViec { TenCongViec = "Cấu hình Docker, k8s", DuAnID = da5.ID, NgayBatDau = DateTime.Now.AddDays(-1), HanHoanThanh = DateTime.Now.AddDays(2), TrangThai = "Đang thực hiện", DoUuTien = "Cao" };
                    var cv5 = new CongViec { TenCongViec = "Test tính năng giỏ hàng", DuAnID = da4.ID, NgayBatDau = DateTime.Now.AddDays(4), HanHoanThanh = DateTime.Now.AddDays(6), TrangThai = "Mới tạo", DoUuTien = "Cao" };
                    var cv6 = new CongViec { TenCongViec = "Code luồng tính lương", DuAnID = da6.ID, NgayBatDau = DateTime.Now.AddDays(-5), HanHoanThanh = DateTime.Now.AddDays(-1), TrangThai = "Hoàn thành", DoUuTien = "Cao" };

                    context.CongViec.AddRange(cv1, cv2, cv3, cv4, cv5, cv6);
                    context.SaveChanges();

                    context.PhanCong.Add(new PhanCong { DuAnID = da3.ID, NhanVienID = nhanVien1.ID, VaiTroTrongDuAn = "Developer Chính" });
                    context.PhanCong.Add(new PhanCong { DuAnID = da4.ID, NhanVienID = nhanVien2.ID, VaiTroTrongDuAn = "Frontend Lead" });
                    context.PhanCong.Add(new PhanCong { DuAnID = da5.ID, NhanVienID = nhanVien1.ID, VaiTroTrongDuAn = "DevOps" });
                    context.PhanCong.Add(new PhanCong { DuAnID = da6.ID, NhanVienID = nhanVien2.ID, VaiTroTrongDuAn = "Backend C#" });

                    context.PhanCongCongViec.Add(new PhanCongCongViec { CongViecID = cv2.ID, NhanVienID = nhanVien1.ID });
                    context.PhanCongCongViec.Add(new PhanCongCongViec { CongViecID = cv3.ID, NhanVienID = nhanVien2.ID });
                    context.PhanCongCongViec.Add(new PhanCongCongViec { CongViecID = cv4.ID, NhanVienID = nhanVien1.ID });
                    context.PhanCongCongViec.Add(new PhanCongCongViec { CongViecID = cv5.ID, NhanVienID = nhanVien3.ID });
                    context.PhanCongCongViec.Add(new PhanCongCongViec { CongViecID = cv6.ID, NhanVienID = nhanVien2.ID });
                    
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}
