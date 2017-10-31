using MaterialSkin.Controls;
using QuanLyKytucXa.Class;
using QuanLyKytucXa.Controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class ServiceFee : MaterialForm
    {
        public ServiceFee()
        {
            InitializeComponent(); 
        }
        CtrServiceFee ctrSer = new CtrServiceFee();
        private void ServiceFee_Load(object sender, EventArgs e)
        {
            ctrSer.showServiceFee(dgvSerFee);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string serID= txtSerID.Text;
            int price = 0;
            try
            {
                 price = Convert.ToInt32(txtFee.Text);
                if (ctrSer.updateServiceFee(serID, price))
                {
                    ctrSer.showServiceFee(dgvSerFee);
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            catch (Exception) { MessageBox.Show("Fail"); }
           
        }

        private void dgvSerFee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSerID.Text = (string)dgvSerFee.CurrentRow.Cells[0].Value;
            txtName.Text = (string)dgvSerFee.CurrentRow.Cells[1].Value;
            txtFee.Text = (string)dgvSerFee.CurrentRow.Cells[2].Value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFee.Text = "";
            txtName.Text = "";
            txtSerID.Text = "";
        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
