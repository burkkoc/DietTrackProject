namespace EFDiyet2.PL
{
    partial class UserReportUI
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
            dateTimePicker1 = new DateTimePicker();
            dgvUserreport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUserreport).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // dgvUserreport
            // 
            dgvUserreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserreport.Location = new Point(12, 41);
            dgvUserreport.Name = "dgvUserreport";
            dgvUserreport.Size = new Size(702, 315);
            dgvUserreport.TabIndex = 1;
            // 
            // UserReportUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUserreport);
            Controls.Add(dateTimePicker1);
            Name = "UserReportUI";
            Text = "UserReportUI";
            ((System.ComponentModel.ISupportInitialize)dgvUserreport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DataGridView dgvUserreport;
    }
}