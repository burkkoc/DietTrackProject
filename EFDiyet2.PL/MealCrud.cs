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
    public partial class MealCrud : Form
    {
        private readonly MealManager _mealManager;
        private MealModel _selectedMeal;

        public MealCrud()
        {
            InitializeComponent();

            // Manager sınıflarını oluştur
            _mealManager = new MealManager();

            // Olayları bağla
            dtwMEAL1.CellClick += dtwMEAL1_CellClick;
        }
        private void InitializeDataGridView()
        {
            try
            {
                // Boş bir liste oluştur ve DataGridView'e set et
                dtwMEAL1.DataSource = _mealManager.GetAll();
                dtwMEAL1.Columns[0].Visible = false;
                dtwMEAL1.Columns[2].Visible = false;

                // DataGridView'i yeniden çiz
                dtwMEAL1.Refresh();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        private void dtwMEAL1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && rowIndex < dtwMEAL1.Rows.Count)
                {
                    DataGridViewRow selectedRow = dtwMEAL1.Rows[rowIndex];
                    _selectedMeal = selectedRow.DataBoundItem as MealModel;

                    txtNAME1.Text = _selectedMeal?.Name;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        private void btnADD1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNAME1.Text;

                if (!string.IsNullOrEmpty(name))
                {
                    // Yeni bir MealModel oluştur ve eklemeyi gerçekleştir
                    MealModel newMeal = new MealModel
                    {
                        Name = name,
                    };

                    _mealManager.Add(newMeal);
                    InitializeDataGridView();
                    ShowInfoMessage("Meal model added successfully.");

                    // Formu temizle
                    ClearForm();
                }
                else
                {
                    ShowErrorMessage("Please enter a valid meal name.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnUPDATE1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedMeal != null && !string.IsNullOrEmpty(txtNAME.Text))
                {

                    UpdateSelectedMealModel();

                    // Güncelleme işlemini yap
                    _mealManager.Update(_selectedMeal);


                    InitializeDataGridView();
                    ShowInfoMessage("Meal updated successfully.");

                    // Formu temizle
                    ClearForm();
                }
                else
                {

                    ShowErrorMessage("Please select a meal to update.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnDELETE1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedMeal != null)
                {

                    _mealManager.Delete(_selectedMeal);


                    InitializeDataGridView();
                    ShowInfoMessage("Meal deleted successfully.");


                    ClearForm();
                }
                else
                {

                    ShowErrorMessage("Please select a meal to delete.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnLISTALL1_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'i başlat
                InitializeDataGridView();

                // Tüm Food kategorilerini al
                var allMeals = _mealManager.GetAll();

                // Kontrol et: Tüm Food kategorileri bulunamadıysa
                if (allMeals.Count == 0)
                {
                    MessageBox.Show("No Meals found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); // Eğer veri yoksa formu temizle
                    return;
                }

                // DataGridView'e tüm Food kategorilerini set et
                dtwMEAL1.DataSource = allMeals;

                // DataGridView'den seçili olanı doldur
                if (dtwMEAL1.SelectedRows.Count > 0)
                {
                    int rowIndex = dtwMEAL1.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dtwMEAL1.Rows[rowIndex];
                    _selectedMeal = selectedRow.DataBoundItem as MealModel;

                    // TextBox'ları güncelle
                    txtNAME1.Text = _selectedMeal?.Name;
                }

                // DataGridView'i yeniden çiz
                dtwMEAL1.Refresh();

                ShowInfoMessage("All Meals listed successfully.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        private void ClearForm()
        {
            // Form elemanlarını temizle
            txtNAME1.Text = string.Empty;
        }
        private void UpdateSelectedMealModel()
        {
            // Kullanıcıdan alınan güncellenmiş bilgilerle FoodModel'i güncelle
            _selectedMeal.Name = txtNAME1.Text;
        }
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show($"Error: {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSEARCH1_Click(object sender, EventArgs e)
        {
            bool searchCompleted = false;

            try
            {
                // Kullanıcının girdiği veriyi al
                string searchKeyword = txtSEARCH1.Text.Trim();

                // Kontrol et: Arama kelimesi boş mu?
                if (string.IsNullOrWhiteSpace(searchKeyword))
                {
                    // Boşsa hata mesajı göster ve metoddan çık
                    ShowErrorMessage("Please enter a valid search keyword.");
                    return;
                }

                // Kontrol et: Arama kelimesinin başında harf var mı?
                if (!char.IsLetter(searchKeyword[0]))
                {
                    // Başında harf yoksa hata mesajı göster ve metoddan çık
                    ShowErrorMessage("Invalid search keyword. Please start with a letter.");
                    return;
                }

                // MealManager'dan Search metodu ile arama yap
                List<MealModel> searchResults = _mealManager.Search(food => food.Name.StartsWith(searchKeyword));

                // Kontrol et: Arama sonuçları var mı?
                if (searchResults.Count == 0)
                {
                    // Sonuç yoksa hata mesajı göster ve metoddan çık
                    ShowErrorMessage("No matching records found.");
                    return;
                }

                // DataGridView'i arama sonuçlarıyla güncelle
                dtwMEAL1.DataSource = searchResults;

                ShowInfoMessage("Search completed successfully.");
                searchCompleted = true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        
    }
}
