using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class NhanVien_VaiTro
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int VaiTroID { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual VaiTro VaiTro { get; set; } = null!;
    }
}
