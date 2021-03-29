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
    public partial class ResetPassword : Form
    {
        private User user;

        public ResetPassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void bttnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == txtBoxPasswordConfirm.Text)
            {
                user.Password = txtBoxPassword.Text;
                UserService userService = new UserService();
                userService.UpdateUserPassword(user.Password, user.Username);
               
                MessageBox.Show("Password is Changed!");

                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Passwords should be the same!");
            }
        }
    }
}
