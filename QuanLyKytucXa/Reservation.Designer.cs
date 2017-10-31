namespace QuanLyKytucXa
{
    partial class Reservation
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
            this.gbRoom = new System.Windows.Forms.GroupBox();
            this.lbRoomID = new MaterialSkin.Controls.MaterialLabel();
            this.txtRoomID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnChooseRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvRoom = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.btnEndAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreateID = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbResRoom = new MaterialSkin.Controls.MaterialLabel();
            this.txtResRoom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCustomer = new MaterialSkin.Controls.MaterialLabel();
            this.txtCustomerId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnChooseCus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbPhone = new MaterialSkin.Controls.MaterialLabel();
            this.lbSex = new MaterialSkin.Controls.MaterialLabel();
            this.lbVehicle = new MaterialSkin.Controls.MaterialLabel();
            this.llbAddress = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnData.SuspendLayout();
            this.gbRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.pnEnd.SuspendLayout();
            this.pnDayStart.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.BackColor = System.Drawing.Color.White;
            this.pnData.Controls.Add(this.gbRoom);
            this.pnData.Controls.Add(this.gbDetail);
            this.pnData.Controls.Add(this.gbCustomer);
            this.pnData.Controls.Add(this.btnReset);
            this.pnData.Controls.Add(this.btnCreate);
            this.pnData.Controls.Add(this.btnHis);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(1045, 710);
            this.pnData.TabIndex = 94;
            // 
            // gbRoom
            // 
            this.gbRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRoom.Controls.Add(this.lbRoomID);
            this.gbRoom.Controls.Add(this.txtRoomID);
            this.gbRoom.Controls.Add(this.btnChooseRoom);
            this.gbRoom.Controls.Add(this.dgvRoom);
            this.gbRoom.Location = new System.Drawing.Point(417, 12);
            this.gbRoom.Name = "gbRoom";
            this.gbRoom.Size = new System.Drawing.Size(604, 293);
            this.gbRoom.TabIndex = 95;
            this.gbRoom.TabStop = false;
            this.gbRoom.Text = "Room";
            // 
            // lbRoomID
            // 
            this.lbRoomID.Depth = 0;
            this.lbRoomID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbRoomID.Location = new System.Drawing.Point(7, 48);
            this.lbRoomID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(68, 18);
            this.lbRoomID.TabIndex = 81;
            this.lbRoomID.Text = "Room ID:";
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
            this.txtRoomID.Location = new System.Drawing.Point(82, 32);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(150, 35);
            this.txtRoomID.TabIndex = 82;
            this.txtRoomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChooseRoom
            // 
            this.btnChooseRoom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChooseRoom.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnChooseRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnChooseRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseRoom.BorderRadius = 0;
            this.btnChooseRoom.ButtonText = "Choose";
            this.btnChooseRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseRoom.DisabledColor = System.Drawing.Color.Gray;
            this.btnChooseRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChooseRoom.Iconimage = null;
            this.btnChooseRoom.Iconimage_right = null;
            this.btnChooseRoom.Iconimage_right_Selected = null;
            this.btnChooseRoom.Iconimage_Selected = null;
            this.btnChooseRoom.IconMarginLeft = 0;
            this.btnChooseRoom.IconMarginRight = 0;
            this.btnChooseRoom.IconRightVisible = true;
            this.btnChooseRoom.IconRightZoom = 0D;
            this.btnChooseRoom.IconVisible = true;
            this.btnChooseRoom.IconZoom = 90D;
            this.btnChooseRoom.IsTab = false;
            this.btnChooseRoom.Location = new System.Drawing.Point(11, 92);
            this.btnChooseRoom.Name = "btnChooseRoom";
            this.btnChooseRoom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnChooseRoom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnChooseRoom.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnChooseRoom.selected = false;
            this.btnChooseRoom.Size = new System.Drawing.Size(100, 40);
            this.btnChooseRoom.TabIndex = 71;
            this.btnChooseRoom.Text = "Choose";
            this.btnChooseRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChooseRoom.Textcolor = System.Drawing.Color.Black;
            this.btnChooseRoom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseRoom.Click += new System.EventHandler(this.btnChooseRoom_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoom.ColumnHeadersHeight = 30;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomID,
            this.colStatus,
            this.colTypeID});
            this.dgvRoom.DoubleBuffered = true;
            this.dgvRoom.EnableHeadersVisualStyles = false;
            this.dgvRoom.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRoom.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.dgvRoom.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvRoom.Location = new System.Drawing.Point(246, 48);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvRoom.RowHeadersVisible = false;
            this.dgvRoom.RowHeadersWidth = 50;
            this.dgvRoom.Size = new System.Drawing.Size(352, 239);
            this.dgvRoom.TabIndex = 80;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // colRoomID
            // 
            this.colRoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomID.FillWeight = 5F;
            this.colRoomID.HeaderText = "RoomID";
            this.colRoomID.MinimumWidth = 50;
            this.colRoomID.Name = "colRoomID";
            this.colRoomID.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.FillWeight = 15F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 100;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colTypeID
            // 
            this.colTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTypeID.FillWeight = 5F;
            this.colTypeID.HeaderText = "Price";
            this.colTypeID.MinimumWidth = 50;
            this.colTypeID.Name = "colTypeID";
            this.colTypeID.ReadOnly = true;
            // 
            // gbDetail
            // 
            this.gbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbDetail.Controls.Add(this.btnEndAdd);
            this.gbDetail.Controls.Add(this.btnMinus);
            this.gbDetail.Controls.Add(this.btnCreateID);
            this.gbDetail.Controls.Add(this.lbResRoom);
            this.gbDetail.Controls.Add(this.txtResRoom);
            this.gbDetail.Controls.Add(this.pnEnd);
            this.gbDetail.Controls.Add(this.pnDayStart);
            this.gbDetail.Controls.Add(this.cbRentType);
            this.gbDetail.Controls.Add(this.lbReservationID);
            this.gbDetail.Controls.Add(this.lbRentType);
            this.gbDetail.Controls.Add(this.txtResID);
            this.gbDetail.Controls.Add(this.materialLabel7);
            this.gbDetail.Controls.Add(this.txtCusRes);
            this.gbDetail.Location = new System.Drawing.Point(417, 315);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(604, 284);
            this.gbDetail.TabIndex = 94;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Reservation";
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
            this.btnEndAdd.Location = new System.Drawing.Point(569, 88);
            this.btnEndAdd.Name = "btnEndAdd";
            this.btnEndAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnEndAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnEndAdd.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEndAdd.selected = false;
            this.btnEndAdd.Size = new System.Drawing.Size(30, 30);
            this.btnEndAdd.TabIndex = 70;
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
            this.btnMinus.Location = new System.Drawing.Point(569, 88);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnMinus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnMinus.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMinus.selected = false;
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 98;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinus.Textcolor = System.Drawing.Color.Black;
            this.btnMinus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnCreateID
            // 
            this.btnCreateID.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreateID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnCreateID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateID.BorderRadius = 0;
            this.btnCreateID.ButtonText = "CreateID";
            this.btnCreateID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateID.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreateID.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreateID.Iconimage = null;
            this.btnCreateID.Iconimage_right = null;
            this.btnCreateID.Iconimage_right_Selected = null;
            this.btnCreateID.Iconimage_Selected = null;
            this.btnCreateID.IconMarginLeft = 0;
            this.btnCreateID.IconMarginRight = 0;
            this.btnCreateID.IconRightVisible = true;
            this.btnCreateID.IconRightZoom = 0D;
            this.btnCreateID.IconVisible = true;
            this.btnCreateID.IconZoom = 90D;
            this.btnCreateID.IsTab = false;
            this.btnCreateID.Location = new System.Drawing.Point(343, 31);
            this.btnCreateID.Name = "btnCreateID";
            this.btnCreateID.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnCreateID.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnCreateID.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCreateID.selected = false;
            this.btnCreateID.Size = new System.Drawing.Size(100, 40);
            this.btnCreateID.TabIndex = 71;
            this.btnCreateID.Text = "CreateID";
            this.btnCreateID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateID.Textcolor = System.Drawing.Color.Black;
            this.btnCreateID.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateID.Click += new System.EventHandler(this.btnCreateID_Click);
            // 
            // lbResRoom
            // 
            this.lbResRoom.Depth = 0;
            this.lbResRoom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbResRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbResRoom.Location = new System.Drawing.Point(20, 138);
            this.lbResRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbResRoom.Name = "lbResRoom";
            this.lbResRoom.Size = new System.Drawing.Size(68, 18);
            this.lbResRoom.TabIndex = 81;
            this.lbResRoom.Text = "Room ID:";
            // 
            // txtResRoom
            // 
            this.txtResRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResRoom.Enabled = false;
            this.txtResRoom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResRoom.HintForeColor = System.Drawing.Color.Empty;
            this.txtResRoom.HintText = "";
            this.txtResRoom.isPassword = false;
            this.txtResRoom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtResRoom.LineIdleColor = System.Drawing.Color.Gray;
            this.txtResRoom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtResRoom.LineThickness = 4;
            this.txtResRoom.Location = new System.Drawing.Point(137, 121);
            this.txtResRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtResRoom.Name = "txtResRoom";
            this.txtResRoom.Size = new System.Drawing.Size(184, 35);
            this.txtResRoom.TabIndex = 82;
            this.txtResRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnEnd
            // 
            this.pnEnd.Controls.Add(this.lbEnddate);
            this.pnEnd.Controls.Add(this.dtbEnd);
            this.pnEnd.Location = new System.Drawing.Point(343, 165);
            this.pnEnd.Name = "pnEnd";
            this.pnEnd.Size = new System.Drawing.Size(220, 73);
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
            this.lbEnddate.Location = new System.Drawing.Point(4, 6);
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
            this.dtbEnd.Location = new System.Drawing.Point(8, 34);
            this.dtbEnd.Name = "dtbEnd";
            this.dtbEnd.Size = new System.Drawing.Size(209, 29);
            this.dtbEnd.TabIndex = 82;
            this.dtbEnd.Value = new System.DateTime(2017, 3, 15, 0, 0, 0, 0);
            // 
            // pnDayStart
            // 
            this.pnDayStart.Controls.Add(this.lbStartDay);
            this.pnDayStart.Controls.Add(this.dtpStartDate);
            this.pnDayStart.Location = new System.Drawing.Point(343, 82);
            this.pnDayStart.Name = "pnDayStart";
            this.pnDayStart.Size = new System.Drawing.Size(220, 73);
            this.pnDayStart.TabIndex = 97;
            // 
            // lbStartDay
            // 
            this.lbStartDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStartDay.AutoSize = true;
            this.lbStartDay.Depth = 0;
            this.lbStartDay.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbStartDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStartDay.Location = new System.Drawing.Point(4, 6);
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
            this.dtpStartDate.Location = new System.Drawing.Point(8, 33);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(209, 29);
            this.dtpStartDate.TabIndex = 82;
            this.dtpStartDate.Value = new System.DateTime(2017, 3, 15, 0, 0, 0, 0);
            // 
            // cbRentType
            // 
            this.cbRentType.BackColor = System.Drawing.Color.White;
            this.cbRentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRentType.FormattingEnabled = true;
            this.cbRentType.Items.AddRange(new object[] {
            "Bao phòng",
            "Ở ghép"});
            this.cbRentType.Location = new System.Drawing.Point(137, 179);
            this.cbRentType.MaximumSize = new System.Drawing.Size(121, 0);
            this.cbRentType.MaxLength = 10;
            this.cbRentType.Name = "cbRentType";
            this.cbRentType.Size = new System.Drawing.Size(121, 32);
            this.cbRentType.Sorted = true;
            this.cbRentType.TabIndex = 95;
            // 
            // lbReservationID
            // 
            this.lbReservationID.Depth = 0;
            this.lbReservationID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbReservationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbReservationID.Location = new System.Drawing.Point(20, 48);
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
            this.lbRentType.Location = new System.Drawing.Point(20, 186);
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
            this.txtResID.Location = new System.Drawing.Point(136, 31);
            this.txtResID.Margin = new System.Windows.Forms.Padding(4);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(185, 35);
            this.txtResID.TabIndex = 87;
            this.txtResID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(20, 98);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(104, 18);
            this.materialLabel7.TabIndex = 80;
            this.materialLabel7.Text = "CustomerID:";
            // 
            // txtCusRes
            // 
            this.txtCusRes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusRes.Enabled = false;
            this.txtCusRes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCusRes.HintForeColor = System.Drawing.Color.Empty;
            this.txtCusRes.HintText = "";
            this.txtCusRes.isPassword = false;
            this.txtCusRes.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCusRes.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCusRes.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCusRes.LineThickness = 4;
            this.txtCusRes.Location = new System.Drawing.Point(137, 81);
            this.txtCusRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusRes.Name = "txtCusRes";
            this.txtCusRes.Size = new System.Drawing.Size(184, 35);
            this.txtCusRes.TabIndex = 87;
            this.txtCusRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbCustomer.Controls.Add(this.cbVehicle);
            this.gbCustomer.Controls.Add(this.groupBox1);
            this.gbCustomer.Controls.Add(this.rdbFemale);
            this.gbCustomer.Controls.Add(this.rdbMale);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.lbPhone);
            this.gbCustomer.Controls.Add(this.lbSex);
            this.gbCustomer.Controls.Add(this.lbVehicle);
            this.gbCustomer.Controls.Add(this.llbAddress);
            this.gbCustomer.Controls.Add(this.txtAddress);
            this.gbCustomer.Controls.Add(this.lbName);
            this.gbCustomer.Controls.Add(this.materialLabel6);
            this.gbCustomer.Controls.Add(this.txtName);
            this.gbCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(399, 587);
            this.gbCustomer.TabIndex = 94;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // cbVehicle
            // 
            this.cbVehicle.BackColor = System.Drawing.Color.White;
            this.cbVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(139, 224);
            this.cbVehicle.MaximumSize = new System.Drawing.Size(121, 0);
            this.cbVehicle.MaxLength = 10;
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(121, 32);
            this.cbVehicle.Sorted = true;
            this.cbVehicle.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCustomer);
            this.groupBox1.Controls.Add(this.txtCustomerId);
            this.groupBox1.Controls.Add(this.btnChooseCus);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 66);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Customer";
            // 
            // lbCustomer
            // 
            this.lbCustomer.Depth = 0;
            this.lbCustomer.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCustomer.Location = new System.Drawing.Point(6, 29);
            this.lbCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(104, 18);
            this.lbCustomer.TabIndex = 80;
            this.lbCustomer.Text = "CustomerID:";
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
            this.txtCustomerId.Location = new System.Drawing.Point(117, 13);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(128, 35);
            this.txtCustomerId.TabIndex = 87;
            this.txtCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomerId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomerId_KeyUp);
            // 
            // btnChooseCus
            // 
            this.btnChooseCus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChooseCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnChooseCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseCus.BorderRadius = 0;
            this.btnChooseCus.ButtonText = "Choose";
            this.btnChooseCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseCus.DisabledColor = System.Drawing.Color.Gray;
            this.btnChooseCus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChooseCus.Iconimage = null;
            this.btnChooseCus.Iconimage_right = null;
            this.btnChooseCus.Iconimage_right_Selected = null;
            this.btnChooseCus.Iconimage_Selected = null;
            this.btnChooseCus.IconMarginLeft = 0;
            this.btnChooseCus.IconMarginRight = 0;
            this.btnChooseCus.IconRightVisible = true;
            this.btnChooseCus.IconRightZoom = 0D;
            this.btnChooseCus.IconVisible = true;
            this.btnChooseCus.IconZoom = 90D;
            this.btnChooseCus.IsTab = false;
            this.btnChooseCus.Location = new System.Drawing.Point(267, 13);
            this.btnChooseCus.Name = "btnChooseCus";
            this.btnChooseCus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnChooseCus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnChooseCus.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnChooseCus.selected = false;
            this.btnChooseCus.Size = new System.Drawing.Size(100, 40);
            this.btnChooseCus.TabIndex = 71;
            this.btnChooseCus.Text = "Choose";
            this.btnChooseCus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChooseCus.Textcolor = System.Drawing.Color.Black;
            this.btnChooseCus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseCus.Click += new System.EventHandler(this.btnChooseCus_Click);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(192, 339);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 92;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(123, 339);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 91;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPhone.LineThickness = 4;
            this.txtPhone.Location = new System.Drawing.Point(139, 258);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 35);
            this.txtPhone.TabIndex = 88;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbPhone
            // 
            this.lbPhone.Depth = 0;
            this.lbPhone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPhone.Location = new System.Drawing.Point(28, 275);
            this.lbPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(55, 18);
            this.lbPhone.TabIndex = 86;
            this.lbPhone.Text = "Phone:";
            // 
            // lbSex
            // 
            this.lbSex.Depth = 0;
            this.lbSex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSex.Location = new System.Drawing.Point(28, 337);
            this.lbSex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(68, 18);
            this.lbSex.TabIndex = 83;
            this.lbSex.Text = "Sex:";
            // 
            // lbVehicle
            // 
            this.lbVehicle.Depth = 0;
            this.lbVehicle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVehicle.Location = new System.Drawing.Point(28, 224);
            this.lbVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbVehicle.Name = "lbVehicle";
            this.lbVehicle.Size = new System.Drawing.Size(68, 18);
            this.lbVehicle.TabIndex = 84;
            this.lbVehicle.Text = "Vehicle:";
            // 
            // llbAddress
            // 
            this.llbAddress.Depth = 0;
            this.llbAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.llbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.llbAddress.Location = new System.Drawing.Point(28, 166);
            this.llbAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.llbAddress.Name = "llbAddress";
            this.llbAddress.Size = new System.Drawing.Size(68, 18);
            this.llbAddress.TabIndex = 85;
            this.llbAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddress.LineThickness = 4;
            this.txtAddress.Location = new System.Drawing.Point(139, 149);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 35);
            this.txtAddress.TabIndex = 90;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbName
            // 
            this.lbName.Depth = 0;
            this.lbName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(28, 114);
            this.lbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 18);
            this.lbName.TabIndex = 81;
            this.lbName.Text = "Name:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(-130, 114);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 18);
            this.materialLabel6.TabIndex = 81;
            this.materialLabel6.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 4;
            this.txtName.Location = new System.Drawing.Point(139, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 40);
            this.txtName.TabIndex = 89;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Reset";
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
            this.btnReset.Location = new System.Drawing.Point(774, 633);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 71;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.Black;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCreate
            // 
            this.btnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.BorderRadius = 0;
            this.btnCreate.ButtonText = "Create";
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreate.Iconimage = null;
            this.btnCreate.Iconimage_right = null;
            this.btnCreate.Iconimage_right_Selected = null;
            this.btnCreate.Iconimage_Selected = null;
            this.btnCreate.IconMarginLeft = 0;
            this.btnCreate.IconMarginRight = 0;
            this.btnCreate.IconRightVisible = true;
            this.btnCreate.IconRightZoom = 0D;
            this.btnCreate.IconVisible = true;
            this.btnCreate.IconZoom = 90D;
            this.btnCreate.IsTab = false;
            this.btnCreate.Location = new System.Drawing.Point(648, 633);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnCreate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnCreate.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCreate.selected = false;
            this.btnCreate.Size = new System.Drawing.Size(120, 40);
            this.btnCreate.TabIndex = 70;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Textcolor = System.Drawing.Color.Black;
            this.btnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnHis
            // 
            this.btnHis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnHis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHis.BorderRadius = 0;
            this.btnHis.ButtonText = "History";
            this.btnHis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHis.DisabledColor = System.Drawing.Color.Gray;
            this.btnHis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHis.Iconimage = null;
            this.btnHis.Iconimage_right = null;
            this.btnHis.Iconimage_right_Selected = null;
            this.btnHis.Iconimage_Selected = null;
            this.btnHis.IconMarginLeft = 0;
            this.btnHis.IconMarginRight = 0;
            this.btnHis.IconRightVisible = true;
            this.btnHis.IconRightZoom = 0D;
            this.btnHis.IconVisible = true;
            this.btnHis.IconZoom = 90D;
            this.btnHis.IsTab = false;
            this.btnHis.Location = new System.Drawing.Point(901, 633);
            this.btnHis.Name = "btnHis";
            this.btnHis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnHis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnHis.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnHis.selected = false;
            this.btnHis.Size = new System.Drawing.Size(120, 40);
            this.btnHis.TabIndex = 70;
            this.btnHis.Text = "History";
            this.btnHis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHis.Textcolor = System.Drawing.Color.Black;
            this.btnHis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHis.Click += new System.EventHandler(this.btnHis_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.FillWeight = 5F;
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 35;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 710);
            this.Controls.Add(this.pnData);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "Reservation";
            this.Text = "d";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.pnData.ResumeLayout(false);
            this.gbRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.pnEnd.ResumeLayout(false);
            this.pnEnd.PerformLayout();
            this.pnDayStart.ResumeLayout(false);
            this.pnDayStart.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnData;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private MaterialSkin.Controls.MaterialLabel lbPhone;
        private MaterialSkin.Controls.MaterialLabel lbSex;
        private MaterialSkin.Controls.MaterialLabel lbVehicle;
        private MaterialSkin.Controls.MaterialLabel llbAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private MaterialSkin.Controls.MaterialLabel lbName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustomerId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private MaterialSkin.Controls.MaterialLabel lbCustomer;
        private MaterialSkin.Controls.MaterialLabel lbReservationID;
        private MaterialSkin.Controls.MaterialLabel lbRentType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtResID;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCusRes;
        private Bunifu.Framework.UI.BunifuFlatButton btnChooseCus;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Bunifu.Framework.UI.BunifuFlatButton btnHis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.GroupBox gbRoom;
        private System.Windows.Forms.Panel pnEnd;
        private MaterialSkin.Controls.MaterialLabel lbEnddate;
        private System.Windows.Forms.DateTimePicker dtbEnd;
        private System.Windows.Forms.Panel pnDayStart;
        private MaterialSkin.Controls.MaterialLabel lbStartDay;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbRentType;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRoom;
        private MaterialSkin.Controls.MaterialLabel lbRoomID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRoomID;
        private Bunifu.Framework.UI.BunifuFlatButton btnChooseRoom;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreate;
        private MaterialSkin.Controls.MaterialLabel lbResRoom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtResRoom;
        private Bunifu.Framework.UI.BunifuFlatButton btnEndAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreateID;
        private Bunifu.Framework.UI.BunifuFlatButton btnMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeID;
    }
}