using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            Hash hash = new Hash();

            if (txtBoxPassword.Text == txtBoxPasswordConfirm.Text)
            {
                string password = txtBoxPassword.Text;

                user.Password = hash.EncryptPassword(password);
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
