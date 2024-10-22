namespace EFDiyet2.PL
{
    partial class BaseForm
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
            menuStrip1 = new MenuStrip();
            foodCategoryAddToolStripMenuItem = new ToolStripMenuItem();
            foodAddToolStripMenuItem = new ToolStripMenuItem();
            mealAddToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { foodCategoryAddToolStripMenuItem, foodAddToolStripMenuItem, mealAddToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // foodCategoryAddToolStripMenuItem
            // 
            foodCategoryAddToolStripMenuItem.Name = "foodCategoryAddToolStripMenuItem";
            foodCategoryAddToolStripMenuItem.Size = new Size(145, 24);
            foodCategoryAddToolStripMenuItem.Text = "FoodCategoryAdd";
            foodCategoryAddToolStripMenuItem.Click += foodCategoryAddToolStripMenuItem_Click;
            // 
            // foodAddToolStripMenuItem
            // 
            foodAddToolStripMenuItem.Name = "foodAddToolStripMenuItem";
            foodAddToolStripMenuItem.Size = new Size(85, 24);
            foodAddToolStripMenuItem.Text = "FoodAdd";
            foodAddToolStripMenuItem.Click += foodAddToolStripMenuItem_Click;
            // 
            // mealAddToolStripMenuItem
            // 
            mealAddToolStripMenuItem.Name = "mealAddToolStripMenuItem";
            mealAddToolStripMenuItem.Size = new Size(84, 24);
            mealAddToolStripMenuItem.Text = "MealAdd";
            mealAddToolStripMenuItem.Click += mealAddToolStripMenuItem_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "BaseForm";
            Text = "BaseForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem foodCategoryAddToolStripMenuItem;
        private ToolStripMenuItem foodAddToolStripMenuItem;
        private ToolStripMenuItem mealAddToolStripMenuItem;
    }
}