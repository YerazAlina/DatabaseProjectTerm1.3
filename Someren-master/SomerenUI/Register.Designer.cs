
namespace SomerenUI
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblRegistertxt = new System.Windows.Forms.Label();
            this.lblUsernameRegister = new System.Windows.Forms.Label();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.lblLiceneKey = new System.Windows.Forms.Label();
            this.lblSecretQuestionRegister = new System.Windows.Forms.Label();
            this.txtBoxEmailReg = new System.Windows.Forms.TextBox();
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.txtBoxSecretQuestionAnwser = new System.Windows.Forms.TextBox();
            this.txtBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.comboBoxQuestions = new System.Windows.Forms.ComboBox();
            this.bttnCreateNewAccount = new System.Windows.Forms.Button();
            this.lblSecretAnwserReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistertxt
            // 
            this.lblRegistertxt.AutoSize = true;
            this.lblRegistertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistertxt.Location = new System.Drawing.Point(32, 55);
            this.lblRegistertxt.Name = "lblRegistertxt";
            this.lblRegistertxt.Size = new System.Drawing.Size(300, 33);
            this.lblRegistertxt.TabIndex = 0;
            this.lblRegistertxt.Text = "Create a new Account";
            // 
            // lblUsernameRegister
            // 
            this.lblUsernameRegister.AutoSize = true;
            this.lblUsernameRegister.Location = new System.Drawing.Point(70, 126);
            this.lblUsernameRegister.Name = "lblUsernameRegister";
            this.lblUsernameRegister.Size = new System.Drawing.Size(110, 25);
            this.lblUsernameRegister.TabIndex = 1;
            this.lblUsernameRegister.Text = "Username";
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Location = new System.Drawing.Point(70, 183);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(106, 25);
            this.lblPasswordRegister.TabIndex = 2;
            this.lblPasswordRegister.Text = "Password";
            // 
            // lblLiceneKey
            // 
            this.lblLiceneKey.AutoSize = true;
            this.lblLiceneKey.Location = new System.Drawing.Point(72, 239);
            this.lblLiceneKey.Name = "lblLiceneKey";
            this.lblLiceneKey.Size = new System.Drawing.Size(130, 25);
            this.lblLiceneKey.TabIndex = 3;
            this.lblLiceneKey.Text = "License Key";
            // 
            // lblSecretQuestionRegister
            // 
            this.lblSecretQuestionRegister.AutoSize = true;
            this.lblSecretQuestionRegister.Location = new System.Drawing.Point(70, 300);
            this.lblSecretQuestionRegister.Name = "lblSecretQuestionRegister";
            this.lblSecretQuestionRegister.Size = new System.Drawing.Size(262, 25);
            this.lblSecretQuestionRegister.TabIndex = 4;
            this.lblSecretQuestionRegister.Text = "Select a Seceret Question";
            // 
            // txtBoxEmailReg
            // 
            this.txtBoxEmailReg.Location = new System.Drawing.Point(359, 120);
            this.txtBoxEmailReg.Name = "txtBoxEmailReg";
            this.txtBoxEmailReg.Size = new System.Drawing.Size(246, 31);
            this.txtBoxEmailReg.TabIndex = 5;
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Location = new System.Drawing.Point(359, 239);
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(246, 31);
            this.txtBoxKey.TabIndex = 6;
            // 
            // txtBoxSecretQuestionAnwser
            // 
            this.txtBoxSecretQuestionAnwser.Location = new System.Drawing.Point(359, 356);
            this.txtBoxSecretQuestionAnwser.Name = "txtBoxSecretQuestionAnwser";
            this.txtBoxSecretQuestionAnwser.Size = new System.Drawing.Size(246, 31);
            this.txtBoxSecretQuestionAnwser.TabIndex = 7;
            // 
            // txtBoxPasswordReg
            // 
            this.txtBoxPasswordReg.Location = new System.Drawing.Point(359, 180);
            this.txtBoxPasswordReg.Name = "txtBoxPasswordReg";
            this.txtBoxPasswordReg.Size = new System.Drawing.Size(246, 31);
            this.txtBoxPasswordReg.TabIndex = 9;
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Location = new System.Drawing.Point(359, 297);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new System.Drawing.Size(246, 33);
            this.comboBoxQuestions.TabIndex = 10;
            // 
            // bttnCreateNewAccount
            // 
            this.bttnCreateNewAccount.Location = new System.Drawing.Point(359, 419);
            this.bttnCreateNewAccount.Name = "bttnCreateNewAccount";
            this.bttnCreateNewAccount.Size = new System.Drawing.Size(246, 81);
            this.bttnCreateNewAccount.TabIndex = 11;
            this.bttnCreateNewAccount.Text = "Create New Account";
            this.bttnCreateNewAccount.UseVisualStyleBackColor = true;
            this.bttnCreateNewAccount.Click += new System.EventHandler(this.bttnCreateNewAccount_Click);
            // 
            // lblSecretAnwserReg
            // 
            this.lblSecretAnwserReg.AutoSize = true;
            this.lblSecretAnwserReg.Location = new System.Drawing.Point(72, 359);
            this.lblSecretAnwserReg.Name = "lblSecretAnwserReg";
            this.lblSecretAnwserReg.Size = new System.Drawing.Size(151, 25);
            this.lblSecretAnwserReg.TabIndex = 12;
            this.lblSecretAnwserReg.Text = "Secret Anwser";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 543);
            this.Controls.Add(this.lblSecretAnwserReg);
            this.Controls.Add(this.bttnCreateNewAccount);
            this.Controls.Add(this.comboBoxQuestions);
            this.Controls.Add(this.txtBoxPasswordReg);
            this.Controls.Add(this.txtBoxSecretQuestionAnwser);
            this.Controls.Add(this.txtBoxKey);
            this.Controls.Add(this.txtBoxEmailReg);
            this.Controls.Add(this.lblSecretQuestionRegister);
            this.Controls.Add(this.lblLiceneKey);
            this.Controls.Add(this.lblPasswordRegister);
            this.Controls.Add(this.lblUsernameRegister);
            this.Controls.Add(this.lblRegistertxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistertxt;
        private System.Windows.Forms.Label lblUsernameRegister;
        private System.Windows.Forms.Label lblPasswordRegister;
        private System.Windows.Forms.Label lblLiceneKey;
        private System.Windows.Forms.Label lblSecretQuestionRegister;
        private System.Windows.Forms.TextBox txtBoxEmailReg;
        private System.Windows.Forms.TextBox txtBoxKey;
        private System.Windows.Forms.TextBox txtBoxSecretQuestionAnwser;
        private System.Windows.Forms.TextBox txtBoxPasswordReg;
        private System.Windows.Forms.ComboBox comboBoxQuestions;
        private System.Windows.Forms.Button bttnCreateNewAccount;
        private System.Windows.Forms.Label lblSecretAnwserReg;
    }
}