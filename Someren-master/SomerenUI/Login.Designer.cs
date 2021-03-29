
namespace SomerenUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.bttnRegisterNow = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWelcomeSomeren = new System.Windows.Forms.Label();
            this.lblForgotPasswordLogin = new System.Windows.Forms.Label();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(274, 157);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(215, 31);
            this.txtBoxUsername.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(274, 216);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(215, 31);
            this.txtBoxPassword.TabIndex = 1;
            // 
            // bttnRegisterNow
            // 
            this.bttnRegisterNow.Location = new System.Drawing.Point(90, 289);
            this.bttnRegisterNow.Name = "bttnRegisterNow";
            this.bttnRegisterNow.Size = new System.Drawing.Size(160, 62);
            this.bttnRegisterNow.TabIndex = 3;
            this.bttnRegisterNow.Text = "Register Now";
            this.bttnRegisterNow.UseVisualStyleBackColor = true;
            this.bttnRegisterNow.Click += new System.EventHandler(this.bttnRegisterNow_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(85, 163);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(85, 222);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblWelcomeSomeren
            // 
            this.lblWelcomeSomeren.AutoSize = true;
            this.lblWelcomeSomeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeSomeren.Location = new System.Drawing.Point(34, 52);
            this.lblWelcomeSomeren.Name = "lblWelcomeSomeren";
            this.lblWelcomeSomeren.Size = new System.Drawing.Size(448, 51);
            this.lblWelcomeSomeren.TabIndex = 7;
            this.lblWelcomeSomeren.Text = "Welcome to Someren!";
            // 
            // lblForgotPasswordLogin
            // 
            this.lblForgotPasswordLogin.AutoSize = true;
            this.lblForgotPasswordLogin.Location = new System.Drawing.Point(204, 387);
            this.lblForgotPasswordLogin.Name = "lblForgotPasswordLogin";
            this.lblForgotPasswordLogin.Size = new System.Drawing.Size(174, 25);
            this.lblForgotPasswordLogin.TabIndex = 8;
            this.lblForgotPasswordLogin.Text = "Forgot Password";
            this.lblForgotPasswordLogin.Click += new System.EventHandler(this.lblForgotPasswordLogin_Click);
            // 
            // bttnLogin
            // 
            this.bttnLogin.Location = new System.Drawing.Point(329, 289);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(160, 62);
            this.bttnLogin.TabIndex = 9;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 481);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.lblForgotPasswordLogin);
            this.Controls.Add(this.lblWelcomeSomeren);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.bttnRegisterNow);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button bttnRegisterNow;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblWelcomeSomeren;
        private System.Windows.Forms.Label lblForgotPasswordLogin;
        private System.Windows.Forms.Button bttnLogin;
    }
}