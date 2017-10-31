using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using QuanLyKytucXa.Controller;
namespace QuanLyKytucXa
{
    public partial class Room : MaterialForm
    {
        public Room()
        {
            InitializeComponent();
        }
        private CtrRoom ctrRoom = new CtrRoom();

        private void Room_Load(object sender, EventArgs e)
        {
            cbRoomStatus.Text = "Phòng Trống";
            txtPrice.Text = "0";
            ctrRoom.showRoom(dgvRoom);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete Room: " + (string)dgvRoom.CurrentRow.Cells[0].Value, "Delete Room", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string roomID = txtRoomID.Text;
                if (ctrRoom.deleteRoom(roomID))
                    ctrRoom.showRoom(dgvRoom);
                else
                    MessageBox.Show("Delete Fail");
            }
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //infor
                txtRoomID.Text = (string)dgvRoom.CurrentRow.Cells[0].Value;
                cbRoomStatus.Text = (string)dgvRoom.CurrentRow.Cells[1].Value;
                txtPrice.Text = "" + dgvRoom.CurrentRow.Cells[2].Value;
                //customer
                ctrRoom.showRoomCustomer(dgvCustomer, dgvRoom);
            }
            catch (Exception) { }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ctrRoom.showRoom(dgvRoom);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ("".Equals(cbSearchStt.Text))
            {
                ctrRoom.showRoom(dgvRoom);
            }
            else
            {
                ctrRoom.showRoom(dgvRoom, "where StatusRoom = @status",cbSearchStt.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtRoomID.Text))
            {
                MessageBox.Show("Invalid");
                return;
            }

            if (ctrRoom.addRoom(txtRoomID.Text, txtPrice.Text, cbRoomStatus.Text))
            {
                ctrRoom.showRoom(dgvRoom);
                
            }
            else
            {
                MessageBox.Show("Add Room Fail");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if ("".Equals(txtRoomID.Text))
            {
                MessageBox.Show("Invalid");
                return;
            }

            try
            {
                string roomId = txtRoomID.Text;
                string status = cbRoomStatus.Text;
                int price = 0;
                if ("".Equals(txtPrice.Text))
                    price = 0;
                else
                    price = Convert.ToInt32(txtPrice.Text);
                if (ctrRoom.updateRoom(roomId, price, status))
                    ctrRoom.showRoom(dgvRoom);
                else
                {
                    MessageBox.Show("Update Fail");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Update Fail");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRoomID.Text = "";
            cbRoomStatus.Text = "";
            txtPrice.Text = "";
        }
        
        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvRoom.CurrentCell.RowIndex == -1)
                {
                    MessageBox.Show("Choose again");
                    return;
                }
                if (dgvRoom.CurrentCell.ColumnIndex == 3)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete Room: " + (string)dgvRoom.CurrentRow.Cells[0].Value, "Delete Room", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string roomID = (string)dgvRoom.CurrentRow.Cells[0].Value;
                        if (ctrRoom.deleteRoom(roomID))
                            ctrRoom.showRoom(dgvRoom);
                        else
                            MessageBox.Show("Delete Fail");
                    }
                }

            }
            catch (Exception)
            {

            }

        }

        private void txtRoomID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRoomID_Click(object sender, EventArgs e)
        {
            txtRoomID.Text = "";
        }
    }
}
