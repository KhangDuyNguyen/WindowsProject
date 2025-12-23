using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Bussiness
{
    public class UserService
{
    
    public string HashPassword(string password)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }

    public bool Login(string username, string password)
    {
        string passHash = HashPassword(password);
        // Gọi Stored Procedure
        string query = "sp_KiemTraDangNhap @TenDN, @MatKhauHash";
        SqlParameter[] p = {
            new SqlParameter("@TenDN", username),
            new SqlParameter("@MatKhauHash", passHash)
        };
        DataTable dt = Data.DatabaseHelper.ExecuteQuery(query, p);
        return dt.Rows.Count > 0;
    }
}
}





