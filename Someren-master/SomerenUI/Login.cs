using SomerenLogic;
using SomerenModel;
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

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
            Hash hash = new Hash();

            User user = new User();
            UserService userService = new UserService();

            string username = txtBoxUsername.Text;

            string password = txtBoxPassword.Text;
            user.Password = hash.EncryptPassword(password);

            user = userService.GetUser(username, user.Password);

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
