namespace QuanLyKytucXa
{
    partial class frmReservationHiscs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReservation = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lbSearchCusID = new MaterialSkin.Controls.MaterialLabel();
            this.txtCusIDSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnShowAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbRoomSearch = new System.Windows.Forms.ComboBox();
            this.lbSearchRoomID = new MaterialSkin.Controls.MaterialLabel();
            this.fbDetail = new System.Windows.Forms.GroupBox();
            this.btnEndAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbResRoom = new MaterialSkin.Controls.MaterialLabel();
            this.txtRoomID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnEnd = new System.Windows.Forms.Panel();
            this.lbEnddate = new MaterialSkin.Controls.MaterialLabel();
            this.dtbEnd = new System.Windows.Forms.DateTimePicker();
            this.pnDayStart = new System.Windows.Forms.Panel();
            this.lbStartDay = new MaterialSkin.Controls.MaterialLabel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbRentType = new System.Windows.Forms.ComboBox();
            this.lbReservationID = new MaterialSkin.Controls.MaterialLabel();
            this.lbRentType = new MaterialSkin.Controls.MaterialLabel();
            this.txtResID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCusRes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.gbList.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.fbDetail.SuspendLayout();
            this.pnEnd.SuspendLayout();
            this.pnDayStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservation.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReservation.ColumnHeadersHeight = 30;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCustomerID,
            this.colRoom,
            this.RenType,
            this.StartDate,
            this.EndDate,
            this.Delete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservation.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReservation.DoubleBuffered = true;
            this.dgvReservation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvReservation.EnableHeadersVisualStyles = false;
            this.dgvReservation.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReservation.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.dgvReservation.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvReservation.Location = new System.Drawing.Point(6, 19);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReservation.RowHeadersVisible = false;
            this.dgvReservation.RowHeadersWidth = 50;
            this.dgvReservation.Size = new System.Drawing.Size(1014, 383);
            this.dgvReservation.TabIndex = 19;
            this.dgvReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellClick);
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
            // 
            // colName
            // 
            this.colName.FillWeight = 15F;
            this.colName.HeaderText = "ReservationID";
            this.colName.MinimumWidth = 80;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCustomerID
            // 
            this.colCustomerID.FillWeight = 5F;
            this.colCustomerID.HeaderText = "CustomerID";
            this.colCustomerID.MinimumWidth = 80;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.ReadOnly = true;
            // 
            // colRoom
            // 
            this.colRoom.FillWeight = 5F;
            this.colRoom.HeaderText = "RoomID";
            this.colRoom.MinimumWidth = 70;
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            // 
            // RenType
            // 
            this.RenType.HeaderText = "RentType";
            this.RenType.MinimumWidth = 150;
            this.RenType.Name = "RenType";
            this.RenType.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.MinimumWidth = 150;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.MinimumWidth = 150;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 5F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::QuanLyKytucXa.Properties.Resources.rubbish_bin;
            this.Delete.MinimumWidth = 50;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.dgvReservation);
            this.gbList.Location = new System.Drawing.Point(12, 221);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(1026, 420);
            this.gbList.TabIndex = 75;
            this.gbList.TabStop = false;
            this.gbList.Text = "List";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lbSearchCusID);
            this.gbSearch.Controls.Add(this.txtCusIDSearch);
            this.gbSearch.Controls.Add(this.btnShowAll);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cbRoomSearch);
            this.gbSearch.Controls.Add(this.lbSearchRoomID);
            this.gbSearch.Location = new System.Drawing.Point(12, 141);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(1026, 74);
            this.gbSearch.TabIndex = 77;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // lbSearchCusID
            // 
            this.lbSearchCusID.Depth = 0;
            this.lbSearchCusID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSearchCusID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSearchCusID.Location = new System.Drawing.Point(9, 34);
            this.lbSearchCusID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSearchCusID.Name = "lbSearchCusID";
            this.lbSearchCusID.Size = new System.Drawing.Size(97, 25);
            this.lbSearchCusID.TabIndex = 75;
            this.lbSearchCusID.Text = "Customer ID:";
            // 
            // txtCusIDSearch
            // 
            this.txtCusIDSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusIDSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusIDSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCusIDSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtCusIDSearch.HintText = "";
            this.txtCusIDSearch.isPassword = false;
            this.txtCusIDSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCusIDSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCusIDSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCusIDSearch.LineThickness = 4;
            this.txtCusIDSearch.Location = new System.Drawing.Point(138, 12);
            this.txtCusIDSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusIDSearch.Name = "txtCusIDSearch";
            this.txtCusIDSearch.Size = new System.Drawing.Size(149, 40);
            this.txtCusIDSearch.TabIndex = 76;
            this.txtCusIDSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnShowAll.Location = new System.Drawing.Point(701, 19);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnShowAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnShowAll.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnShowAll.selected = false;
            this.btnShowAll.Size = new System.Drawing.Size(100, 40);
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
            this.btnSearch.Location = new System.Drawing.Point(570, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.Black;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbRoomSearch
            // 
            this.cbRoomSearch.BackColor = System.Drawing.Color.White;
            this.cbRoomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomSearch.Location = new System.Drawing.Point(385, 27);
            this.cbRoomSearch.MaxLength = 10;
            this.cbRoomSearch.Name = "cbRoomSearch";
            this.cbRoomSearch.Size = new System.Drawing.Size(150, 32);
            this.cbRoomSearch.Sorted = true;
            this.cbRoomSearch.TabIndex = 55;
            // 
            // lbSearchRoomID
            // 
            this.lbSearchRoomID.Depth = 0;
            this.lbSearchRoomID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSearchRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSearchRoomID.Location = new System.Drawing.Point(305, 34);
            this.lbSearchRoomID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSearchRoomID.Name = "lbSearchRoomID";
            this.lbSearchRoomID.Size = new System.Drawing.Size(68, 18);
            this.lbSearchRoomID.TabIndex = 61;
            this.lbSearchRoomID.Text = "Room :";
            // 
            // fbDetail
            // 
            this.fbDetail.Controls.Add(this.btnEndAdd);
            this.fbDetail.Controls.Add(this.btnMinus);
            this.fbDetail.Controls.Add(this.btnUpdate);
            this.fbDetail.Controls.Add(this.btnDelete);
            this.fbDetail.Controls.Add(this.lbResRoom);
            this.fbDetail.Controls.Add(this.txtRoomID);
            this.fbDetail.Controls.Add(this.pnEnd);
            this.fbDetail.Controls.Add(this.pnDayStart);
            this.fbDetail.Controls.Add(this.cbRentType);
            this.fbDetail.Controls.Add(this.lbReservationID);
            this.fbDetail.Controls.Add(this.lbRentType);
            this.fbDetail.Controls.Add(this.txtResID);
            this.fbDetail.Controls.Add(this.materialLabel7);
            this.fbDetail.Controls.Add(this.txtCusRes);
            this.fbDetail.Location = new System.Drawing.Point(12, 2);
            this.fbDetail.Name = "fbDetail";
            this.fbDetail.Size = new System.Drawing.Size(1039, 133);
            this.fbDetail.TabIndex = 95;
            this.fbDetail.TabStop = false;
            this.fbDetail.Text = "Reservation";
            // 
            // btnEndAdd
            // 
            this.btnEndAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEndAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnEndAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEndAdd.BorderRadius = 0;
            this.btnEndAdd.ButtonText = "+";
            this.btnEndAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnEndAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEndAdd.Iconimage = null;
            this.btnEndAdd.Iconimage_right = null;
            this.btnEndAdd.Iconimage_right_Selected = null;
            this.btnEndAdd.Iconimage_Selected = null;
            this.btnEndAdd.IconMarginLeft = 0;
            this.btnEndAdd.IconMarginRight = 0;
            this.btnEndAdd.IconRightVisible = true;
            this.btnEndAdd.IconRightZoom = 0D;
            this.btnEndAdd.IconVisible = true;
            this.btnEndAdd.IconZoom = 90D;
            this.btnEndAdd.IsTab = false;
            this.btnEndAdd.Location = new System.Drawing.Point(875, 10);
            this.btnEndAdd.Name = "btnEndAdd";
            this.btnEndAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnEndAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnEndAdd.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEndAdd.selected = false;
            this.btnEndAdd.Size = new System.Drawing.Size(30, 30);
            this.btnEndAdd.TabIndex = 100;
            this.btnEndAdd.Text = "+";
            this.btnEndAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEndAdd.Textcolor = System.Drawing.Color.Black;
            this.btnEndAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndAdd.Click += new System.EventHandler(this.btnEndAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinus.BorderRadius = 0;
            this.btnMinus.ButtonText = "-";
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.DisabledColor = System.Drawing.Color.Gray;
            this.btnMinus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMinus.Iconimage = null;
            this.btnMinus.Iconimage_right = null;
            this.btnMinus.Iconimage_right_Selected = null;
            this.btnMinus.Iconimage_Selected = null;
            this.btnMinus.IconMarginLeft = 0;
            this.btnMinus.IconMarginRight = 0;
            this.btnMinus.IconRightVisible = true;
            this.btnMinus.IconRightZoom = 0D;
            this.btnMinus.IconVisible = true;
            this.btnMinus.IconZoom = 90D;
            this.btnMinus.IsTab = false;
            this.btnMinus.Location = new System.Drawing.Point(875, 10);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnMinus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnMinus.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMinus.selected = false;
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 101;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinus.Textcolor = System.Drawing.Color.Black;
            this.btnMinus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(924, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(107, 48);
            this.btnUpdate.TabIndex = 99;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.Black;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(926, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(107, 48);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.Black;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbResRoom
            // 
            this.lbResRoom.Depth = 0;
            this.lbResRoom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbResRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbResRoom.Location = new System.Drawing.Point(305, 38);
            this.lbResRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbResRoom.Name = "lbResRoom";
            this.lbResRoom.Size = new System.Drawing.Size(55, 18);
            this.lbResRoom.TabIndex = 81;
            this.lbResRoom.Text = "Room ID:";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomID.HintForeColor = System.Drawing.Color.Empty;
            this.txtRoomID.HintText = "";
            this.txtRoomID.isPassword = false;
            this.txtRoomID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRoomID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRoomID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRoomID.LineThickness = 4;
            this.txtRoomID.Location = new System.Drawing.Point(385, 23);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(150, 35);
            this.txtRoomID.TabIndex = 82;
            this.txtRoomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnEnd
            // 
            this.pnEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnEnd.Controls.Add(this.lbEnddate);
            this.pnEnd.Controls.Add(this.dtbEnd);
            this.pnEnd.Location = new System.Drawing.Point(710, 33);
            this.pnEnd.Name = "pnEnd";
            this.pnEnd.Size = new System.Drawing.Size(158, 73);
            this.pnEnd.TabIndex = 96;
            this.pnEnd.Visible = false;
            // 
            // lbEnddate
            // 
            this.lbEnddate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEnddate.AutoSize = true;
            this.lbEnddate.Depth = 0;
            this.lbEnddate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbEnddate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbEnddate.Location = new System.Drawing.Point(5, 6);
            this.lbEnddate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbEnddate.Name = "lbEnddate";
            this.lbEnddate.Size = new System.Drawing.Size(73, 19);
            this.lbEnddate.TabIndex = 89;
            this.lbEnddate.Text = "End Date:";
            // 
            // dtbEnd
            // 
            this.dtbEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtbEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbEnd.Location = new System.Drawing.Point(4, 34);
            this.dtbEnd.Name = "dtbEnd";
            this.dtbEnd.Size = new System.Drawing.Size(150, 29);
            this.dtbEnd.TabIndex = 82;
            this.dtbEnd.Value = new System.DateTime(2017, 4, 3, 0, 0, 0, 0);
            // 
            // pnDayStart
            // 
            this.pnDayStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnDayStart.Controls.Add(this.lbStartDay);
            this.pnDayStart.Controls.Add(this.dtpStartDate);
            this.pnDayStart.Location = new System.Drawing.Point(546, 33);
            this.pnDayStart.Name = "pnDayStart";
            this.pnDayStart.Size = new System.Drawing.Size(158, 73);
            this.pnDayStart.TabIndex = 97;
            // 
            // lbStartDay
            // 
            this.lbStartDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStartDay.AutoSize = true;
            this.lbStartDay.Depth = 0;
            this.lbStartDay.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbStartDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStartDay.Location = new System.Drawing.Point(6, 5);
            this.lbStartDay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStartDay.Name = "lbStartDay";
            this.lbStartDay.Size = new System.Drawing.Size(80, 19);
            this.lbStartDay.TabIndex = 89;
            this.lbStartDay.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(3, 34);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 29);
            this.dtpStartDate.TabIndex = 82;
            this.dtpStartDate.Value = new System.DateTime(2017, 4, 3, 0, 0, 0, 0);
            // 
            // cbRentType
            // 
            this.cbRentType.BackColor = System.Drawing.Color.White;
            this.cbRentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRentType.FormattingEnabled = true;
            this.cbRentType.Items.AddRange(new object[] {
            "Bao phòng",
            "Ở ghép"});
            this.cbRentType.Location = new System.Drawing.Point(384, 74);
            this.cbRentType.MaxLength = 10;
            this.cbRentType.Name = "cbRentType";
            this.cbRentType.Size = new System.Drawing.Size(150, 32);
            this.cbRentType.Sorted = true;
            this.cbRentType.TabIndex = 95;
            // 
            // lbReservationID
            // 
            this.lbReservationID.Depth = 0;
            this.lbReservationID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbReservationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbReservationID.Location = new System.Drawing.Point(20, 38);
            this.lbReservationID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbReservationID.Name = "lbReservationID";
            this.lbReservationID.Size = new System.Drawing.Size(109, 18);
            this.lbReservationID.TabIndex = 80;
            this.lbReservationID.Text = "ReservationID:";
            // 
            // lbRentType
            // 
            this.lbRentType.Depth = 0;
            this.lbRentType.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbRentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbRentType.Location = new System.Drawing.Point(305, 86);
            this.lbRentType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRentType.Name = "lbRentType";
            this.lbRentType.Size = new System.Drawing.Size(55, 15);
            this.lbRentType.TabIndex = 86;
            this.lbRentType.Text = "Rent Type:";
            // 
            // txtResID
            // 
            this.txtResID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResID.HintForeColor = System.Drawing.Color.Empty;
            this.txtResID.HintText = "";
            this.txtResID.isPassword = false;
            this.txtResID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtResID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtResID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtResID.LineThickness = 4;
            this.txtResID.Location = new System.Drawing.Point(136, 21);
            this.txtResID.Margin = new System.Windows.Forms.Padding(4);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(150, 35);
            this.txtResID.TabIndex = 87;
            this.txtResID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(20, 88);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(104, 18);
            this.materialLabel7.TabIndex = 80;
            this.materialLabel7.Text = "CustomerID:";
            // 
            // txtCusRes
            // 
            this.txtCusRes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusRes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCusRes.HintForeColor = System.Drawing.Color.Empty;
            this.txtCusRes.HintText = "";
            this.txtCusRes.isPassword = false;
            this.txtCusRes.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCusRes.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCusRes.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCusRes.LineThickness = 4;
            this.txtCusRes.Location = new System.Drawing.Point(137, 71);
            this.txtCusRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusRes.Name = "txtCusRes";
            this.txtCusRes.Size = new System.Drawing.Size(150, 35);
            this.txtCusRes.TabIndex = 87;
            this.txtCusRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmReservationHiscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 661);
            this.Controls.Add(this.fbDetail);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbList);
            this.Name = "frmReservationHiscs";
            this.Text = "Reservation History";
            this.Load += new System.EventHandler(this.frmReservationHiscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.gbList.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.fbDetail.ResumeLayout(false);
            this.pnEnd.ResumeLayout(false);
            this.pnEnd.PerformLayout();
            this.pnDayStart.ResumeLayout(false);
            this.pnDayStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvReservation;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.GroupBox gbSearch;
        private MaterialSkin.Controls.MaterialLabel lbSearchCusID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCusIDSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowAll;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.ComboBox cbRoomSearch;
        private MaterialSkin.Controls.MaterialLabel lbSearchRoomID;
        private System.Windows.Forms.GroupBox fbDetail;
        private MaterialSkin.Controls.MaterialLabel lbResRoom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRoomID;
        private System.Windows.Forms.Panel pnEnd;
        private MaterialSkin.Controls.MaterialLabel lbEnddate;
        private System.Windows.Forms.DateTimePicker dtbEnd;
        private System.Windows.Forms.Panel pnDayStart;
        private MaterialSkin.Controls.MaterialLabel lbStartDay;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbRentType;
        private MaterialSkin.Controls.MaterialLabel lbReservationID;
        private MaterialSkin.Controls.MaterialLabel lbRentType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtResID;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCusRes;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEndAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RenType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}