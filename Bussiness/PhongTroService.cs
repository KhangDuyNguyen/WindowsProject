using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class PhongTroService
    {
        // 1. Lấy danh sách phòng
        public DataTable GetAllPhong()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM PhongTro");
        }

        // 2. Thêm phòng mới
        public bool InsertPhong(PhongTro p)
        {
            string query = "INSERT INTO PhongTro (TenPhong, DienTich, GiaPhong, TrangThai, MoTa) VALUES (@Ten, @DT, @Gia, @TT, @MoTa)";
            SqlParameter[] param = {
            new SqlParameter("@Ten", p.TenPhong),
            new SqlParameter("@DT", p.DienTich),
            new SqlParameter("@Gia", p.GiaPhong),
            new SqlParameter("@TT", p.TrangThai),
            new SqlParameter("@MoTa", p.MoTa ?? (object)DBNull.Value) // Xử lý null
        };
            return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
        }

        // 3. Sửa phòng
        public bool UpdatePhong(PhongTro p)
        {
            string query = "UPDATE PhongTro SET TenPhong=@Ten, DienTich=@DT, GiaPhong=@Gia, TrangThai=@TT, MoTa=@MoTa WHERE MaPhong=@Ma";
            SqlParameter[] param = {
            new SqlParameter("@Ma", p.MaPhong),
            new SqlParameter("@Ten", p.TenPhong),
            new SqlParameter("@DT", p.DienTich),
            new SqlParameter("@Gia", p.GiaPhong),
            new SqlParameter("@TT", p.TrangThai),
            new SqlParameter("@MoTa", p.MoTa ?? (object)DBNull.Value)
        };
            return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
        }

        // 4. Xóa phòng
        public bool DeletePhong(int maPhong)
        {
            // Lưu ý: Nếu phòng đang có Hợp đồng (Khoá ngoại) thì phải xử lý try-catch bên Form
            string query = "DELETE FROM PhongTro WHERE MaPhong = @Ma";
            SqlParameter[] param = { new SqlParameter("@Ma", maPhong) };
            return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
        }
    }
}
