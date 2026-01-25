using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLybanHang.Data
{
    public class Loaisanpham
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }
        public virtual ObservableCollectionListSource<sanpham> sanpham { get;  } = new();
    }
}
