using MaterialSkin.Controls;
using QuanLyKytucXa.Class;
using System;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (Functions.checkLogin(user, pass))
            {
                this.Hide();
            }
            else
            {
                txtPass.Text = "";
                txtUser.Text = "";
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
