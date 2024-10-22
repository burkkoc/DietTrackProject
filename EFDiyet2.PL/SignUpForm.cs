using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Enums;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyet2.PL
{
    public partial class SignUpForm : Form
    {
        LoginForm loginForm;
        public SignUpForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cboxGender.DataSource = Enum.GetValues(typeof(Gender));
            loginForm = new LoginForm();
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirthDate.MinDate = DateTime.Now.AddYears(-100);
           
        }

        public bool EmptyValidation(TextBox[] textBoxes)
        {
            foreach (var item in textBoxes)
            {
                item.Text = item.Text.Trim();
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("Please fill out all the fields.");
                    return true;
                }

            }
            return false;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] txtBoxes = { txtMail, txtName, txtPw, txtSurname };

                if (!EmptyValidation(txtBoxes))
                {
                    string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
                    Regex regex = new Regex(pattern);

                    UserModel userModel = new UserModel();
                    UserManager userManager = new UserManager();

                    if (!regex.IsMatch(txtMail.Text))
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        return;
                    }
                    if (userManager.GetAll().FirstOrDefault(x => x.Email == txtMail.Text) != null)
                    {
                        MessageBox.Show("The email address you entered is registered in the system.");
                        return;
                    }

                    userModel.Email = txtMail.Text;
                    userModel.Password = txtPw.Text;
                    userModel.IsAdmin = false;
                    userManager.Add(userModel);

                    UserInformationModel userInformationModel = new UserInformationModel();
                    UserInformationManager userInformationManager = new UserInformationManager();
                    userInformationModel.FirstName = txtName.Text;
                    userInformationModel.LastName = txtSurname.Text;
                    userInformationModel.BirthDate = dtpBirthDate.Value;
                    userInformationModel.Weight = (float)numWeight.Value;
                    userInformationModel.Height = (float)numHeight.Value;
                    userInformationModel.Gender = (Gender)cboxGender.SelectedItem;
                    userInformationModel.UserId = userManager.Search(x => x.Email == txtMail.Text).FirstOrDefault().Id;
                    userInformationManager.Add(userInformationModel);
                    


                    MessageBox.Show("Registration successful.");
                    this.Dispose();
                    loginForm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginForm.ShowDialog();
        }
    }
}
