using Logic;
using System;
using Model;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoadRememberMe();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            User user = userService.ReadUser(tb_Email.Text);

            if (user == null || (user.email != tb_Email.Text || user.password != tb_Password.Text))
            {
                lbl_Incorrect.Show();
            }
            else
            {
                SaveRememberMe();

                if(user.typeOfUser == TypeOfUser.Employee)
                {
                    this.Hide();
                    EmployeeScreen employeeScreen = new EmployeeScreen(user.email);
                    employeeScreen.FormClosed += (s, args) => this.Close();
                    employeeScreen.Show();
                }
                else
                {
                    this.Hide();
                    ServiceDeskScreen serviceDeskScreen = new ServiceDeskScreen(user.email);
                    serviceDeskScreen.FormClosed += (s, args) => this.Close();
                    serviceDeskScreen.Show();
                }
            }
        }

        private void lbl_Forgot_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }

        private void lbl_Forgot_MouseEnter(object sender, EventArgs e)
        {
            lbl_Forgot.Font = new Font(lbl_Forgot.Font.Name, lbl_Forgot.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lbl_Forgot_MouseLeave(object sender, EventArgs e)
        {
            lbl_Forgot.Font = new Font(lbl_Forgot.Font.Name, lbl_Forgot.Font.SizeInPoints, FontStyle.Regular);
        }

        private void SaveRememberMe()
        {
            if (chb_RememberMe.Checked)
            {
                Properties.Settings.Default.Email = tb_Email.Text;
                Properties.Settings.Default.Password = tb_Password.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
        }

        private void LoadRememberMe()
        {
            if(Properties.Settings.Default.Email != string.Empty)
            {
                tb_Email.Text = Properties.Settings.Default.Email;
                tb_Password.Text = Properties.Settings.Default.Password;
            }
        }
    }
}
