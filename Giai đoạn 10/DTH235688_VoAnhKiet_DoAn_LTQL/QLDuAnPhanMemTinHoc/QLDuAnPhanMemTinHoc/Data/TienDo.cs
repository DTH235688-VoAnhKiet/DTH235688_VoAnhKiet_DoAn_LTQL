using System;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class TienDo
    {
        public int ID { get; set; }
        public int CongViecID { get; set; }
        public int? PhanTram { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        public virtual CongViec CongViec { get; set; } = null!;
    }
}
