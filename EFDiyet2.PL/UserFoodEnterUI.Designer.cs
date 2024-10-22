namespace EFDiyet2.PL
{
    partial class UserFoodEnterUI
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            btnAddFood = new Button();
            cbxMeal = new ComboBox();
            lblMeal = new Label();
            cbxPorsion = new ComboBox();
            lblPorsion = new Label();
            lblPiece = new Label();
            nudPiece = new NumericUpDown();
            lblTotalCal = new Label();
            lblCalPiece = new Label();
            txtboxCal = new TextBox();
            txtTotalCal = new TextBox();
            dataGridView2 = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Food";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(258, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(240, 210);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(12, 244);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 23);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbxMeal
            // 
            cbxMeal.FormattingEnabled = true;
            cbxMeal.Location = new Point(131, 57);
            cbxMeal.Name = "cbxMeal";
            cbxMeal.Size = new Size(121, 23);
            cbxMeal.TabIndex = 3;
            // 
            // lblMeal
            // 
            lblMeal.AutoSize = true;
            lblMeal.Location = new Point(12, 60);
            lblMeal.Name = "lblMeal";
            lblMeal.Size = new Size(33, 15);
            lblMeal.TabIndex = 4;
            lblMeal.Text = "Meal";
            // 
            // cbxPorsion
            // 
            cbxPorsion.FormattingEnabled = true;
            cbxPorsion.Location = new Point(131, 86);
            cbxPorsion.Name = "cbxPorsion";
            cbxPorsion.Size = new Size(121, 23);
            cbxPorsion.TabIndex = 3;
            // 
            // lblPorsion
            // 
            lblPorsion.AutoSize = true;
            lblPorsion.Location = new Point(12, 89);
            lblPorsion.Name = "lblPorsion";
            lblPorsion.Size = new Size(47, 15);
            lblPorsion.TabIndex = 4;
            lblPorsion.Text = "Porsion";
            // 
            // lblPiece
            // 
            lblPiece.AutoSize = true;
            lblPiece.Location = new Point(12, 118);
            lblPiece.Name = "lblPiece";
            lblPiece.Size = new Size(35, 15);
            lblPiece.TabIndex = 4;
            lblPiece.Text = "Piece";
            // 
            // nudPiece
            // 
            nudPiece.Location = new Point(131, 118);
            nudPiece.Name = "nudPiece";
            nudPiece.Size = new Size(120, 23);
            nudPiece.TabIndex = 5;
            nudPiece.ValueChanged += nudPiece_ValueChanged;
            // 
            // lblTotalCal
            // 
            lblTotalCal.AutoSize = true;
            lblTotalCal.Location = new Point(12, 199);
            lblTotalCal.Name = "lblTotalCal";
            lblTotalCal.Size = new Size(52, 15);
            lblTotalCal.TabIndex = 4;
            lblTotalCal.Text = "TotalCal:";
            // 
            // lblCalPiece
            // 
            lblCalPiece.AutoSize = true;
            lblCalPiece.Location = new Point(12, 159);
            lblCalPiece.Name = "lblCalPiece";
            lblCalPiece.Size = new Size(80, 15);
            lblCalPiece.TabIndex = 4;
            lblCalPiece.Text = "Calorie/Piece:";
            // 
            // txtboxCal
            // 
            txtboxCal.Location = new Point(131, 156);
            txtboxCal.Name = "txtboxCal";
            txtboxCal.ReadOnly = true;
            txtboxCal.Size = new Size(120, 23);
            txtboxCal.TabIndex = 6;
            txtboxCal.Text = "0";
            txtboxCal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalCal
            // 
            txtTotalCal.Location = new Point(131, 191);
            txtTotalCal.Name = "txtTotalCal";
            txtTotalCal.ReadOnly = true;
            txtTotalCal.Size = new Size(120, 23);
            txtTotalCal.TabIndex = 6;
            txtTotalCal.Text = "0";
            txtTotalCal.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 273);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(486, 265);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Food";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(176, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // UserFoodEnterUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 550);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtTotalCal);
            Controls.Add(txtboxCal);
            Controls.Add(nudPiece);
            Controls.Add(lblCalPiece);
            Controls.Add(lblTotalCal);
            Controls.Add(lblPiece);
            Controls.Add(lblPorsion);
            Controls.Add(lblMeal);
            Controls.Add(cbxPorsion);
            Controls.Add(cbxMeal);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddFood);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "UserFoodEnterUI";
            Text = "UserFoodEnter";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPiece).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btnAddFood;
        private ComboBox cbxMeal;
        private Label lblMeal;
        private ComboBox cbxPorsion;
        private Label lblPorsion;
        private Label lblPiece;
        private NumericUpDown nudPiece;
        private Label lblTotalCal;
        private Label lblCalPiece;
        private TextBox txtboxCal;
        private TextBox txtTotalCal;
        private DataGridView dataGridView2;
        private Button btnUpdate;
        private Button btnDelete;
        private DateTimePicker dateTimePicker1;
    }
}