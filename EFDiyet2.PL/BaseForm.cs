using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
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
    public partial class BaseForm : Form
    {
        private readonly EFDiyet2DbContext _db;
        private readonly IRepository<FoodCategory> _repository;
        private readonly FoodCategoryManager _foodCategoryManager;
        private void FormAc(Form gosterilecekForm)
        {
            gosterilecekForm.StartPosition = FormStartPosition.Manual;

            if (!MdiChildren.Contains(gosterilecekForm))
                gosterilecekForm.MdiParent = this;
            foreach (var form in MdiChildren)
            {
                if (form.GetType() == gosterilecekForm.GetType())
                    form.Show();
                else
                    form.Close();
            }
        }
        public BaseForm()
        {
            InitializeComponent();
        }

        private void foodCategoryAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new FoodCategoryCrud());
        }

        private void foodAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new FoodCrud());
        }

        private void mealAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new MealCrud());
        }
    }
}
