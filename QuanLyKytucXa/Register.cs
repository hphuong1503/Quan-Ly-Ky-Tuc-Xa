using QuanLyKytucXa.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string typeOfUser = "";
            if (cbAdmin.Checked)
            {
                typeOfUser = "Admin";
            }else if(cbStaff.Checked)
            {
                typeOfUser = "Staff";
            }
            else
            {
                MessageBox.Show("Please choose one of user type ");
            }

            if(txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please fill full on this form");
            }

            if (isDuplicate(txtUsername.Text))
            {
                MessageBox.Show("Username has been duplicated");
            }
            else
            {
                Functions.checkOpen();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql = "Insert into Account(Username,Password,Usertype) " +
                      " values(@username,@password,@typeuser)";
                command.CommandText = sql;
                command.Connection = Functions.sqlConnection;

                command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;
                command.Parameters.Add("@typeuser", SqlDbType.VarChar).Value = typeOfUser;
            }
        }

        private bool isDuplicate(string username)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Account where Username=@username";
            command.Connection = Functions.sqlConnection;

            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

            SqlDataReader reader = command.ExecuteReader();
            string Username = "";
            Username = reader.GetString(1);
            if (Username.Length == 0)
                return false;
            return true;
        }
    }
}
