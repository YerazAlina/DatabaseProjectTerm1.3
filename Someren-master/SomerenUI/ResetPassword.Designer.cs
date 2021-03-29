
namespace SomerenUI
{
    partial class ResetPassword
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
            this.lblUsernameResetPswd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsernameResetPswd
            // 
            this.lblUsernameResetPswd.AutoSize = true;
            this.lblUsernameResetPswd.Location = new System.Drawing.Point(95, 118);
            this.lblUsernameResetPswd.Name = "lblUsernameResetPswd";
            this.lblUsernameResetPswd.Size = new System.Drawing.Size(132, 25);
            this.lblUsernameResetPswd.TabIndex = 0;
            this.lblUsernameResetPswd.Text = "E-mail adres";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 31);
            this.textBox1.TabIndex = 1;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUsernameResetPswd);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsernameResetPswd;
        private System.Windows.Forms.TextBox textBox1;
    }
}