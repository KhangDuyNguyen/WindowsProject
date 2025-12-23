using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class HopDong
    {
        public int MaHD { get; set; }
        public int MaPhong { get; set; }
        public int MaNguoiThue { get; set; }
        public DateTime NgayBatDau { get; set; }
        public int ThoiHanThang { get; set; }
        public int PhanTramGiam { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThaiHD { get; set; }
    }
}
