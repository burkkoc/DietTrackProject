using AutoMapper;
using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.BLL.Models;
using System;
using System.Windows.Forms;

namespace EFDiyet2.PL
{
    public partial class FoodCategoryCrud : Form
    {
        private readonly FoodCategoryManager _foodCategoryManager;
        private FoodCategoryModel _selectedFoodCategory;

        public FoodCategoryCrud()
        {
            InitializeComponent();

            // Manager sınıflarını oluştur
            _foodCategoryManager = new FoodCategoryManager();

            // Olayları bağla
            dtwFOODCATEGORY.CellClick += dataGridView1_CellClick;
          
        }

        private void InitializeDataGridView()
        {
            try
            {
                // Boş bir liste oluştur ve DataGridView'e set et
                dtwFOODCATEGORY.DataSource = _foodCategoryManager.GetAll();
                dtwFOODCATEGORY.Columns[0].Visible = false;
                dtwFOODCATEGORY.Columns[2].Visible = false;
                // DataGridView'i yeniden çiz
                dtwFOODCATEGORY.Refresh();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && rowIndex < dtwFOODCATEGORY.Rows.Count)
                {
                    DataGridViewRow selectedRow = dtwFOODCATEGORY.Rows[rowIndex];
                    _selectedFoodCategory = selectedRow.DataBoundItem as FoodCategoryModel;

                    txtNAME.Text = _selectedFoodCategory?.Name;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNAME.Text;

                if (!string.IsNullOrEmpty(name))
                {
                    // Yeni bir FoodCategoryModel oluştur ve eklemeyi gerçekleştir
                    FoodCategoryModel newFoodCategory = new FoodCategoryModel
                    {
                        Name = name,
                    };

                    _foodCategoryManager.Add(newFoodCategory);
                    InitializeDataGridView();
                    ShowInfoMessage("Food category added successfully.");

                    // Formu temizle
                    ClearForm();
                }
                else
                {
                    ShowErrorMessage("Please enter a valid food category name.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedFoodCategory != null && !string.IsNullOrEmpty(txtNAME.Text))
                {
                    UpdateSelectedFoodCategoryModel();
        
                    _foodCategoryManager.Update(_selectedFoodCategory);

                    InitializeDataGridView();
                    ShowInfoMessage("Food category updated successfully.");

         
                    ClearForm();
                }
                else
                {
                    ShowErrorMessage("Please select a food category from the list before updating.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedFoodCategory != null)
                {
 
                    _foodCategoryManager.Delete(_selectedFoodCategory);

                    InitializeDataGridView();
                    ShowInfoMessage("Food category deleted successfully.");

                    ClearForm();
                }
                else
                {
                    ShowErrorMessage("Please select a food category from the list before deleting.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        private void btnLISTALL_Click_1(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'i başlat
                InitializeDataGridView();

                // Tüm Food kategorilerini al
                var allFoodCategorys = _foodCategoryManager.GetAll();

                // Kontrol et: Tüm Food kategorileri bulunamadıysa
                if (allFoodCategorys.Count == 0)
                {
                    MessageBox.Show("No FoodCategorys found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); // Eğer veri yoksa formu temizle
                    return;
                }

                // DataGridView'e tüm Food kategorilerini set et
                dtwFOODCATEGORY.DataSource = allFoodCategorys;

                // DataGridView'den seçili olanı doldur
                if (dtwFOODCATEGORY.SelectedRows.Count > 0)
                {
                    int rowIndex = dtwFOODCATEGORY.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dtwFOODCATEGORY.Rows[rowIndex];
                    _selectedFoodCategory = selectedRow.DataBoundItem as FoodCategoryModel;

                    // TextBox'ları güncelle
                    txtNAME.Text = _selectedFoodCategory?.Name;
                }

                // DataGridView'i yeniden çiz
                dtwFOODCATEGORY.Refresh();

                ShowInfoMessage("All FoodCategorys listed successfully.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ClearForm()
        {
            // Form elemanlarını temizle
            txtNAME.Text = string.Empty;
        }

        private void UpdateSelectedFoodCategoryModel()
        {
            // Kullanıcıdan alınan güncellenmiş bilgilerle FoodModel'i güncelle
            _selectedFoodCategory.Name = txtNAME.Text;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show($"Error: {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            bool searchCompleted = false;

            try
            {
                // Kullanıcının girdiği veriyi al
                string searchKeyword = txtSEARCH.Text.Trim();

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

                // FoodCategoryManager'dan Search metodu ile arama yap
                List<FoodCategoryModel> searchResults = _foodCategoryManager.Search(foodCategory => foodCategory.Name.StartsWith(searchKeyword));

                // Kontrol et: Arama sonuçları var mı?
                if (searchResults.Count == 0)
                {
                    // Sonuç yoksa hata mesajı göster ve metoddan çık
                    ShowErrorMessage("No matching records found.");
                    return;
                }

                // DataGridView'i arama sonuçlarıyla güncelle
                dtwFOODCATEGORY.DataSource = searchResults;

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