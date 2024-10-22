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
    public partial class UserMain : Form
    {
        int userLogedin;
       
        public UserMain(int userModel)
        {
            userLogedin = userModel;
            
            InitializeComponent();
            OpenForm(new UserFoodEnterUI(userLogedin));
        }
        void OpenForm(Form ShowForm)
        {

            ShowForm.StartPosition = 0;

            if (!MdiChildren.Contains(ShowForm))
                ShowForm.MdiParent = this;

            foreach (var form in MdiChildren)
            {
                if (form.Text == ShowForm.Text)
                    form.Show();
                else
                    form.Close();
            }
        }


        private void foodEnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new UserFoodEnterUI(userLogedin));
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new UserReportUI(userLogedin));
        }
    }
}
