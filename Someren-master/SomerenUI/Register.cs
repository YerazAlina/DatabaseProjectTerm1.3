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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void bttnCreateNewAccount_Click(object sender, EventArgs e)
        {
            string Key1 = "XsZAb - tgz3PsD - qYh69un - WQCEx";
            string Key2 = "XsZAb-tgz3PsD-qYh69un-WQCEx";
           
            User newUser = new User();

            newUser.Username = txtBoxEmailReg.Text;
            newUser.Password = txtBoxPasswordReg.Text;
            newUser.SecretQuestion = comboBoxQuestions.SelectedItem.ToString();
            newUser.SecretAnswer = txtBoxSecretQuestionAnwser.Text;

            if (txtBoxKey.Text == Key1 || txtBoxKey.Text == Key2)
            {
                RegisterService registerService = new RegisterService();

                registerService.AddUsertodb(newUser);
                MessageBox.Show("You are registerd!");

                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Invalid licenseKey! Please enter again");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            comboBoxQuestions.Items.Add("What is your oldest sibling's middle name?");
            comboBoxQuestions.Items.Add("What was the name of your first stuffed animal?");
            comboBoxQuestions.Items.Add("What are the last 4 numbers of your phone number?");
            comboBoxQuestions.Items.Add("What primary school did you attend?");
            comboBoxQuestions.Items.Add("In what town or city did your parents meet?");
            comboBoxQuestions.Items.Add("What was your childhood nickname?");
        }
    }
}
