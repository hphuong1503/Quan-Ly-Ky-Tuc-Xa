using System;
using System.Windows.Forms;
using QuanLyKytucXa.Controller;
using System.Collections.Generic;

namespace QuanLyKytucXa
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private CtrCustomer ctrCustomer = new CtrCustomer();
        private CtrRoom ctrRoom = new CtrRoom();

        // this funtion to load room id for cbRoom Id and RoomID search
        public void load()
        {
            ctrCustomer.showCustomer(dgvCustomer);
            ctrRoom.loadRoomID(cbRoomID);
            ctrRoom.loadRoomID(cbRoomSearch);
        }

        public void Customer_Load(object sender, EventArgs e)
        {
            load();
            ctrCustomer.showCustomer(dgvCustomer);
            cbVehicle.Text = "None";
            rdbMale.Checked = true;
        }

        //this funtion to return sex when customer chose radiobutton
        public bool returnSex()
        {
            if (rdbFemale.Checked) return false;
            return true;
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtCustomerId.Text) || "".Equals(txtName.Text))
            {
                MessageBox.Show("Invalid Input");
                return;
            }
            List<string> cus = new List<string>();
            cus.Add(txtCustomerId.Text);
            cus.Add(txtName.Text);
            cus.Add(txtAddress.Text);
            cus.Add(txtPhone.Text);
            cus.Add(cbRoomID.Text);
            cus.Add(cbVehicle.Text);
            bool sex = returnSex();
            if (ctrCustomer.addCustomer(cus, sex))
                ctrCustomer.showCustomer(dgvCustomer);
            else
                MessageBox.Show("Add fail");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtAddress.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            cbRoomID.Text = "";
        }

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCustomer.CurrentCell.RowIndex == -1)
                {
                    MessageBox.Show("Choose Again");
                    return;
                }
                if (dgvCustomer.CurrentCell.ColumnIndex == 7)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete Customer: " + (string)dgvCustomer.CurrentRow.Cells[1].Value, "Delete Customer", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string CustomerId = (string)dgvCustomer.CurrentRow.Cells[0].Value;
                        if (ctrCustomer.deleteCustomer(CustomerId))
                            ctrCustomer.showCustomer(dgvCustomer);
                        else
                            MessageBox.Show("Delete Fail");
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete Customer: " + txtName.Text, "Delete Room", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string CustomerId = txtCustomerId.Text;
                if (ctrCustomer.deleteCustomer(CustomerId))
                    ctrCustomer.showCustomer(dgvCustomer);
                else
                    MessageBox.Show("Delete Fail");
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCustomer.CurrentCell.RowIndex == -1)
                {
                    MessageBox.Show("Choose Again");
                    return;
                }
                txtCustomerId.Text = (string)dgvCustomer.CurrentRow.Cells[0].Value;
                txtName.Text = (string)dgvCustomer.CurrentRow.Cells[1].Value;
                if ((string)dgvCustomer.CurrentRow.Cells[2].Value == "Nam")
                {
                    rdbMale.Select();
                }
                else
                    rdbFemale.Select();
                txtAddress.Text = (string)dgvCustomer.CurrentRow.Cells[3].Value;
                txtPhone.Text = (string)dgvCustomer.CurrentRow.Cells[4].Value;
                cbRoomID.Text = (string)dgvCustomer.CurrentRow.Cells[5].Value;
                cbVehicle.Text = (string)dgvCustomer.CurrentRow.Cells[6].Value;
            }
            catch (Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtCustomerId.Text) || "".Equals(txtName.Text))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            List<string> cus = new List<string>();
            cus.Add(txtCustomerId.Text);
            cus.Add(txtName.Text);
            cus.Add(txtAddress.Text);
            cus.Add(txtPhone.Text);
            cus.Add(cbRoomID.Text);
            cus.Add(cbVehicle.Text);
            cus.Add((string)dgvCustomer.CurrentRow.Cells[0].Value);
            bool sex = returnSex();

            if (ctrCustomer.updateCustomer(cus, sex))
                ctrCustomer.showCustomer(dgvCustomer);
            else
            {
                MessageBox.Show("Update fail");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ctrCustomer.showCustomer(dgvCustomer);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtNameSearch.Text) && "".Equals(cbRoomSearch.Text))
            {
                ctrCustomer.showCustomer(dgvCustomer);
            }
            else
            {
                string name = " Name Like @name";
                string room = "RoomID=@roomID";
                // this variable is condition to filter customer
                string search;
                if ("".Equals(txtNameSearch.Text) && !"".Equals(cbRoomSearch.Text))
                {
                    search = room;
                }
                else if (!"".Equals(txtNameSearch.Text) && "".Equals(cbRoomSearch.Text))
                    search = name;
                else
                {
                    search = name + " and " + room;
                }
                ctrCustomer.showCustomer(dgvCustomer, "where "+search, txtNameSearch.Text, cbRoomSearch.Text);
            }
        }
    }


}
