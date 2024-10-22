using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.BLL.Models;
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
    public partial class UserReportUI : Form
    {
        int userLogedin;
        UserFoodManager userFoodManager = new UserFoodManager();
        public UserReportUI(int user)
        {
            InitializeComponent();
            userLogedin = user;
            dgvUserreport.DataSource = userFoodManager.GetAll().Where(e => e.UserInformationId == userLogedin && e.UCreated.Day == dateTimePicker1.Value.Day && e.UCreated.Month == dateTimePicker1.Value.Month && e.UCreated.Year == dateTimePicker1.Value.Year).ToList();
            dgvUserreport.Columns[0].Visible = false;
            dgvUserreport.Columns[1].Visible = false;
            dgvUserreport.Columns[3].Visible = false;
            dgvUserreport.Columns[4].Visible = false;
            dgvUserreport.Columns[5].Visible = false;
            dgvUserreport.Columns[6].Visible = false;
            dgvUserreport.Columns[10].Visible = false;
            //var userFoodData = userFoodManager.GetAll().Where(e => e.UserInformationId == userLogedin).ToList();
            //dgvUserreport.DataSource=userFoodData;
            //dgvUserreport.DataSource = userFoodManager.GetAll().Where(e => e.Id == userLogedin && e.UCreated.Day == dateTimePicker1.Value.Day ).ToList();
        }


        private void UserReport_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dgvUserreport.DataSource = null;
            //var userFoodData = userFoodManager.GetAll().ToList();
            //dgvUserreport.DataSource = userFoodData;

           dgvUserreport.DataSource = userFoodManager.GetAll().Where(e => e.UserInformationId == userLogedin && e.UCreated.Day == dateTimePicker1.Value.Day && e.UCreated.Month == dateTimePicker1.Value.Month && e.UCreated.Year == dateTimePicker1.Value.Year).ToList();
            dgvUserreport.Columns[0].Visible = false;
            dgvUserreport.Columns[1].Visible = false;
            dgvUserreport.Columns[3].Visible = false;
            dgvUserreport.Columns[4].Visible = false;
            dgvUserreport.Columns[5].Visible = false;
            dgvUserreport.Columns[6].Visible = false;
            dgvUserreport.Columns[10].Visible = false;
        }
    }
}
