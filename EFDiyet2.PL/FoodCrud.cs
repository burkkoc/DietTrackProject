using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AutoMapper;
using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Repository.Concrete;

namespace EFDiyet2.PL
{
    public partial class FoodCrud : Form
    {
        private readonly FoodManager _foodManager;
        private readonly FoodCategoryManager _foodCategoryManager;
        private FoodModel _selectedFood;

        public FoodCrud()
        {
            InitializeComponent();

            // Manager sınıflarını oluştur
            _foodManager = new FoodManager();
            _foodCategoryManager = new FoodCategoryManager();

            // Olayları bağla
            dtwFOOD.CellClick += dtwFOOD_CellClick;
            btnPictureSHOW.Click += btnPictureSHOW_Click;

            // ComboBox ve DataGridView'i başlat
            InitializeFoodCategoriesComboBox();

        }

        private void InitializeFoodCategoriesComboBox()
        {
            try
            {
                // Tüm kategori bilgilerini al ve ComboBox'a ekle
                var foodCategories = _foodCategoryManager.GetAll();
                cmbFOODCATEGORY.DataSource = foodCategories;
                cmbFOODCATEGORY.DisplayMember = "Name";
                cmbFOODCATEGORY.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            try
            {
                // Boş bir liste oluştur ve DataGridView'e set et
                dtwFOOD.DataSource = _foodManager.GetAll();

                //DataGridView'i yeniden çiz
                dtwFOOD.Columns[0].Visible = false;
                dtwFOOD.Columns[7].Visible = false;
                dtwFOOD.Columns[10].Visible = false;
                dtwFOOD.Columns[11].Visible = false;

                // DataGridView'i yeniden çiz
                dtwFOOD.Refresh();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void dtwFOOD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && rowIndex < dtwFOOD.Rows.Count)
                {
                    DataGridViewRow selectedRow = dtwFOOD.Rows[rowIndex];
                    _selectedFood = selectedRow.DataBoundItem as FoodModel;

                    // TextBox'ları güncelle
                    txtNAME.Text = _selectedFood?.Name;
                    txtCALORIE.Text = _selectedFood?.Calorie.ToString();
                    txtFAT.Text = _selectedFood?.Fat.ToString();
                    txtPROTEIN.Text = _selectedFood?.Protein.ToString();
                    txtCARBONHYDRATE.Text = _selectedFood?.Carbohydrate.ToString();
                    txtFIBER.Text = _selectedFood?.Fiber.ToString();
                    cmbFOODCATEGORY.SelectedItem = _selectedFood?.FoodCategory;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            try
            {
                float calorie;
                if (float.TryParse(txtCALORIE.Text, out calorie))
                {
                    // Yeni bir FoodModel oluştur ve eklemeyi gerçekleştir
                    FoodModel newFood = new FoodModel
                    {
                        Name = txtNAME.Text,
                        Calorie = calorie,
                        Fat = float.Parse(txtFAT.Text),
                        Protein = float.Parse(txtPROTEIN.Text),
                        Carbohydrate = float.Parse(txtCARBONHYDRATE.Text),
                        Fiber = float.Parse(txtFIBER.Text),
                        FoodCategoryId = (int)cmbFOODCATEGORY.SelectedValue,
                        Picture = GetImageDataFromPictureBox(pctCHOOSENFOOD)
                    };

                    _foodManager.Add(newFood);
                    InitializeDataGridView();
                    ShowInfoMessage("Food added successfully.");

                    // Formu temizle
                    ClearForm();
                }
                else
                {
                    ShowErrorMessage("Invalid calorie value. Please enter a valid number.");
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
                if (_selectedFood != null && !string.IsNullOrEmpty(txtNAME.Text))
                {
     
                    UpdateSelectedFoodModel();


                    _foodManager.Update(_selectedFood);


                    InitializeDataGridView();
                    ShowInfoMessage("Food updated successfully.");


                    ClearForm();
                }
                else
                {
                    ShowErrorMessage("Please select a food item from the list before updating.");
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
                if (_selectedFood != null)
                {

                    _foodManager.Delete(_selectedFood);


                    InitializeDataGridView();
                    ShowInfoMessage("Food deleted successfully.");


                    ClearForm();
                }
                else
                {
                    ShowErrorMessage("Please select a food item from the list before deleting.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }


        private void btnPCFND_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // PictureBox kontrolüne resmi göster
                    ShowFoodImageFromFile(filePath);
                }
            }
        }

        private void btnPictureSHOW_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedFood != null)
                {
                    // Sadece resmi göster
                    ShowFoodImage(_selectedFood.Picture);
                }
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
            txtCALORIE.Text = string.Empty;
            txtFAT.Text = string.Empty;
            txtPROTEIN.Text = string.Empty;
            txtCARBONHYDRATE.Text = string.Empty;
            txtFIBER.Text = string.Empty;
            cmbFOODCATEGORY.SelectedIndex = -1;

            // PictureBox'ı temizle
            pctCHOOSENFOOD.Image = null;
        }

        private void ShowFoodImage(byte[] imageData)
        {
            try
            {
                // Mevcut resmi temizle
                if (pctCHOOSENFOOD.Image != null)
                {
                    pctCHOOSENFOOD.Image.Dispose();
                }

                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        // Yeni bir Bitmap oluşturarak PictureBox'a resmi yükle
                        using (var newImage = System.Drawing.Image.FromStream(stream))
                        {
                            pctCHOOSENFOOD.Image = new Bitmap(newImage);
                        }
                    }
                }
                else
                {
                    pctCHOOSENFOOD.Image = null;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ShowFoodImageFromFile(string filePath)
        {
            try
            {
                byte[] imageData = File.ReadAllBytes(filePath);
                ShowFoodImage(imageData);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private byte[] GetImageDataFromPictureBox(PictureBox pictureBox)
        {
            try
            {
                if (pictureBox.Image != null)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        // Resmi PNG formatında kaydet
                        pictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        return stream.ToArray();
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
                return null;
            }
        }

        private void UpdateSelectedFoodModel()
        {
            // Kullanıcıdan alınan güncellenmiş bilgilerle FoodModel'i güncelle
            _selectedFood.Name = txtNAME.Text;
            _selectedFood.Calorie = float.Parse(txtCALORIE.Text);
            _selectedFood.Fat = float.Parse(txtFAT.Text);
            _selectedFood.Protein = float.Parse(txtPROTEIN.Text);
            _selectedFood.Carbohydrate = float.Parse(txtCARBONHYDRATE.Text);
            _selectedFood.Fiber = float.Parse(txtFIBER.Text);
            _selectedFood.FoodCategoryId = (int)cmbFOODCATEGORY.SelectedValue;
            _selectedFood.Picture = GetImageDataFromPictureBox(pctCHOOSENFOOD);
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

                // FoodManager'dan Search metodu ile arama yap
                List<FoodModel> searchResults = _foodManager.Search(food => food.Name.StartsWith(searchKeyword));

                // Kontrol et: Arama sonuçları var mı?
                if (searchResults.Count == 0)
                {
                    // Sonuç yoksa hata mesajı göster ve metoddan çık
                    ShowErrorMessage("No matching records found.");
                    return;
                }

                // DataGridView'i arama sonuçlarıyla güncelle
                dtwFOOD.DataSource = searchResults;

                ShowInfoMessage("Search completed successfully.");
                searchCompleted = true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }

        }

        private void btnLISTALL_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'i başlat
                InitializeDataGridView();

                // Tüm Food kategorilerini al
                var allFoods = _foodManager.GetAll();

                // Kontrol et: Tüm Food kategorileri bulunamadıysa
                if (allFoods.Count == 0)
                {
                    MessageBox.Show("No Foods found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); // Eğer veri yoksa formu temizle
                    return;
                }

                // DataGridView'e tüm Food kategorilerini set et
                dtwFOOD.DataSource = allFoods;

                // DataGridView'den seçili olanı doldur
                if (dtwFOOD.SelectedRows.Count > 0)
                {
                    int rowIndex = dtwFOOD.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dtwFOOD.Rows[rowIndex];
                    _selectedFood = selectedRow.DataBoundItem as FoodModel;

                    // TextBox'ları güncelle
                    txtNAME.Text = _selectedFood?.Name;
                }

                // DataGridView'i yeniden çiz
                dtwFOOD.Refresh();

                ShowInfoMessage("All Foods listed successfully.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
    }
}