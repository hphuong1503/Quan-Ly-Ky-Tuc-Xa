using MaterialSkin.Controls;
using QuanLyKytucXa.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyKytucXa.Controller;
using System.Collections.Generic;

namespace QuanLyKytucXa
{
    public partial class Reservation : MaterialForm
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private CtrRoom ctrRoom = new CtrRoom();
        private CtrReservation ctrRes = new CtrReservation();
        private bool isEnd;

        private void Reservation_Load(object sender, EventArgs e)
        {
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtbEnd.CustomFormat = "dd/MM/yyyy";
            cbRentType.Text = "Ở ghép";
            dtpStartDate.Value = DateTime.Now;
            dtbEnd.Value = DateTime.Now;
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
                    string vehicle = reader.GetString(6);
                    txtCustomerId.Text = cusID;
                    txtName.Text = name;
                    txtPhone.Text = phone;
                    txtAddress.Text = add;
                    cbVehicle.Text = vehicle;
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
            s = DateTime.Now.ToString("MMddss");
            txtResID.Text = txtRoomID.Text + s + txtCustomerId.Text;
        }
        private void btnChooseRoom_Click(object sender, EventArgs e)
        {

            ctrRoom.showRoom(dgvRoom);
            txtResRoom.Text = txtRoomID.Text;
        }
        private bool isRightDate()
        {
            if (dtbEnd.Text == "") return true;
            if (dtbEnd.Value.CompareTo(dtpStartDate.Value) < 1)
                return false;
            return true;
        }
       
        private void btnCreate_Click(object sender, EventArgs e)
        {

            if ("".Equals(txtCusRes.Text) || "".Equals(txtResID.Text) || "".Equals(txtRoomID.Text) || "".Equals(cbRentType.Text))
            {
                MessageBox.Show("Invalid input");
                return;
            }

            // kiem tra phong con trong
            if (ctrRoom.RoomisFull(txtResRoom.Text))
            {
                MessageBox.Show("Room is full");
            }
            else
            {
                
                List<string> res = new List<string>();
                res.Add(txtResID.Text);
                res.Add(txtCusRes.Text);
                res.Add(txtResRoom.Text);
                res.Add(cbRentType.Text);
                DateTime start = dtpStartDate.Value;
                DateTime end = dtpStartDate.Value;
                if (isEnd)
                    end = dtbEnd.Value;
                if (!isRightDate())
                {
                    MessageBox.Show("Invalid Date");
                    return;
                }
                   
                if (ctrRes.addReservation(res, start, isEnd, end))
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Can't not create Reservation");
                
            }
        }

        private void btnEndAdd_Click(object sender, EventArgs e)
        {
            pnEnd.Visible = true;
            isEnd = true;
            btnEndAdd.Visible = false;
            btnMinus.Visible = true;
        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            frmReservationHiscs resHis = new frmReservationHiscs();
            resHis.Visible = true;
        }

        private void btnCreateID_Click(object sender, EventArgs e)
        {
            createID();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            isEnd = false;
            btnEndAdd.Visible = true;
            btnMinus.Visible = false;
            pnEnd.Visible = false;
        }

        private void txtCustomerId_KeyUp(object sender, KeyEventArgs e)
        {
            txtCusRes.Text = txtCustomerId.Text;
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtResRoom.Text= txtRoomID.Text = (string)dgvRoom.CurrentRow.Cells[0].Value;
        }
        
    }
}
