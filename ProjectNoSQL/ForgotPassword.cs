using Logic;
using LoginRegister;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNoSQL
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            Register register = new Register();

            User user = userService.ReadUser(tb_EnterEmail.Text);
            if(user == null)
            {
                lbl_NotFound.Show();
            }
            else
            {
                register.SendMail(user.email, user.password, user.firstName);
                this.Close();
            }
        }
    }
}
