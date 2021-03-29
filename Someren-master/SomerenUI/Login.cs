using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void bttnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            User user = new User();
            UserService userService = new UserService();

            user = userService.GetUser(username, password);

            if (user != null)
            {
                SomerenUI form = new SomerenUI(user);
                this.Hide();

                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }

        private void bttnRegisterNow_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.Show();
        }

        private void lblForgotPasswordLogin_Click(object sender, EventArgs e)
        {
            ResetPassword forgetPasswordform = new ResetPassword();
            this.Hide();
            forgetPasswordform.Show();
        }
    }
}
