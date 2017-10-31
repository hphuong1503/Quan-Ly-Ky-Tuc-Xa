namespace QuanLyKytucXa
{
    partial class frmInvoiceHis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceHis));
            this.pnData = new System.Windows.Forms.Panel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtCustomerId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbCustomer = new MaterialSkin.Controls.MaterialLabel();
            this.btnShowAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gbInvoiceDetail = new System.Windows.Forms.GroupBox();
            this.dgvInvoiceDetail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbInvoice = new System.Windows.Forms.GroupBox();
            this.dgvInvoice = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnData.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbInvoiceDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).BeginInit();
            this.gbInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.BackColor = System.Drawing.Color.White;
            this.pnData.Controls.Add(this.gbSearch);
            this.pnData.Controls.Add(this.gbInvoiceDetail);
            this.pnData.Controls.Add(this.gbInvoice);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(1029, 718);
            this.pnData.TabIndex = 0;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtCustomerId);
            this.gbSearch.Controls.Add(this.lbCustomer);
            this.gbSearch.Controls.Add(this.btnShowAll);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(993, 74);
            this.gbSearch.TabIndex = 84;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCustomerId.HintForeColor = System.Drawing.Color.Empty;
            this.txtCustomerId.HintText = "";
            this.txtCustomerId.isPassword = false;
            this.txtCustomerId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCustomerId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCustomerId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCustomerId.LineThickness = 4;
            this.txtCustomerId.Location = new System.Drawing.Point(132, 23);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(150, 35);
            this.txtCustomerId.TabIndex = 97;
            this.txtCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbCustomer
            // 
            this.lbCustomer.Depth = 0;
            this.lbCustomer.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCustomer.Location = new System.Drawing.Point(21, 40);
            this.lbCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(104, 18);
            this.lbCustomer.TabIndex = 96;
            this.lbCustomer.Text = "CustomerID:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAll.BorderRadius = 0;
            this.btnShowAll.ButtonText = "Show All";
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowAll.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowAll.Iconimage = null;
            this.btnShowAll.Iconimage_right = null;
            this.btnShowAll.Iconimage_right_Selected = null;
            this.btnShowAll.Iconimage_Selected = null;
            this.btnShowAll.IconMarginLeft = 0;
            this.btnShowAll.IconMarginRight = 0;
            this.btnShowAll.IconRightVisible = true;
            this.btnShowAll.IconRightZoom = 0D;
            this.btnShowAll.IconVisible = true;
            this.btnShowAll.IconZoom = 90D;
            this.btnShowAll.IsTab = false;
            this.btnShowAll.Location = new System.Drawing.Point(454, 23);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnShowAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnShowAll.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnShowAll.selected = false;
            this.btnShowAll.Size = new System.Drawing.Size(107, 48);
            this.btnShowAll.TabIndex = 70;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowAll.Textcolor = System.Drawing.Color.Black;
            this.btnShowAll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(320, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(107, 48);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.Black;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbInvoiceDetail
            // 
            this.gbInvoiceDetail.Controls.Add(this.dgvInvoiceDetail);
            this.gbInvoiceDetail.Location = new System.Drawing.Point(12, 436);
            this.gbInvoiceDetail.Name = "gbInvoiceDetail";
            this.gbInvoiceDetail.Size = new System.Drawing.Size(716, 270);
            this.gbInvoiceDetail.TabIndex = 83;
            this.gbInvoiceDetail.TabStop = false;
            this.gbInvoiceDetail.Text = "Invoice Detail";
            // 
            // dgvInvoiceDetail
            // 
            this.dgvInvoiceDetail.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInvoiceDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoiceDetail.ColumnHeadersHeight = 30;
            this.dgvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn2});
            this.dgvInvoiceDetail.DoubleBuffered = true;
            this.dgvInvoiceDetail.EnableHeadersVisualStyles = false;
            this.dgvInvoiceDetail.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvInvoiceDetail.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.dgvInvoiceDetail.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvInvoiceDetail.Location = new System.Drawing.Point(13, 19);
            this.dgvInvoiceDetail.Name = "dgvInvoiceDetail";
            this.dgvInvoiceDetail.ReadOnly = true;
            this.dgvInvoiceDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInvoiceDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvInvoiceDetail.RowHeadersVisible = false;
            this.dgvInvoiceDetail.RowHeadersWidth = 50;
            this.dgvInvoiceDetail.Size = new System.Drawing.Size(651, 224);
            this.dgvInvoiceDetail.TabIndex = 82;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 13.19797F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ServiceID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 25.40609F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 300;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 30F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.FillWeight = 13.19797F;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::QuanLyKytucXa.Properties.Resources.rubbish_bin;
            this.dataGridViewImageColumn2.MinimumWidth = 35;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gbInvoice
            // 
            this.gbInvoice.Controls.Add(this.dgvInvoice);
            this.gbInvoice.Location = new System.Drawing.Point(12, 91);
            this.gbInvoice.Name = "gbInvoice";
            this.gbInvoice.Size = new System.Drawing.Size(993, 339);
            this.gbInvoice.TabIndex = 82;
            this.gbInvoice.TabStop = false;
            this.gbInvoice.Text = "Invoice";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInvoice.ColumnHeadersHeight = 30;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceID,
            this.CustomerID,
            this.Month,
            this.Year,
            this.Payment,
            this.Description,
            this.colEdit,
            this.colDelete});
            this.dgvInvoice.DoubleBuffered = true;
            this.dgvInvoice.EnableHeadersVisualStyles = false;
            this.dgvInvoice.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvInvoice.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.dgvInvoice.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvInvoice.Location = new System.Drawing.Point(13, 35);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvInvoice.RowHeadersVisible = false;
            this.dgvInvoice.RowHeadersWidth = 50;
            this.dgvInvoice.Size = new System.Drawing.Size(943, 282);
            this.dgvInvoice.TabIndex = 82;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            // 
            // colServiceID
            // 
            this.colServiceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colServiceID.FillWeight = 13.19797F;
            this.colServiceID.HeaderText = "InvoiceID";
            this.colServiceID.MinimumWidth = 70;
            this.colServiceID.Name = "colServiceID";
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEdit.FillWeight = 13.19797F;
            this.colEdit.HeaderText = "Update";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.MinimumWidth = 35;
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDelete.FillWeight = 13.19797F;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Image = global::QuanLyKytucXa.Properties.Resources.rubbish_bin;
            this.colDelete.MinimumWidth = 35;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmInvoiceHis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 718);
            this.Controls.Add(this.pnData);
            this.Name = "frmInvoiceHis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Manager";
            this.Load += new System.EventHandler(this.frmInvoiceHis_Load);
            this.pnData.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbInvoiceDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).EndInit();
            this.gbInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.GroupBox gbInvoiceDetail;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInvoiceDetail;
        private System.Windows.Forms.GroupBox gbInvoice;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInvoice;
        private System.Windows.Forms.GroupBox gbSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowAll;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustomerId;
        private MaterialSkin.Controls.MaterialLabel lbCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}