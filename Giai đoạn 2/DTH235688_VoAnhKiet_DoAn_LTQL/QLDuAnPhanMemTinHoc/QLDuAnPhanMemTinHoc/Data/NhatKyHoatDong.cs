using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class NhatKyHoatDong
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public string? MoTaHoatDong { get; set; }
        public DateTime? ThoiGian { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
