using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string? MaNhanVien { get; set; }
        public string HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        
        // Chèn khóa ngoại vào đây cho chuyên nghiệp nha ný
        public int? ChucVuID { get; set; }
        public virtual ChucVu? ChucVuEntity { get; set; }

        public string? ChucVu { get; set; } // Giữ lại string cũ để không lỗi code hiển thị cũ
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool QuyenHan { get; set; }

        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }

        public int? PhongBanID { get; set; }
        public virtual PhongBan? PhongBanEntity { get; set; }

        public string? PhongBan { get; set; }
        public string? TrangThai { get; set; }
        public string? GhiChu { get; set; }

        public virtual ObservableCollectionListSource<DuAn> DuAnQuanLy { get; } = new();
        public virtual ObservableCollectionListSource<PhanCong> PhanCong { get; } = new();
        public virtual ObservableCollectionListSource<PhanCongCongViec> PhanCongCongViec { get; } = new();

        public virtual ObservableCollectionListSource<Bug> BugBaoCao { get; } = new();
        public virtual ObservableCollectionListSource<Bug> BugXuLy { get; } = new();

        public virtual ICollection<PhanCong> PhanCongs { get; set; }

    }

}
