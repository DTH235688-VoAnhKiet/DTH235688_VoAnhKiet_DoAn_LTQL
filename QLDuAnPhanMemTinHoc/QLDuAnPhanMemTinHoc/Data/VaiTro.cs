using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class VaiTro
    {
        public int ID { get; set; }
        public string TenVaiTro { get; set; }

        public virtual ObservableCollectionListSource<NhanVien_VaiTro> NhanVien_VaiTro { get; } = new();
    }
}
