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

        private void lblForgotPasswordLogin_Click(object sender, EventArgs e) //forgot password
        {
            string username = txtBoxUsername.Text;

            User user = new User();
            UserService userService = new UserService();
            user = userService.GetUserByUsername(username);

            if (user == null) 
            {
                MessageBox.Show("User does not exist!");
            }
            else
            {
                ForgotPassword forgotPassword = new ForgotPassword(user);
                this.Hide();
                forgotPassword.Show();
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e) //new user
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.Show();
        }

        private void bttnLogin_Click(object sender, EventArgs e) //loging in with existing user
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
    }
}
