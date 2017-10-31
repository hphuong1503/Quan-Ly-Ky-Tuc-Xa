using System;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        private string mahd;
        public void setMahd(string mahd)
        {
            this.mahd = mahd;
        }
    
        private void Report_Load_1(object sender, EventArgs e)
        {
            datasetInvxsdTableAdapters.CUSTOMERTableAdapter cus = new datasetInvxsdTableAdapters.CUSTOMERTableAdapter();
            datasetInvxsdTableAdapters.INVOICETableAdapter inv = new datasetInvxsdTableAdapters.INVOICETableAdapter();
            datasetInvxsdTableAdapters.INVOICE_DETAILTableAdapter detail = new datasetInvxsdTableAdapters.INVOICE_DETAILTableAdapter();
            datasetInvxsd a = new datasetInvxsd();
            cus.Fill(a.CUSTOMER);
            inv.Fill(a.INVOICE, mahd);
            detail.Fill(a.INVOICE_DETAIL, mahd);
            repInvoicerpt rep = new repInvoicerpt();
            rep.SetDataSource(a);
            this.cpInvoice.ReportSource = rep;

        }
    }
}
