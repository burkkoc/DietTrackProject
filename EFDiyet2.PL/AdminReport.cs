using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Entities;
using Microsoft.EntityFrameworkCore.Query;
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
    public partial class AdminReport : Form
    {
        public AdminReport()
        {
            InitializeComponent();
            UserInformationManager userManager = new UserInformationManager();
            cboxUser.DataSource = userManager.GetAll();
            checkDate.Checked = true;
            checkUser.Checked = true;
            dtvStart.MaxDate = DateTime.Today;
            dtvEnd.MaxDate = DateTime.Today;
            dtvEnd.Enabled = false;
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked)
                gboxDate.Enabled = true;
            else
                gboxDate.Enabled = false;
        }

        private void dtvStart_ValueChanged(object sender, EventArgs e)
        {
            SetDate();
        }

        public void SetDate()
        {
            if (radioWeekly.Checked)
            {
                dtvEnd.Value = dtvStart.Value.AddDays(7);
                if (dtvStart.Value.AddDays(7) > DateTime.Today)
                    dtvEnd.Value = DateTime.Today;
                else
                    dtvEnd.Value = dtvStart.Value.AddDays(7);
            }

            else
            {
                if (dtvStart.Value.AddMonths(1) > DateTime.Today)
                    dtvEnd.Value = DateTime.Today;
                else
                    dtvEnd.Value = dtvStart.Value.AddMonths(1);

            }
        }

        private void radioWeekly_CheckedChanged(object sender, EventArgs e)
        {
            SetDate();
        }

        private void radioMonthly_CheckedChanged(object sender, EventArgs e)
        {
            SetDate();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            UserFoodManager userFoodManager = new UserFoodManager();
            FoodManager foodManager = new FoodManager();
            #region msgbox
            //var kisiNeYediId = userFoodManager.Search(x => x.UserInformationId == ((UserInformationModel)cboxUser.SelectedItem).Id).FirstOrDefault().FoodId;

            //var kisiNeYediSayisi = userFoodManager.Search(x => x.UserInformationId == ((UserInformationModel)cboxUser.SelectedItem).Id).Count();

            //var y = foodManager.GetById(kisiNeYediId).Name;
            //var y2 = foodManager.GetById(kisiNeYediId).Calorie;

            //MessageBox.Show($"{cboxUser.SelectedItem}, {y}'den {kisiNeYediSayisi} tane yedi. Toplamda {y2} kalori aldi.");
            #endregion

            
            var selectedUser = userFoodManager.Search(x => x.UserInformationId == ((UserInformationModel)cboxUser.SelectedItem).Id);
            //var x = selectedUser.Select(x => x.);
            //var totalmeal = selectedUser.GroupBy(x=>x.MealId).Count();
            //var maxmeal=selectedUser.Sum(x=>x.MealId);


            //var allInfo = userFoodManager.GetAllById(userId);

            //var mealId = userFoodManager.Search(x => x.MealId == ((MealModel)cboxUser.SelectedItem).Id);

            var maxFood = selectedUser.Max(x => x.Food.Name).Count();


            dgvFoodReport.DataSource = maxFood;
            
        }
    }
}
