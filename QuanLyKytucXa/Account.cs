using MaterialSkin.Controls;
using QuanLyKytucXa.Class;
using QuanLyKytucXa.Controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class Account : MaterialForm
    {
        public Account()
        {
            InitializeComponent();

        }
        private CtrAccount ctrAcc = new CtrAccount();

        private void Account_Load(object sender, EventArgs e)
        {
            ctrAcc.showAcc(dgvACC);
        }

        private void dgvACC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvACC.CurrentCell.RowIndex == -1)
                {
                    MessageBox.Show("Thím chưa chọn làm sao mà xóa...");
                    return;
                }
                if (dgvACC.CurrentCell.ColumnIndex == 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete Acount: " + (string)dgvACC.CurrentRow.Cells[0].Value, "Delete Account", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (ctrAcc.deleteAcc((string)dgvACC.CurrentRow.Cells[0].Value))
                        {
                            ctrAcc.showAcc(dgvACC);
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fail");
            }
        }

        private void dgvACC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser.Text = (string)dgvACC.CurrentRow.Cells[0].Value;
            txtPass.Text = (string)dgvACC.CurrentRow.Cells[1].Value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length > 2 && txtPass.Text.Length >2 )
            {
                string user = txtUser.Text;
                string pass = txtPass.Text;
                if (ctrAcc.addAcc(user, pass))
                {
                    ctrAcc.showAcc(dgvACC);
                }
                else
                    MessageBox.Show("Fail");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            string sql = "update ACCOUNT set UserName=@user,Password=@pass where  UserName=@user";
            command.CommandText = sql;
            command.Connection = Functions.sqlConnection;

            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (txtPass.Text.Length > 2 && txtPass.Text.Length > 2 && ctrAcc.updateAcc(user, pass))
            {
                ctrAcc.showAcc(dgvACC);
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete Acount: " + user, "Delete Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (ctrAcc.deleteAcc(user))
                {
                    ctrAcc.showAcc(dgvACC);
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }
    }
}
