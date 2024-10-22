using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.DAL.Entities;

namespace EFDiyet2.PL
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnSignin = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(37, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(176, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignin
            // 
            btnSignin.Location = new Point(37, 174);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(176, 40);
            btnSignin.TabIndex = 0;
            btnSignin.Text = "Sign-Up";
            btnSignin.UseVisualStyleBackColor = true;
            btnSignin.Click += btnSignin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(53, 21);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(143, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(53, 64);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(143, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 240);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnSignin);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnSignin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        
    }
}