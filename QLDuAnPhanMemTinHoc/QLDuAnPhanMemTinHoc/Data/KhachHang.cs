using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }

        public virtual ObservableCollectionListSource<DuAn> DuAn { get; } = new();
    }
}
