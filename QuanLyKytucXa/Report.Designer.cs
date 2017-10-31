namespace QuanLyKytucXa
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cpInvoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cpInvoice
            // 
            this.cpInvoice.ActiveViewIndex = -1;
            this.cpInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpInvoice.Location = new System.Drawing.Point(0, 0);
            this.cpInvoice.Name = "cpInvoice";
            this.cpInvoice.Size = new System.Drawing.Size(934, 711);
            this.cpInvoice.TabIndex = 0;
            // 
            // Report
            // 
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.cpInvoice);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Report_Load_1);
            this.ResumeLayout(false);

        }


        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cpInvoice;
    }
}