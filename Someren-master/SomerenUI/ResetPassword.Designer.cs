
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.lblEnterNewPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.bttnResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterNewPassword
            // 
            this.lblEnterNewPassword.AutoSize = true;
            this.lblEnterNewPassword.Location = new System.Drawing.Point(99, 137);
            this.lblEnterNewPassword.Name = "lblEnterNewPassword";
            this.lblEnterNewPassword.Size = new System.Drawing.Size(206, 25);
            this.lblEnterNewPassword.TabIndex = 0;
            this.lblEnterNewPassword.Text = "Enter new password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(45, 55);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(368, 37);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "Choose a new password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(348, 131);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(174, 31);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // txtBoxPasswordConfirm
            // 
            this.txtBoxPasswordConfirm.Location = new System.Drawing.Point(348, 184);
            this.txtBoxPasswordConfirm.Name = "txtBoxPasswordConfirm";
            this.txtBoxPasswordConfirm.Size = new System.Drawing.Size(174, 31);
            this.txtBoxPasswordConfirm.TabIndex = 4;
            // 
            // bttnResetPassword
            // 
            this.bttnResetPassword.Location = new System.Drawing.Point(346, 252);
            this.bttnResetPassword.Name = "bttnResetPassword";
            this.bttnResetPassword.Size = new System.Drawing.Size(176, 72);
            this.bttnResetPassword.TabIndex = 5;
            this.bttnResetPassword.Text = "Reset Password";
            this.bttnResetPassword.UseVisualStyleBackColor = true;
            this.bttnResetPassword.Click += new System.EventHandler(this.bttnResetPassword_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 362);
            this.Controls.Add(this.bttnResetPassword);
            this.Controls.Add(this.txtBoxPasswordConfirm);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEnterNewPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxPasswordConfirm;
        private System.Windows.Forms.Button bttnResetPassword;
    }
}