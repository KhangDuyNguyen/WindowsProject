using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Admin
{
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            int maPhong = (int)cbPhong.SelectedValue;
         

            // 2. Insert vào DB
            string sql = $"INSERT INTO HopDong (MaPhong, ...) VALUES ({maPhong}, ...)";
            DatabaseHelper.ExecuteNonQuery(sql);

           
            MessageBox.Show("Đã tạo hợp đồng thành công!");
          
        }
    }
}
