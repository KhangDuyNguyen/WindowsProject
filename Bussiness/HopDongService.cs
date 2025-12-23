using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class HopDongService
    {
        public void ThanhLyHopDong(int maHD, int maPhong)
        {
            // 1. Cập nhật Hợp đồng thành Closed
            string sqlHD = "UPDATE HopDong SET TrangThaiHD = 'Closed' WHERE MaHD = " + maHD;
            DatabaseHelper.ExecuteNonQuery(sqlHD);

            // 2. Cập nhật Phòng thành Trống (0) - Yêu cầu logic C#
            string sqlPhong = "UPDATE PhongTro SET TrangThai = 0 WHERE MaPhong = " + maPhong;
            DatabaseHelper.ExecuteNonQuery(sqlPhong);
        }

        public decimal TinhTongTien(decimal giaGoc, int thoiHan, int phanTramGiam)
        {
            // Logic tính tiền
            return (giaGoc * thoiHan) * (1 - (decimal)phanTramGiam / 100);
        }
    }
}
