namespace QuanLyKytucXa
{
    partial class ServiceFee
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
            this.pnData = new System.Windows.Forms.Panel();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvSerFee = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbFee = new MaterialSkin.Controls.MaterialLabel();
            this.lbSerID = new MaterialSkin.Controls.MaterialLabel();
            this.lbname = new MaterialSkin.Controls.MaterialLabel();
            this.txtSerID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFee = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnData.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerFee)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.BackColor = System.Drawing.Color.White;
            this.pnData.Controls.Add(this.gbList);
            this.pnData.Controls.Add(this.gbDetail);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(1000, 710);
            this.pnData.TabIndex = 0;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.dgvSerFee);
            this.gbList.Location = new System.Drawing.Point(37, 273);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(699, 403);
            this.gbList.TabIndex = 87;
            this.gbList.TabStop = false;
            this.gbList.Text = "List";
            // 
            // dgvSerFee
            // 
            this.dgvSerFee.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSerFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSerFee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSerFee.BackgroundColor = System.Drawing.Color.White;
            this.dgvSerFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSerFee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSerFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSerFee.ColumnHeadersHeight = 30;
            this.dgvSerFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceID,
            this.colName,
            this.colPrice,
            this.Unit});
            this.dgvSerFee.DoubleBuffered = true;
            this.dgvSerFee.EnableHeadersVisualStyles = false;
            this.dgvSerFee.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSerFee.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.dgvSerFee.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvSerFee.Location = new System.Drawing.Point(16, 31);
            this.dgvSerFee.Name = "dgvSerFee";
            this.dgvSerFee.ReadOnly = true;
            this.dgvSerFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSerFee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvSerFee.RowHeadersVisible = false;
            this.dgvSerFee.RowHeadersWidth = 50;
            this.dgvSerFee.Size = new System.Drawing.Size(624, 316);
            this.dgvSerFee.TabIndex = 81;
            this.dgvSerFee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerFee_CellClick);
            // 
            // colServiceID
            // 
            this.colServiceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colServiceID.FillWeight = 13.19797F;
            this.colServiceID.HeaderText = "ServiceID";
            this.colServiceID.MinimumWidth = 50;
            this.colServiceID.Name = "colServiceID";
            this.colServiceID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.FillWeight = 25.40609F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 300;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.FillWeight = 30F;
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 100;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.panel1);
            this.gbDetail.Location = new System.Drawing.Point(37, 12);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(640, 241);
            this.gbDetail.TabIndex = 86;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lbFee);
            this.panel1.Controls.Add(this.lbSerID);
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Controls.Add(this.txtSerID);
            this.panel1.Controls.Add(this.txtFee);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(16, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 208);
            this.panel1.TabIndex = 85;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(248, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(109, 48);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.Black;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Clear";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = null;
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(363, 138);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(109, 48);
            this.btnReset.TabIndex = 71;
            this.btnReset.Text = "Clear";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.Black;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbFee
            // 
            this.lbFee.Depth = 0;
            this.lbFee.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFee.Location = new System.Drawing.Point(21, 98);
            this.lbFee.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(68, 18);
            this.lbFee.TabIndex = 61;
            this.lbFee.Text = "Fee";
            // 
            // lbSerID
            // 
            this.lbSerID.Depth = 0;
            this.lbSerID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSerID.Location = new System.Drawing.Point(21, 23);
            this.lbSerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSerID.Name = "lbSerID";
            this.lbSerID.Size = new System.Drawing.Size(104, 18);
            this.lbSerID.TabIndex = 61;
            this.lbSerID.Text = "ServiceID :";
            // 
            // lbname
            // 
            this.lbname.Depth = 0;
            this.lbname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbname.Location = new System.Drawing.Point(21, 58);
            this.lbname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(104, 18);
            this.lbname.TabIndex = 61;
            this.lbname.Text = "Name Service:";
            // 
            // txtSerID
            // 
            this.txtSerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerID.Enabled = false;
            this.txtSerID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSerID.HintForeColor = System.Drawing.Color.Empty;
            this.txtSerID.HintText = "";
            this.txtSerID.isPassword = false;
            this.txtSerID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSerID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSerID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSerID.LineThickness = 4;
            this.txtSerID.Location = new System.Drawing.Point(132, 6);
            this.txtSerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerID.Name = "txtSerID";
            this.txtSerID.Size = new System.Drawing.Size(150, 35);
            this.txtSerID.TabIndex = 72;
            this.txtSerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFee
            // 
            this.txtFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFee.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFee.HintForeColor = System.Drawing.Color.Empty;
            this.txtFee.HintText = "";
            this.txtFee.isPassword = false;
            this.txtFee.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFee.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFee.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFee.LineThickness = 4;
            this.txtFee.Location = new System.Drawing.Point(132, 81);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(150, 35);
            this.txtFee.TabIndex = 72;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFee_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 4;
            this.txtName.Location = new System.Drawing.Point(132, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 35);
            this.txtName.TabIndex = 72;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ServiceFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 710);
            this.Controls.Add(this.pnData);
            this.Name = "ServiceFee";
            this.Text = "ServiceFee";
            this.Load += new System.EventHandler(this.ServiceFee_Load);
            this.pnData.ResumeLayout(false);
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerFee)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnData;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSerFee;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private MaterialSkin.Controls.MaterialLabel lbFee;
        private MaterialSkin.Controls.MaterialLabel lbname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFee;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private MaterialSkin.Controls.MaterialLabel lbSerID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSerID;
    }
}