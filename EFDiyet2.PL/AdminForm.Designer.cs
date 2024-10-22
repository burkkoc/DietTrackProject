namespace EFDiyet2.PL
{
    partial class AdminForm
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
            foodToolStripMenuItem = new ToolStripMenuItem();
            manageFoodsToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem = new ToolStripMenuItem();
            foodReportsToolStripMenuItem = new ToolStripMenuItem();
            mealToolStripMenuItem = new ToolStripMenuItem();
            manageMealsToolStripMenuItem = new ToolStripMenuItem();
            manageFoodsToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { foodToolStripMenuItem, ToolStripMenuItem, mealToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // foodToolStripMenuItem
            // 
            foodToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageFoodsToolStripMenuItem, manageFoodsToolStripMenuItem1 });
            foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            foodToolStripMenuItem.Size = new Size(46, 20);
            foodToolStripMenuItem.Text = "Food";
            // 
            // manageFoodsToolStripMenuItem
            // 
            manageFoodsToolStripMenuItem.Name = "manageFoodsToolStripMenuItem";
            manageFoodsToolStripMenuItem.Size = new Size(206, 22);
            manageFoodsToolStripMenuItem.Text = "Manage Food Categories";
            manageFoodsToolStripMenuItem.Click += manageFoodsToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foodReportsToolStripMenuItem });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(59, 20);
            ToolStripMenuItem.Text = "Reports";
            // 
            // foodReportsToolStripMenuItem
            // 
            foodReportsToolStripMenuItem.Name = "foodReportsToolStripMenuItem";
            foodReportsToolStripMenuItem.Size = new Size(144, 22);
            foodReportsToolStripMenuItem.Text = "Food Reports";
            foodReportsToolStripMenuItem.Click += foodReportsToolStripMenuItem_Click;
            // 
            // mealToolStripMenuItem
            // 
            mealToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageMealsToolStripMenuItem });
            mealToolStripMenuItem.Name = "mealToolStripMenuItem";
            mealToolStripMenuItem.Size = new Size(45, 20);
            mealToolStripMenuItem.Text = "Meal";
            // 
            // manageMealsToolStripMenuItem
            // 
            manageMealsToolStripMenuItem.Name = "manageMealsToolStripMenuItem";
            manageMealsToolStripMenuItem.Size = new Size(151, 22);
            manageMealsToolStripMenuItem.Text = "Manage Meals";
            manageMealsToolStripMenuItem.Click += manageMealsToolStripMenuItem_Click;
            // 
            // manageFoodsToolStripMenuItem1
            // 
            manageFoodsToolStripMenuItem1.Name = "manageFoodsToolStripMenuItem1";
            manageFoodsToolStripMenuItem1.Size = new Size(206, 22);
            manageFoodsToolStripMenuItem1.Text = "Manage Foods";
            manageFoodsToolStripMenuItem1.Click += manageFoodsToolStripMenuItem1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem foodReportsToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem manageFoodsToolStripMenuItem;
        private ToolStripMenuItem mealToolStripMenuItem;
        private ToolStripMenuItem manageMealsToolStripMenuItem;
        private ToolStripMenuItem manageFoodsToolStripMenuItem1;
    }
}