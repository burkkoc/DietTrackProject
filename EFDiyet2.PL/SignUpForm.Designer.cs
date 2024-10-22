namespace EFDiyet2.PL
{
    partial class SignUpForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMail = new TextBox();
            txtPw = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            dtpBirthDate = new DateTimePicker();
            cboxGender = new ComboBox();
            btnSignUp = new Button();
            btnCancel = new Button();
            numWeight = new NumericUpDown();
            numHeight = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 76);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 109);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 143);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Birthdate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 177);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Weight (Kg):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 206);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Height (Cm):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 237);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 15);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 6;
            label7.Text = "E-Mail:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 44);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 7;
            label8.Text = "Password:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(123, 12);
            txtMail.MaxLength = 250;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(120, 23);
            txtMail.TabIndex = 8;
            txtMail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(123, 41);
            txtPw.MaxLength = 250;
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(120, 23);
            txtPw.TabIndex = 9;
            txtPw.TextAlign = HorizontalAlignment.Center;
            txtPw.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 73);
            txtName.MaxLength = 250;
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 10;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(123, 106);
            txtSurname.MaxLength = 250;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(121, 23);
            txtSurname.TabIndex = 11;
            txtSurname.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.ImeMode = ImeMode.NoControl;
            dtpBirthDate.Location = new Point(123, 137);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 12;
            // 
            // cboxGender
            // 
            cboxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxGender.FormattingEnabled = true;
            cboxGender.Location = new Point(123, 234);
            cboxGender.Name = "cboxGender";
            cboxGender.Size = new Size(121, 23);
            cboxGender.TabIndex = 15;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(33, 284);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(120, 45);
            btnSignUp.TabIndex = 16;
            btnSignUp.Text = "Sign-Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnCancel
            // 
            btnCancel.AccessibleRole = AccessibleRole.None;
            btnCancel.Location = new Point(182, 284);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 45);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // numWeight
            // 
            numWeight.Location = new Point(123, 175);
            numWeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(120, 23);
            numWeight.TabIndex = 18;
            numWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // numHeight
            // 
            numHeight.Location = new Point(123, 204);
            numHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(120, 23);
            numHeight.TabIndex = 19;
            numHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // SignUpForm
            // 
            AcceptButton = btnSignUp;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 361);
            ControlBox = false;
            Controls.Add(numHeight);
            Controls.Add(numWeight);
            Controls.Add(btnCancel);
            Controls.Add(btnSignUp);
            Controls.Add(cboxGender);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtPw);
            Controls.Add(txtMail);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMail;
        private TextBox txtPw;
        private TextBox txtName;
        private TextBox txtSurname;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboxGender;
        private Button btnSignUp;
        private Button btnCancel;
        private NumericUpDown numWeight;
        private NumericUpDown numHeight;
    }
}