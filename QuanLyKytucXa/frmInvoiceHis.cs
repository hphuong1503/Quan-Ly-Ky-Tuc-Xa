using QuanLyKytucXa.Class;
using QuanLyKytucXa.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class frmInvoiceHis : Form
    {
        public frmInvoiceHis()
        {
            InitializeComponent();
        }
        private CtrInvoice ctrInv = new CtrInvoice();
        private CtrInvoiceDetail ctrInvDetail = new CtrInvoiceDetail();
        private void frmInvoiceHis_Load(object sender, EventArgs e)
        {
            ctrInv.showInvoice(dgvInvoice);
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string invoiceID = (string)dgvInvoice.CurrentRow.Cells[0].Value;
            ctrInvDetail.showInvoiceDetail(dgvInvoiceDetail, invoiceID);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ctrInv.showInvoice(dgvInvoice);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtCustomerId.Text))
            {
                ctrInv.showInvoice(dgvInvoice);
            }
            else
            {
                ctrInv.showInvoice(dgvInvoice, " where CustomerID = @cusID", txtCustomerId.Text);
            }
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Functions.checkOpen();
            if (dgvInvoice.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Choose Again");
                return;
            }
            if (dgvInvoice.CurrentCell.ColumnIndex == 7)
            {
                string invoiceID = (string)dgvInvoice.CurrentRow.Cells[0].Value;
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete Invoice: " + invoiceID, "Delete Invoice", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    if (ctrInv.deleteInvoice(invoiceID))
                    {
                        dgvInvoiceDetail.Rows.Clear();
                        ctrInv.showInvoice(dgvInvoice);
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
            }

            else if (dgvInvoice.CurrentCell.ColumnIndex == 6)
            {
                List<int> num = new List<int>();
                List<string> text = new List<string>();
                text.Add((string)dgvInvoice.CurrentRow.Cells[0].Value);
                text.Add((string)dgvInvoice.CurrentRow.Cells[1].Value);
                text.Add((string)dgvInvoice.CurrentRow.Cells[5].Value);
                num.Add(Convert.ToInt32(dgvInvoice.CurrentRow.Cells[2].Value));
                num.Add(Convert.ToInt32(dgvInvoice.CurrentRow.Cells[3].Value));
                num.Add(Convert.ToInt32(dgvInvoice.CurrentRow.Cells[4].Value));
                if (ctrInv.updateInvoice(text, num))
                {
                    ctrInv.showInvoice(dgvInvoice);
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report a = new Report();
            //MessageBox.Show((string)dgvInvoice.CurrentRow.Cells[0].Value);
            a.setMahd((string)dgvInvoice.CurrentRow.Cells[0].Value);
            a.Show();
        }
    }

}
