using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class CongViec
    {
        public int ID { get; set; }
        public string TenCongViec { get; set; }
        public string? MoTa { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? HanHoanThanh { get; set; }
        public string? TrangThai { get; set; }
        public string? DoUuTien { get; set; }

        public int DuAnID { get; set; }

        public virtual DuAn DuAn { get; set; } = null!;
        public virtual ObservableCollectionListSource<PhanCongCongViec> PhanCongCongViec { get; } = new();
        public virtual ObservableCollectionListSource<TienDo> TienDo { get; } = new();
    }
}
