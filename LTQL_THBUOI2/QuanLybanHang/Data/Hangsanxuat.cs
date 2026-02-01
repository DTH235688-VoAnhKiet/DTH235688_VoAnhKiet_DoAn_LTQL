using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLybanHang.Data
{
    public class Hangsanxuat
    {
        public int ID { get; set; }

        [Column("TenHangSanXuat")]
        public string TenHangSanXuat { get; set; }

        [Column("TenHangSanXuatKhac")]
        public string Tenhangsanxuat { get; set; }

    }
}
