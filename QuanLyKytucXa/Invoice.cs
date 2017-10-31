using MaterialSkin.Controls;
using QuanLyKytucXa.Class;
using QuanLyKytucXa.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class Invoice : MaterialForm
    {
        public Invoice()
        {
            InitializeComponent();
        }
        private CtrInvoice ctrInv = new CtrInvoice();
        private CtrInvoiceDetail ctrDetail = new CtrInvoiceDetail();

        private void ckbElec_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckbElec.Checked && !"".Equals(txtCusIDInvoice.Text))
            //{
            //    pnElectric.Visible = true;
            //}
            //else
            //{
            //    txtElecNum.Controls.Clear();
            //    pnElectric.Visible = false;
            //}
        }

        private void ckbWater_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbWater.Checked && !"".Equals(txtCusIDInvoice.Text))
            {
                LoadFee("Water");
                txtSum.Text = SumMoney();
            }
        }
        private void ckbVehicle_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVehicle.Checked && !"".Equals(txtCusIDInvoice.Text))
            {
                LoadFee(cbVehicle.Text);
                txtSum.Text = SumMoney();
            }
        }

        private void ckbRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRoom.Checked && !"".Equals(txtCusIDInvoice.Text))
            {
                LoadRoom("Room");
                txtSum.Text = SumMoney();
            }
        }
        private void btnElecEnter_Click(object sender, EventArgs e)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select ServiceID, Name, Price from SERVICE_FEE where ServiceID=@serID ";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@serID", SqlDbType.VarChar).Value = "Elec";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int price = reader.GetInt32(2) * Convert.ToInt32(txtElecNum.Text);
                dgvSerFee.Rows.Add(reader.GetString(0), reader.GetString(1), price);
            }
            reader.Close();

            txtSum.Text = SumMoney();
        }

        private void btnChooseCus_Click(object sender, EventArgs e)
        {
            try
            {
                Functions.checkOpen();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from CUSTOMER where CustomerID=@cusID";
                command.Connection = Functions.sqlConnection;
                command.Parameters.Add("@cusID", SqlDbType.VarChar).Value = txtCustomerId.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string cusID = reader.GetString(0);
                    string name = reader.GetString(1);
                    bool sex = reader.GetBoolean(2);
                    string add = reader.GetString(3);
                    string phone = reader.GetString(4);
                    string room = reader.GetString(5);
                    string vehicle = reader.GetString(6);
                    txtCustomerId.Text = cusID;
                    txtName.Text = name;
                    txtPhone.Text = phone;
                    txtAddress.Text = add;
                    cbVehicle.Text = vehicle;
                    txtRoom.Text = room;
                    createID();
                    if (sex == true)
                    {
                        rdbMale.Select();
                    }
                    else
                        rdbFemale.Select();
                }
                else
                {
                    MessageBox.Show("Khach hang khong ton tai");
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtName.Text = "";
                    cbVehicle.Text = "";
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Khach hang khong ton tai");
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtName.Text = "";
                cbVehicle.Text = "";
            }
        }

        private void createID()
        {
            string s;
            s = DateTime.Now.ToString("yyMMddhhmmss");
            txtInvoiceID.Text = s;
        }

        private void LoadFee(string id)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select ServiceID, Name, Price from SERVICE_FEE where ServiceID=@serID ";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@serID", SqlDbType.VarChar).Value = id;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                dgvSerFee.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
            }
            reader.Close();
        }

        //return room fee
        private int returnRoomFee(string roomId)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select Price from Room where RoomID=@ID ";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = roomId;
            SqlDataReader reader = command.ExecuteReader();
            int price = 0;
            if (reader.Read())
            {
                price = reader.GetInt32(0);
            }
            reader.Close();

            return price;
        }

        //count room mate
        private int countRoommate(string roomId)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(CustomerID) from CUSTOMER where RoomID=@roomID group by  RoomID ";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomId;
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            if (reader.Read())
            {
                count = reader.GetInt32(0);
            }
            reader.Close();
            return count;
        }

        private void LoadRoom(string id)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select ServiceID, Name, Price from SERVICE_FEE where ServiceID=@serID ";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@serID", SqlDbType.VarChar).Value = id;
            int price = returnRoomFee(txtRoom.Text) / countRoommate(txtRoom.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                dgvSerFee.Rows.Add(reader.GetString(0), reader.GetString(1), price);
            }
            reader.Close();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            cbMonth.Text = Convert.ToString(month);
            cbYear.Text = DateTime.Now.ToString("yyyy");
        }

        private void dgvSerFeee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSerFee.CurrentCell.ColumnIndex == 3)
            {
                if (dgvSerFee.CurrentCell.RowIndex == -1)
                {
                    MessageBox.Show("Thím chưa chọn làm sao mà xóa...");
                    return;
                }
                dgvSerFee.Rows.RemoveAt(this.dgvSerFee.CurrentRow.Index);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtInvoiceID.Text) || "".Equals(txtCusIDInvoice.Text) || "".Equals(cbMonth.Text) || "".Equals(cbYear.Text))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            //// tao invoice
            List<int> num = new List<int>();
            List<string> text = new List<string>();
            text.Add(txtInvoiceID.Text);
            text.Add(txtCustomerId.Text);
            text.Add(txtDescription.Text);
            num.Add(Convert.ToInt32(cbMonth.Text));
            num.Add(Convert.ToInt32(cbYear.Text));
            num.Add(payment());
            if (ctrInv.addInvoice(text, num))
            {

                foreach (DataGridViewRow row in dgvSerFee.Rows)
                {
                    ctrDetail.addInvoiceDetail(txtInvoiceID.Text, (string)row.Cells[0].Value, Convert.ToInt32(row.Cells[2].Value));
                }
                MessageBox.Show("Success");
            }
            else
                MessageBox.Show("Fail");
            // them vao invoice datail

        }



        // Cal Sum of money
        private string SumMoney()
        {
            double s = 0;
            foreach (DataGridViewRow row in dgvSerFee.Rows)
            {
                s += Convert.ToInt32(row.Cells[2].Value);
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string a = s.ToString("#,###", cul.NumberFormat);
            return a;
        }
        private int payment()
        {
            int s = 0;
            foreach (DataGridViewRow row in dgvSerFee.Rows)
            {
                s += Convert.ToInt32(row.Cells[2].Value);
            }
            return s;
        }

        private void txtElecNum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmInvoiceHis frmInvHis = new frmInvoiceHis();
            frmInvHis.Show();
        }

        private void txtCustomerId_KeyUp(object sender, KeyEventArgs e)
        {
            txtCusIDInvoice.Text = txtCustomerId.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report a = new Report();
            a.setMahd(txtInvoiceID.Text);
            a.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvSerFee.Rows.Clear();
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
