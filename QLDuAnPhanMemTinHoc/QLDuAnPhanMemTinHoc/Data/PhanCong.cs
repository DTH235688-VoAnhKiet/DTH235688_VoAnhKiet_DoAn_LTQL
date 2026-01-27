using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class PhanCong
    {
        public int ID { get; set; }
        public int DuAnID { get; set; }
        public int NhanVienID { get; set; }
        public string? VaiTroTrongDuAn { get; set; }

        public virtual DuAn DuAn { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
