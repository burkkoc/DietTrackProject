namespace EFDiyet2.PL
{
    partial class AdminReport
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
            groupBox1 = new GroupBox();
            gboxDate = new GroupBox();
            dtvEnd = new DateTimePicker();
            dtvStart = new DateTimePicker();
            radioMonthly = new RadioButton();
            radioWeekly = new RadioButton();
            dgvFoodReport = new DataGridView();
            checkDate = new CheckBox();
            checkUser = new CheckBox();
            cboxUser = new ComboBox();
            btnGetReport = new Button();
            groupBox1.SuspendLayout();
            gboxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodReport).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gboxDate);
            groupBox1.Controls.Add(dgvFoodReport);
            groupBox1.Controls.Add(checkDate);
            groupBox1.Controls.Add(checkUser);
            groupBox1.Controls.Add(cboxUser);
            groupBox1.Controls.Add(btnGetReport);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food Report";
            // 
            // gboxDate
            // 
            gboxDate.Controls.Add(dtvEnd);
            gboxDate.Controls.Add(dtvStart);
            gboxDate.Controls.Add(radioMonthly);
            gboxDate.Controls.Add(radioWeekly);
            gboxDate.Location = new Point(79, 61);
            gboxDate.Name = "gboxDate";
            gboxDate.Size = new Size(233, 137);
            gboxDate.TabIndex = 6;
            gboxDate.TabStop = false;
            // 
            // dtvEnd
            // 
            dtvEnd.Location = new Point(23, 60);
            dtvEnd.Name = "dtvEnd";
            dtvEnd.Size = new Size(200, 23);
            dtvEnd.TabIndex = 7;
            // 
            // dtvStart
            // 
            dtvStart.Location = new Point(23, 22);
            dtvStart.Name = "dtvStart";
            dtvStart.Size = new Size(200, 23);
            dtvStart.TabIndex = 5;
            dtvStart.ValueChanged += dtvStart_ValueChanged;
            // 
            // radioMonthly
            // 
            radioMonthly.AutoSize = true;
            radioMonthly.Location = new Point(134, 99);
            radioMonthly.Name = "radioMonthly";
            radioMonthly.Size = new Size(70, 19);
            radioMonthly.TabIndex = 4;
            radioMonthly.Text = "Monthly";
            radioMonthly.UseVisualStyleBackColor = true;
            radioMonthly.CheckedChanged += radioMonthly_CheckedChanged;
            // 
            // radioWeekly
            // 
            radioWeekly.AutoSize = true;
            radioWeekly.Checked = true;
            radioWeekly.Location = new Point(40, 99);
            radioWeekly.Name = "radioWeekly";
            radioWeekly.Size = new Size(63, 19);
            radioWeekly.TabIndex = 3;
            radioWeekly.TabStop = true;
            radioWeekly.Text = "Weekly";
            radioWeekly.UseVisualStyleBackColor = true;
            radioWeekly.CheckedChanged += radioWeekly_CheckedChanged;
            // 
            // dgvFoodReport
            // 
            dgvFoodReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodReport.Location = new Point(333, 22);
            dgvFoodReport.Name = "dgvFoodReport";
            dgvFoodReport.Size = new Size(437, 226);
            dgvFoodReport.TabIndex = 5;
            // 
            // checkDate
            // 
            checkDate.AutoSize = true;
            checkDate.Location = new Point(17, 74);
            checkDate.Name = "checkDate";
            checkDate.Size = new Size(56, 19);
            checkDate.TabIndex = 2;
            checkDate.Text = "Date: ";
            checkDate.UseVisualStyleBackColor = true;
            checkDate.CheckedChanged += checkDate_CheckedChanged;
            // 
            // checkUser
            // 
            checkUser.AutoSize = true;
            checkUser.Location = new Point(17, 27);
            checkUser.Name = "checkUser";
            checkUser.Size = new Size(52, 19);
            checkUser.TabIndex = 4;
            checkUser.Text = "User:";
            checkUser.UseVisualStyleBackColor = true;
            // 
            // cboxUser
            // 
            cboxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxUser.FormattingEnabled = true;
            cboxUser.Location = new Point(79, 25);
            cboxUser.Name = "cboxUser";
            cboxUser.Size = new Size(214, 23);
            cboxUser.TabIndex = 3;
            // 
            // btnGetReport
            // 
            btnGetReport.Location = new Point(149, 299);
            btnGetReport.Name = "btnGetReport";
            btnGetReport.Size = new Size(98, 58);
            btnGetReport.TabIndex = 1;
            btnGetReport.Text = "Get Report";
            btnGetReport.UseVisualStyleBackColor = true;
            btnGetReport.Click += btnGetReport_Click;
            // 
            // AdminReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminReport";
            Text = "AdminRapor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gboxDate.ResumeLayout(false);
            gboxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkUser;
        private ComboBox cboxUser;
        private CheckBox checkDate;
        private Button btnGetReport;
        private DataGridView dgvFoodReport;
        private GroupBox gboxDate;
        private RadioButton radioMonthly;
        private RadioButton radioWeekly;
        private DateTimePicker dtvEnd;
        private DateTimePicker dtvStart;
    }
}