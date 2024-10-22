namespace EFDiyet2.PL
{
    partial class FoodCategoryCrud
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
            btnLISTALL = new Button();
            groupBox3 = new GroupBox();
            label10 = new Label();
            btnSEARCH = new Button();
            label8 = new Label();
            txtSEARCH = new TextBox();
            dtwFOODCATEGORY = new DataGridView();
            btnADD = new Button();
            btnDELETE = new Button();
            btnUPDATE = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtNAME = new TextBox();
            gBoxFoodCategory = new GroupBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtwFOODCATEGORY).BeginInit();
            groupBox1.SuspendLayout();
            gBoxFoodCategory.SuspendLayout();
            SuspendLayout();
            // 
            // btnLISTALL
            // 
            btnLISTALL.Location = new Point(18, 128);
            btnLISTALL.Margin = new Padding(3, 2, 3, 2);
            btnLISTALL.Name = "btnLISTALL";
            btnLISTALL.Size = new Size(155, 38);
            btnLISTALL.TabIndex = 27;
            btnLISTALL.Text = "LIST ALL CATEGORIES";
            btnLISTALL.UseVisualStyleBackColor = true;
            btnLISTALL.Click += btnLISTALL_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnSEARCH);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtSEARCH);
            groupBox3.Controls.Add(dtwFOODCATEGORY);
            groupBox3.Location = new Point(336, 21);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(505, 320);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Categories";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 32);
            label10.Name = "label10";
            label10.Size = new Size(128, 15);
            label10.TabIndex = 29;
            label10.Text = "Sought After Category:";
            // 
            // btnSEARCH
            // 
            btnSEARCH.Location = new Point(299, 29);
            btnSEARCH.Margin = new Padding(3, 2, 3, 2);
            btnSEARCH.Name = "btnSEARCH";
            btnSEARCH.Size = new Size(131, 23);
            btnSEARCH.TabIndex = 30;
            btnSEARCH.Text = "SEARCH CATEGORY";
            btnSEARCH.UseVisualStyleBackColor = true;
            btnSEARCH.Click += btnSEARCH_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 58);
            label8.Name = "label8";
            label8.Size = new Size(118, 15);
            label8.TabIndex = 20;
            label8.Text = "CHOSEN CATEGORY:";
            // 
            // txtSEARCH
            // 
            txtSEARCH.Location = new Point(172, 29);
            txtSEARCH.Margin = new Padding(3, 2, 3, 2);
            txtSEARCH.Name = "txtSEARCH";
            txtSEARCH.Size = new Size(110, 23);
            txtSEARCH.TabIndex = 28;
            // 
            // dtwFOODCATEGORY
            // 
            dtwFOODCATEGORY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtwFOODCATEGORY.Location = new Point(24, 92);
            dtwFOODCATEGORY.Margin = new Padding(3, 2, 3, 2);
            dtwFOODCATEGORY.Name = "dtwFOODCATEGORY";
            dtwFOODCATEGORY.RowHeadersWidth = 51;
            dtwFOODCATEGORY.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtwFOODCATEGORY.Size = new Size(460, 212);
            dtwFOODCATEGORY.TabIndex = 0;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(18, 84);
            btnADD.Margin = new Padding(3, 2, 3, 2);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(82, 22);
            btnADD.TabIndex = 1;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // btnDELETE
            // 
            btnDELETE.Location = new Point(232, 84);
            btnDELETE.Margin = new Padding(3, 2, 3, 2);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(82, 22);
            btnDELETE.TabIndex = 2;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = true;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.Location = new Point(125, 84);
            btnUPDATE.Margin = new Padding(3, 2, 3, 2);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(82, 22);
            btnUPDATE.TabIndex = 3;
            btnUPDATE.Text = "UPDATE";
            btnUPDATE.UseVisualStyleBackColor = true;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLISTALL);
            groupBox1.Controls.Add(btnADD);
            groupBox1.Controls.Add(btnDELETE);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnUPDATE);
            groupBox1.Controls.Add(txtNAME);
            groupBox1.Location = new Point(6, 21);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(324, 202);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Food Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 46);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "NAME:";
            // 
            // txtNAME
            // 
            txtNAME.Location = new Point(99, 43);
            txtNAME.Margin = new Padding(3, 2, 3, 2);
            txtNAME.Name = "txtNAME";
            txtNAME.Size = new Size(134, 23);
            txtNAME.TabIndex = 4;
            // 
            // gBoxFoodCategory
            // 
            gBoxFoodCategory.Controls.Add(groupBox1);
            gBoxFoodCategory.Controls.Add(groupBox3);
            gBoxFoodCategory.Location = new Point(12, 0);
            gBoxFoodCategory.Name = "gBoxFoodCategory";
            gBoxFoodCategory.Size = new Size(853, 355);
            gBoxFoodCategory.TabIndex = 29;
            gBoxFoodCategory.TabStop = false;
            // 
            // FoodCategoryCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 369);
            Controls.Add(gBoxFoodCategory);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FoodCategoryCrud";
            Text = "FoodCategoryCrud";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtwFOODCATEGORY).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gBoxFoodCategory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnLISTALL;
        private GroupBox groupBox3;
        private DataGridView dtwFOODCATEGORY;
        private Label label8;
        private Button btnADD;
        private Button btnDELETE;
        private Button btnUPDATE;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNAME;
        private Label label10;
        private Button btnSEARCH;
        private TextBox txtSEARCH;
        private GroupBox gBoxFoodCategory;
    }
}