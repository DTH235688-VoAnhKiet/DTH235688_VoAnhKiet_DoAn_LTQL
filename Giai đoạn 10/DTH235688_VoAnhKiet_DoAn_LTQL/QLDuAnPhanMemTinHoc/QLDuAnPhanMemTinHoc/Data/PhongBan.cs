using System;
using System.Collections.Generic;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class PhongBan
    {
        public int ID { get; set; }
        public string TenPhongBan { get; set; }
        public string? MoTa { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
    }
}
