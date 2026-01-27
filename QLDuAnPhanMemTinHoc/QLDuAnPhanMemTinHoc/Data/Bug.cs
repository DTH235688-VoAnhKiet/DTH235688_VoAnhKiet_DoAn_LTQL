using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLDuAnPhanMemTinHoc.Data
{

    public class Bug
    {
        public int ID { get; set; }
        public string TieuDe { get; set; } = null!;
        public string? MoTa { get; set; }
        public string? MucDo { get; set; }
        public string? TrangThai { get; set; }
        public DateTime? NgayBaoCao { get; set; }

        public int DuAnID { get; set; }
        public int NguoiBaoCaoID { get; set; }
        public int? NguoiXuLyID { get; set; }

        public virtual DuAn DuAn { get; set; } = null!;

        [ForeignKey("NguoiBaoCaoID")]
        public virtual NhanVien NguoiBaoCao { get; set; } = null!;

        [ForeignKey("NguoiXuLyID")]
        public virtual NhanVien? NguoiXuLy { get; set; }
    }
}
