using QuanLyKytucXa.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using QuanLyKytucXa.Controller;
using System.Collections.Generic;

namespace QuanLyKytucXa
{
    public partial class frmReservationHiscs : Form
    {
        public frmReservationHiscs()
        {
            InitializeComponent();
        }
        private bool isEnd;
        private CtrReservation ctrRes = new CtrReservation();
        private CtrRoom ctrRoom = new CtrRoom();
        public void loadRoomID()
        {
            ctrRoom.loadRoomID(cbRoomSearch);
        }
        private void frmReservationHiscs_Load(object sender, EventArgs e)
        {
            ctrRes.showRes(dgvReservation);
            loadRoomID();
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtbEnd.CustomFormat = "dd/MM/yyyy";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ctrRes.showRes(dgvReservation);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtCusIDSearch.Text) && "".Equals(cbRoomSearch.Text))
            {
                ctrRes.showRes(dgvReservation);
            }
            else
            {
                string id = "CustomerID=@id";
                string room = "RoomID=@roomID";
                string search;
                if ("".Equals(txtCusIDSearch.Text) && !"".Equals(cbRoomSearch.Text))
                {
                    search = room;
                }
                else if (!"".Equals(txtCusIDSearch.Text) && "".Equals(cbRoomSearch.Text))
                    search = id;
                else
                {
                    search = id + " and " + room;
                }
                Functions.checkOpen();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from RESERVATION where " + search;
                command.Connection = Functions.sqlConnection;
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = txtCusIDSearch.Text;
                command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = cbRoomSearch.Text;

                SqlDataReader reader = command.ExecuteReader();
                dgvReservation.Rows.Clear();
                while (reader.Read())
                {
                    string get5;
                    if (!reader.IsDBNull(5))
                        get5 = reader.GetDateTime(5).ToString("dd/MM/yyyy");
                    else get5 = "";

                    dgvReservation.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                         reader.GetString(3), reader.GetDateTime(4).ToString("dd/MM/yyyy"), get5);
                }
                reader.Close();
            }
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvReservation.CurrentCell.RowIndex == -1)
                {
                    MessageBox.Show("Choose Again");
                    return;
                }
                if (dgvReservation.CurrentCell.ColumnIndex == 6)
                {
                    string resID = (string)dgvReservation.CurrentRow.Cells[0].Value;

                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete Reservation: " + resID, "Delete Reservation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (ctrRes.deleteRes(resID))
                        {
                            ctrRes.showRes(dgvReservation);
                        }
                        else
                        {
                            MessageBox.Show("Can not Delete");
                        }
                    }

                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtResID.Text = (string)dgvReservation.CurrentRow.Cells[0].Value;
            txtCusRes.Text = (string)dgvReservation.CurrentRow.Cells[1].Value;
            txtRoomID.Text = (string)dgvReservation.CurrentRow.Cells[2].Value;
            cbRentType.Text = (string)dgvReservation.CurrentRow.Cells[3].Value;
            string start = (string)dgvReservation.CurrentRow.Cells[4].Value;

            DateTime dt = DateTime.ParseExact(start, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            dtpStartDate.Value = dt;
            string end = Convert.ToString(dgvReservation.CurrentRow.Cells[5].Value);

            //dt = Convert.ToDateTime(end);
            if ("".Equals(end))
            {
                pnEnd.Visible = false;
                isEnd = false;
                btnEndAdd.Visible = true;
                btnMinus.Visible = false;
            }
            else
            {
                pnEnd.Visible = true;
                dt = DateTime.ParseExact(end, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                isEnd = true;
                dtbEnd.Value = dt;
                btnEndAdd.Visible = false;
                btnMinus.Visible = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string resID = txtResID.Text;

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete Reservation: " + resID, "Delete Reservation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (ctrRes.deleteRes(resID))
                {
                    ctrRes.showRes(dgvReservation);
                }
                else
                {
                    MessageBox.Show("Can not Delete");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if ("".Equals(txtCusRes.Text) || "".Equals(txtResID.Text) || "".Equals(txtRoomID.Text) || "".Equals(cbRentType.Text))
            {
                MessageBox.Show("Invalid input");
                return;
            }

            List<string> res = new List<string>();
            res.Add(txtResID.Text);
            res.Add(txtCusRes.Text);
            res.Add(txtRoomID.Text);
            res.Add(cbRentType.Text);
            DateTime start = dtpStartDate.Value;
            DateTime end = new DateTime(3000, 1, 1);
            if (isEnd)
                end = dtbEnd.Value;
            if (end.CompareTo(dtpStartDate.Value) < 1)
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            if (ctrRes.updateReservation(res, start, isEnd, end))
                ctrRes.showRes(dgvReservation);
            else
                MessageBox.Show("Can't not update Reservation");


        }

        private void btnEndAdd_Click(object sender, EventArgs e)
        {
            pnEnd.Visible = true;
            isEnd = true;
            btnEndAdd.Visible = false;
            btnMinus.Visible = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            isEnd = false;
            btnEndAdd.Visible = true;
            btnMinus.Visible = false;
            pnEnd.Visible = false;
        }
    }
}
