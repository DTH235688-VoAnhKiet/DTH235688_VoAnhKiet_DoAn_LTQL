using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class PhanCongCongViec
    {
        public int ID { get; set; }
        public int CongViecID { get; set; }
        public int NhanVienID { get; set; }

        public virtual CongViec CongViec { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
