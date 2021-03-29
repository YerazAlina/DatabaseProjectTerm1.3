using SomerenModel;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class ForgotPassword : Form
    {
        private User user;

        public ForgotPassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            lblSecretQuestion.Text = user.SecretQuestion;
        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == user.SecretAnswer)
            {
                ResetPassword resetPswd = new ResetPassword(user);
                this.Hide();
                resetPswd.Show();
            }
            else
            {
                MessageBox.Show("Inccorect Answer!");
            }
        }
    }
}
