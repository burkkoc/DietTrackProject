
using EFDiyet2.BLL.Manager.Concrete;
using EFDiyet2.BLL.Models;

namespace EFDiyet2.PL
{
    public partial class LoginForm : Form
    {
        
        UserInformationManager userInformationManager = new UserInformationManager();
        public LoginForm()
        {
            InitializeComponent();
            txtEmail.PlaceholderText = "Enter Your Email";
            txtPassword.PlaceholderText = "Enter Your Password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                UserModel userModel = new UserModel();
                UserManager userManager = new UserManager();
                userModel.Email = txtEmail.Text;
                userModel.Password = txtPassword.Text;
                var userLogin = userManager.Search(x => x.Email == txtEmail.Text && x.Password == userModel.Password);
                var UserLogedin = userInformationManager.Search(u => u.UserId == userLogin.FirstOrDefault().Id).FirstOrDefault().Id;
                if (userLogin.Count > 0 && userLogin.FirstOrDefault().IsAdmin == true)
                {

                    MessageBox.Show($"Welcome back {userInformationManager.Search(x=>x.UserId==userLogin.FirstOrDefault().Id).FirstOrDefault().FirstName}!");

                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.ShowDialog();
                }
                else if (userLogin.Count > 0 && userLogin.FirstOrDefault().IsAdmin == false)
                {
                    UserInformationManager userInformationManager = new UserInformationManager();

                    //MessageBox.Show($"Welcome back {userInformationManager.Search(x => x.UserId == userLogin.FirstOrDefault().Id).FirstOrDefault().FirstName}!");

                    UserMain userForm = new UserMain(UserLogedin);
                    this.Hide();
                    userForm.ShowDialog();
                }
                else
                    MessageBox.Show("Hatali");
            }
            else
                MessageBox.Show("Lutfen doldurun");
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}