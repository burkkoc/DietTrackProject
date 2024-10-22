using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyet2.PL
{
    public partial class AdminForm : Form
    {
        AdminReport adminReport;
        FoodCategoryCrud foodCategoryCrud;
        MealCrud mealCrud;
        FoodCrud foodCrud;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void foodReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminReport = new AdminReport();
            adminReport.MdiParent = this;
            adminReport.Dock = DockStyle.Fill;
            this.Size = adminReport.Size;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            HideForms(adminReport.Name);

            adminReport.Show();
        }

        private void manageFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodCategoryCrud = new FoodCategoryCrud();
            foodCategoryCrud.MdiParent = this;
            foodCategoryCrud.Dock = DockStyle.Fill;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            HideForms(foodCategoryCrud.Name);

            foodCategoryCrud.Show();
        }

        private void manageMealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mealCrud = new MealCrud();
            mealCrud.MdiParent = this;
            mealCrud.Dock = DockStyle.Fill;
            this.Size = mealCrud.Size;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            HideForms(mealCrud.Name);
            mealCrud.Show();
        }

        private void manageFoodsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foodCrud = new FoodCrud();
            foodCrud.MdiParent = this;
            foodCrud.Dock = DockStyle.Fill;
            this.Size = foodCrud.Size;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            HideForms(foodCrud.Name);
            foodCrud.Show();
        }


        private void HideForms(string formName)
        {
            Form[] FormNames = { adminReport, foodCategoryCrud, mealCrud, foodCrud};

            foreach (var item in FormNames)
            {
                if (item != null)
                {

                    if (!item.Text.Equals(formName))
                    {
                        item.Hide();
                    }
                }
            }
        }
    }
}
