using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class TaiLieuDuAn
    {
        public int ID { get; set; }
        public int DuAnID { get; set; }
        public string TenTaiLieu { get; set; }
        public string? DuongDan { get; set; }
        public DateTime? NgayTaiLen { get; set; }

        public virtual DuAn DuAn { get; set; } = null!;
    }
}
