using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class lrmLogin : Form
    {
        public lrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            if (service.Login(txtUser.Text, txtPassword.Text))
            {
                // Kiểm tra vai trò ở đây nếu cần, rồi mở form tương ứng
                frmPhongTro main = new frmPhongTro();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}
