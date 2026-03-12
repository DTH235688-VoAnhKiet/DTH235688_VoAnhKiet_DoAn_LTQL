using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class DuAn
    {
        public int ID { get; set; }
        public string TenDuAn { get; set; }
        public string? MoTa { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string? TrangThai { get; set; }

        public int KhachHangID { get; set; }
        public int QuanLyID { get; set; }

        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien QuanLy { get; set; } = null!;
        public virtual ObservableCollectionListSource<PhanCong> PhanCong { get; } = new();
        public virtual ObservableCollectionListSource<CongViec> CongViec { get; } = new();
        public virtual ObservableCollectionListSource<Bug> Bug { get; } = new();
        public virtual ObservableCollectionListSource<TaiLieuDuAn> TaiLieuDuAn { get; } = new();
        public virtual ICollection<PhanCong> PhanCongs { get; set; }
    }
}
