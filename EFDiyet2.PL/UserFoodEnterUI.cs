using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Enums;
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
    public partial class UserFoodEnterUI : Form
    {
        FoodModel foodmodelselected = new FoodModel();
        FoodManager foodManagerSearch = new FoodManager();
        MealModel mealModel = new MealModel();
        MealManager mealManager = new MealManager();
        UserFoodModel selectedUserFoodModel;
        UserFoodManager selecteduserFoodManager1 = new UserFoodManager();
        MealModel SelectedMeal;
        int user;

        public UserFoodEnterUI(int userLogedin)
        {
            user = userLogedin;
            InitializeComponent();
            cbxMeal.Items.AddRange(mealManager.GetAll().ToArray());
            cbxPorsion.DataSource = Enum.GetValues(typeof(Portion));
            Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            dataGridView1.DataSource = foodManagerSearch.Search(e => e.Name.Contains(textBox1.Text)).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {

            UserFoodModel userFoodModel = new UserFoodModel();

            UserFoodManager userFoodManager = new UserFoodManager();

            userFoodModel.FoodId = ((FoodModel)dataGridView1.SelectedRows[0].DataBoundItem).Id;

            userFoodModel.MealId = ((MealModel)cbxMeal.SelectedItem).Id;

            userFoodModel.Portion = (Portion)cbxPorsion.SelectedItem;

            userFoodModel.UserInformationId = user;

            userFoodModel.UCreated = dateTimePicker1.Value;
            //userFoodModel.UserInformationId = User informations

            userFoodModel.Piece = Convert.ToInt32(nudPiece.Text);

            userFoodManager.Add(userFoodModel);

            Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

           
            selectedUserFoodModel.FoodId = ((FoodModel)dataGridView1.SelectedRows[0].DataBoundItem).Id;

            selectedUserFoodModel.MealId = ((MealModel)cbxMeal.SelectedItem).Id;

            selectedUserFoodModel.Portion = (Portion)cbxPorsion.SelectedItem;

            selectedUserFoodModel.UserInformationId = user;

            selectedUserFoodModel.Piece = Convert.ToInt32(nudPiece.Text);

            selecteduserFoodManager1.Update(selectedUserFoodModel);

            Refresh();
            }
             catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
            //UserFoodModel userFoodModel2 = new UserFoodModel();
            //userFoodModel2.Id
            selecteduserFoodManager1.Delete(selectedUserFoodModel);
            Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }
        }

        void Refresh()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = selecteduserFoodManager1.GetAll()
                                                            .Where(u => u.UCreated.Date.Day == dateTimePicker1.Value.Day && u.DataStatus != DataStatus.Deleted)
                                                            .ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[10].Visible = false;




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            txtboxCal.Text = ((FoodModel)dataGridView1.SelectedRows[0].DataBoundItem).Calorie.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }

        }

        private void nudPiece_ValueChanged(object sender, EventArgs e)
        {
            try
            {
            txtTotalCal.Text = (Convert.ToDecimal(((FoodModel)dataGridView1.SelectedRows[0].DataBoundItem).Calorie) * (nudPiece.Value)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            selectedUserFoodModel = (UserFoodModel)dataGridView2.SelectedRows[0].DataBoundItem;

            SelectedMeal = mealManager.GetAll().FirstOrDefault(e => e.Id == selectedUserFoodModel.MealId);
            //Search(e => e.Id == selectedUserFoodModel.Id).FirstOrDefault();

            cbxMeal.SelectedItem = SelectedMeal;

            cbxPorsion.SelectedItem = selecteduserFoodManager1.Search(p => p.Portion == selectedUserFoodModel.Portion).FirstOrDefault();

            textBox1.Text = foodManagerSearch.Search(e => e.Id == selectedUserFoodModel.FoodId).FirstOrDefault().Name;

            txtboxCal.Text = foodManagerSearch.Search(e => e.Id == selectedUserFoodModel.FoodId).FirstOrDefault().Calorie.ToString();

            nudPiece.Value = selectedUserFoodModel.Piece;

            dataGridView1.DataSource = foodManagerSearch.Search(e => e.Name.Contains(textBox1.Text)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
