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
        public string HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public string? ChucVu { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool QuyenHan { get; set; }

        public virtual ObservableCollectionListSource<DuAn> DuAnQuanLy { get; } = new();
        public virtual ObservableCollectionListSource<PhanCong> PhanCong { get; } = new();
        public virtual ObservableCollectionListSource<PhanCongCongViec> PhanCongCongViec { get; } = new();

        public virtual ObservableCollectionListSource<Bug> BugBaoCao { get; } = new();
        public virtual ObservableCollectionListSource<Bug> BugXuLy { get; } = new();

        public virtual ObservableCollectionListSource<NhanVien_VaiTro> NhanVien_VaiTro { get; } = new();
        public virtual ObservableCollectionListSource<NhatKyHoatDong> NhatKyHoatDong { get; } = new();
        public virtual ICollection<PhanCong> PhanCongs { get; set; }

    }

}
