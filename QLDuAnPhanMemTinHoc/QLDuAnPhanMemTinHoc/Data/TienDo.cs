using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class TienDo
    {
        public int ID { get; set; }
        public int CongViecID { get; set; }
        public int PhanTram { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string? GhiChu { get; set; }

        public virtual CongViec CongViec { get; set; } = null!;
    }
}
