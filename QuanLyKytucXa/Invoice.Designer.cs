namespace QuanLyKytucXa
{
    partial class Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnData = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lbRoomID = new MaterialSkin.Controls.MaterialLabel();
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
            this.txtRoom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbInvoice = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lbCusId = new MaterialSkin.Controls.MaterialLabel();
            this.dgvSerFee = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCusIDInvoice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnElectric = new System.Windows.Forms.Panel();
            this.btnElecEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbInputElec = new MaterialSkin.Controls.MaterialLabel();
            this.txtElecNum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ckbVehicle = new System.Windows.Forms.CheckBox();
            this.ckbWater = new System.Windows.Forms.CheckBox();
            this.ckbRoom = new System.Windows.Forms.CheckBox();
            this.lbSum = new MaterialSkin.Controls.MaterialLabel();
            this.txtSum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbInvoiceID = new MaterialSkin.Controls.MaterialLabel();
            this.txtInvoiceID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lnDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lbWater = new MaterialSkin.Controls.MaterialLabel();
            this.lbRoom = new MaterialSkin.Controls.MaterialLabel();
            this.lbYear = new MaterialSkin.Controls.MaterialLabel();
            this.lbMonth = new MaterialSkin.Controls.MaterialLabel();
            this.lbVehicleInvoice = new MaterialSkin.Controls.MaterialLabel();
            this.pnData.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerFee)).BeginInit();
            this.pnElectric.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.btnClear);
            this.pnData.Controls.Add(this.btnHistory);
            this.pnData.Controls.Add(this.btnCreate);
            this.pnData.Controls.Add(this.gbCustomer);
            this.pnData.Controls.Add(this.gbInvoice);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(1045, 710);
            this.pnData.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(884, 624);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(152, 44);
            this.btnClear.TabIndex = 70;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.Black;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.BorderRadius = 0;
            this.btnHistory.ButtonText = "History";
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistory.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistory.Iconimage = null;
            this.btnHistory.Iconimage_right = null;
            this.btnHistory.Iconimage_right_Selected = null;
            this.btnHistory.Iconimage_Selected = null;
            this.btnHistory.IconMarginLeft = 0;
            this.btnHistory.IconMarginRight = 0;
            this.btnHistory.IconRightVisible = true;
            this.btnHistory.IconRightZoom = 0D;
            this.btnHistory.IconVisible = true;
            this.btnHistory.IconZoom = 90D;
            this.btnHistory.IsTab = false;
            this.btnHistory.Location = new System.Drawing.Point(568, 624);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnHistory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnHistory.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnHistory.selected = false;
            this.btnHistory.Size = new System.Drawing.Size(152, 44);
            this.btnHistory.TabIndex = 70;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHistory.Textcolor = System.Drawing.Color.Black;
            this.btnHistory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
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
            this.btnCreate.Location = new System.Drawing.Point(726, 624);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnCreate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnCreate.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCreate.selected = false;
            this.btnCreate.Size = new System.Drawing.Size(152, 44);
            this.btnCreate.TabIndex = 70;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Textcolor = System.Drawing.Color.Black;
            this.btnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbCustomer.Controls.Add(this.lbRoomID);
            this.gbCustomer.Controls.Add(this.cbVehicle);
            this.gbCustomer.Controls.Add(this.groupBox1);
            this.gbCustomer.Controls.Add(this.rdbFemale);
            this.gbCustomer.Controls.Add(this.rdbMale);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.lbPhone);
            this.gbCustomer.Controls.Add(this.lbSex);
            this.gbCustomer.Controls.Add(this.lbVehicle);
            this.gbCustomer.Controls.Add(this.llbAddress);
            this.gbCustomer.Controls.Add(this.txtRoom);
            this.gbCustomer.Controls.Add(this.txtAddress);
            this.gbCustomer.Controls.Add(this.lbName);
            this.gbCustomer.Controls.Add(this.materialLabel6);
            this.gbCustomer.Controls.Add(this.txtName);
            this.gbCustomer.Location = new System.Drawing.Point(12, 31);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(450, 587);
            this.gbCustomer.TabIndex = 98;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // lbRoomID
            // 
            this.lbRoomID.Depth = 0;
            this.lbRoomID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbRoomID.Location = new System.Drawing.Point(28, 224);
            this.lbRoomID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(74, 18);
            this.lbRoomID.TabIndex = 97;
            this.lbRoomID.Text = "Room :";
            // 
            // cbVehicle
            // 
            this.cbVehicle.BackColor = System.Drawing.Color.White;
            this.cbVehicle.Enabled = false;
            this.cbVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(139, 269);
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
            this.groupBox1.Size = new System.Drawing.Size(393, 66);
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
            this.rdbFemale.Enabled = false;
            this.rdbFemale.Location = new System.Drawing.Point(192, 384);
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
            this.rdbMale.Enabled = false;
            this.rdbMale.Location = new System.Drawing.Point(123, 384);
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
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPhone.LineThickness = 4;
            this.txtPhone.Location = new System.Drawing.Point(139, 303);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(287, 35);
            this.txtPhone.TabIndex = 88;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbPhone
            // 
            this.lbPhone.Depth = 0;
            this.lbPhone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPhone.Location = new System.Drawing.Point(28, 320);
            this.lbPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(61, 18);
            this.lbPhone.TabIndex = 86;
            this.lbPhone.Text = "Phone:";
            // 
            // lbSex
            // 
            this.lbSex.Depth = 0;
            this.lbSex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSex.Location = new System.Drawing.Point(28, 382);
            this.lbSex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(74, 18);
            this.lbSex.TabIndex = 83;
            this.lbSex.Text = "Sex:";
            // 
            // lbVehicle
            // 
            this.lbVehicle.Depth = 0;
            this.lbVehicle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVehicle.Location = new System.Drawing.Point(28, 269);
            this.lbVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbVehicle.Name = "lbVehicle";
            this.lbVehicle.Size = new System.Drawing.Size(74, 18);
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
            this.llbAddress.Size = new System.Drawing.Size(74, 18);
            this.llbAddress.TabIndex = 85;
            this.llbAddress.Text = "Address:";
            // 
            // txtRoom
            // 
            this.txtRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom.Enabled = false;
            this.txtRoom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoom.HintForeColor = System.Drawing.Color.Empty;
            this.txtRoom.HintText = "";
            this.txtRoom.isPassword = false;
            this.txtRoom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRoom.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRoom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRoom.LineThickness = 4;
            this.txtRoom.Location = new System.Drawing.Point(139, 206);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(287, 35);
            this.txtRoom.TabIndex = 90;
            this.txtRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Enabled = false;
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
            this.txtAddress.Size = new System.Drawing.Size(287, 35);
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
            this.lbName.Size = new System.Drawing.Size(70, 18);
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
            this.txtName.Location = new System.Drawing.Point(139, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 40);
            this.txtName.TabIndex = 89;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbInvoice
            // 
            this.gbInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbInvoice.Controls.Add(this.txtDescription);
            this.gbInvoice.Controls.Add(this.lbCusId);
            this.gbInvoice.Controls.Add(this.dgvSerFee);
            this.gbInvoice.Controls.Add(this.txtCusIDInvoice);
            this.gbInvoice.Controls.Add(this.pnElectric);
            this.gbInvoice.Controls.Add(this.ckbVehicle);
            this.gbInvoice.Controls.Add(this.ckbWater);
            this.gbInvoice.Controls.Add(this.ckbRoom);
            this.gbInvoice.Controls.Add(this.lbSum);
            this.gbInvoice.Controls.Add(this.txtSum);
            this.gbInvoice.Controls.Add(this.lbInvoiceID);
            this.gbInvoice.Controls.Add(this.txtInvoiceID);
            this.gbInvoice.Controls.Add(this.cbYear);
            this.gbInvoice.Controls.Add(this.cbMonth);
            this.gbInvoice.Controls.Add(this.lnDescription);
            this.gbInvoice.Controls.Add(this.lbWater);
            this.gbInvoice.Controls.Add(this.lbRoom);
            this.gbInvoice.Controls.Add(this.lbYear);
            this.gbInvoice.Controls.Add(this.lbMonth);
            this.gbInvoice.Controls.Add(this.lbVehicleInvoice);
            this.gbInvoice.Location = new System.Drawing.Point(468, 31);
            this.gbInvoice.Name = "gbInvoice";
            this.gbInvoice.Size = new System.Drawing.Size(553, 587);
            this.gbInvoice.TabIndex = 93;
            this.gbInvoice.TabStop = false;
            this.gbInvoice.Text = "Invoice";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(10, 241);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 115);
            this.txtDescription.TabIndex = 100;
            this.txtDescription.Text = "";
            // 
            // lbCusId
            // 
            this.lbCusId.Depth = 0;
            this.lbCusId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCusId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCusId.Location = new System.Drawing.Point(6, 78);
            this.lbCusId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCusId.Name = "lbCusId";
            this.lbCusId.Size = new System.Drawing.Size(104, 18);
            this.lbCusId.TabIndex = 98;
            this.lbCusId.Text = "CustomerID:";
            // 
            // dgvSerFee
            // 
            this.dgvSerFee.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSerFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSerFee.BackgroundColor = System.Drawing.Color.White;
            this.dgvSerFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSerFee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSerFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSerFee.ColumnHeadersHeight = 30;
            this.dgvSerFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Delete});
            this.dgvSerFee.DoubleBuffered = true;
            this.dgvSerFee.EnableHeadersVisualStyles = false;
            this.dgvSerFee.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSerFee.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.dgvSerFee.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvSerFee.Location = new System.Drawing.Point(10, 362);
            this.dgvSerFee.Name = "dgvSerFee";
            this.dgvSerFee.ReadOnly = true;
            this.dgvSerFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSerFee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvSerFee.RowHeadersVisible = false;
            this.dgvSerFee.RowHeadersWidth = 50;
            this.dgvSerFee.Size = new System.Drawing.Size(363, 201);
            this.dgvSerFee.TabIndex = 96;
            this.dgvSerFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerFeee_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 5F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ServiceID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 15F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Fee";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // txtCusIDInvoice
            // 
            this.txtCusIDInvoice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusIDInvoice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusIDInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCusIDInvoice.HintForeColor = System.Drawing.Color.Empty;
            this.txtCusIDInvoice.HintText = "";
            this.txtCusIDInvoice.isPassword = false;
            this.txtCusIDInvoice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCusIDInvoice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCusIDInvoice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCusIDInvoice.LineThickness = 4;
            this.txtCusIDInvoice.Location = new System.Drawing.Point(114, 55);
            this.txtCusIDInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusIDInvoice.Name = "txtCusIDInvoice";
            this.txtCusIDInvoice.Size = new System.Drawing.Size(150, 35);
            this.txtCusIDInvoice.TabIndex = 99;
            this.txtCusIDInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnElectric
            // 
            this.pnElectric.Controls.Add(this.btnElecEnter);
            this.pnElectric.Controls.Add(this.lbInputElec);
            this.pnElectric.Controls.Add(this.txtElecNum);
            this.pnElectric.Location = new System.Drawing.Point(285, 215);
            this.pnElectric.Name = "pnElectric";
            this.pnElectric.Size = new System.Drawing.Size(268, 72);
            this.pnElectric.TabIndex = 97;
            // 
            // btnElecEnter
            // 
            this.btnElecEnter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnElecEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnElecEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElecEnter.BorderRadius = 0;
            this.btnElecEnter.ButtonText = "Enter";
            this.btnElecEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElecEnter.DisabledColor = System.Drawing.Color.Gray;
            this.btnElecEnter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElecEnter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnElecEnter.Iconimage = null;
            this.btnElecEnter.Iconimage_right = null;
            this.btnElecEnter.Iconimage_right_Selected = null;
            this.btnElecEnter.Iconimage_Selected = null;
            this.btnElecEnter.IconMarginLeft = 0;
            this.btnElecEnter.IconMarginRight = 0;
            this.btnElecEnter.IconRightVisible = true;
            this.btnElecEnter.IconRightZoom = 0D;
            this.btnElecEnter.IconVisible = true;
            this.btnElecEnter.IconZoom = 90D;
            this.btnElecEnter.IsTab = false;
            this.btnElecEnter.Location = new System.Drawing.Point(206, 9);
            this.btnElecEnter.Name = "btnElecEnter";
            this.btnElecEnter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnElecEnter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.btnElecEnter.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnElecEnter.selected = false;
            this.btnElecEnter.Size = new System.Drawing.Size(53, 40);
            this.btnElecEnter.TabIndex = 70;
            this.btnElecEnter.Text = "Enter";
            this.btnElecEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnElecEnter.Textcolor = System.Drawing.Color.Black;
            this.btnElecEnter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElecEnter.Click += new System.EventHandler(this.btnElecEnter_Click);
            // 
            // lbInputElec
            // 
            this.lbInputElec.Depth = 0;
            this.lbInputElec.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbInputElec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbInputElec.Location = new System.Drawing.Point(3, 26);
            this.lbInputElec.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbInputElec.Name = "lbInputElec";
            this.lbInputElec.Size = new System.Drawing.Size(132, 18);
            this.lbInputElec.TabIndex = 84;
            this.lbInputElec.Text = "Electric Number:";
            // 
            // txtElecNum
            // 
            this.txtElecNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtElecNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElecNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtElecNum.HintForeColor = System.Drawing.Color.Empty;
            this.txtElecNum.HintText = "";
            this.txtElecNum.isPassword = false;
            this.txtElecNum.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtElecNum.LineIdleColor = System.Drawing.Color.Gray;
            this.txtElecNum.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtElecNum.LineThickness = 4;
            this.txtElecNum.Location = new System.Drawing.Point(135, 9);
            this.txtElecNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtElecNum.Name = "txtElecNum";
            this.txtElecNum.Size = new System.Drawing.Size(62, 35);
            this.txtElecNum.TabIndex = 88;
            this.txtElecNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtElecNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElecNum_KeyPress);
            // 
            // ckbVehicle
            // 
            this.ckbVehicle.AutoSize = true;
            this.ckbVehicle.Location = new System.Drawing.Point(249, 173);
            this.ckbVehicle.Name = "ckbVehicle";
            this.ckbVehicle.Size = new System.Drawing.Size(15, 14);
            this.ckbVehicle.TabIndex = 96;
            this.ckbVehicle.UseVisualStyleBackColor = true;
            this.ckbVehicle.CheckedChanged += new System.EventHandler(this.ckbVehicle_CheckedChanged);
            // 
            // ckbWater
            // 
            this.ckbWater.AutoSize = true;
            this.ckbWater.Location = new System.Drawing.Point(80, 173);
            this.ckbWater.Name = "ckbWater";
            this.ckbWater.Size = new System.Drawing.Size(15, 14);
            this.ckbWater.TabIndex = 96;
            this.ckbWater.UseVisualStyleBackColor = true;
            this.ckbWater.CheckedChanged += new System.EventHandler(this.ckbWater_CheckedChanged);
            // 
            // ckbRoom
            // 
            this.ckbRoom.AutoSize = true;
            this.ckbRoom.Location = new System.Drawing.Point(379, 173);
            this.ckbRoom.Name = "ckbRoom";
            this.ckbRoom.Size = new System.Drawing.Size(15, 14);
            this.ckbRoom.TabIndex = 95;
            this.ckbRoom.UseVisualStyleBackColor = true;
            this.ckbRoom.CheckedChanged += new System.EventHandler(this.ckbRoom_CheckedChanged);
            // 
            // lbSum
            // 
            this.lbSum.Depth = 0;
            this.lbSum.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSum.Location = new System.Drawing.Point(435, 493);
            this.lbSum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(104, 18);
            this.lbSum.TabIndex = 80;
            this.lbSum.Text = "Sum:";
            // 
            // txtSum
            // 
            this.txtSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSum.Enabled = false;
            this.txtSum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSum.HintForeColor = System.Drawing.Color.Empty;
            this.txtSum.HintText = "";
            this.txtSum.isPassword = false;
            this.txtSum.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSum.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSum.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSum.LineThickness = 4;
            this.txtSum.Location = new System.Drawing.Point(392, 515);
            this.txtSum.Margin = new System.Windows.Forms.Padding(4);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(154, 35);
            this.txtSum.TabIndex = 87;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbInvoiceID
            // 
            this.lbInvoiceID.Depth = 0;
            this.lbInvoiceID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbInvoiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbInvoiceID.Location = new System.Drawing.Point(6, 29);
            this.lbInvoiceID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbInvoiceID.Name = "lbInvoiceID";
            this.lbInvoiceID.Size = new System.Drawing.Size(104, 18);
            this.lbInvoiceID.TabIndex = 80;
            this.lbInvoiceID.Text = "Invoice ID:";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceID.Enabled = false;
            this.txtInvoiceID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInvoiceID.HintForeColor = System.Drawing.Color.Empty;
            this.txtInvoiceID.HintText = "";
            this.txtInvoiceID.isPassword = false;
            this.txtInvoiceID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtInvoiceID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtInvoiceID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtInvoiceID.LineThickness = 4;
            this.txtInvoiceID.Location = new System.Drawing.Point(117, 12);
            this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(147, 35);
            this.txtInvoiceID.TabIndex = 87;
            this.txtInvoiceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.White;
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.cbYear.Location = new System.Drawing.Point(392, 107);
            this.cbYear.MaximumSize = new System.Drawing.Size(121, 0);
            this.cbYear.MaxLength = 10;
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 32);
            this.cbYear.Sorted = true;
            this.cbYear.TabIndex = 94;
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.Color.White;
            this.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(117, 107);
            this.cbMonth.MaximumSize = new System.Drawing.Size(121, 0);
            this.cbMonth.MaxLength = 10;
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 32);
            this.cbMonth.TabIndex = 94;
            // 
            // lnDescription
            // 
            this.lnDescription.Depth = 0;
            this.lnDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lnDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnDescription.Location = new System.Drawing.Point(6, 206);
            this.lnDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lnDescription.Name = "lnDescription";
            this.lnDescription.Size = new System.Drawing.Size(104, 21);
            this.lnDescription.TabIndex = 84;
            this.lnDescription.Text = "Description:";
            // 
            // lbWater
            // 
            this.lbWater.Depth = 0;
            this.lbWater.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbWater.Location = new System.Drawing.Point(6, 169);
            this.lbWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbWater.Name = "lbWater";
            this.lbWater.Size = new System.Drawing.Size(68, 18);
            this.lbWater.TabIndex = 84;
            this.lbWater.Text = "Water:";
            // 
            // lbRoom
            // 
            this.lbRoom.Depth = 0;
            this.lbRoom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbRoom.Location = new System.Drawing.Point(295, 169);
            this.lbRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(68, 18);
            this.lbRoom.TabIndex = 84;
            this.lbRoom.Text = "Room:";
            // 
            // lbYear
            // 
            this.lbYear.Depth = 0;
            this.lbYear.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbYear.Location = new System.Drawing.Point(295, 114);
            this.lbYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(68, 18);
            this.lbYear.TabIndex = 84;
            this.lbYear.Text = "Year:";
            // 
            // lbMonth
            // 
            this.lbMonth.Depth = 0;
            this.lbMonth.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMonth.Location = new System.Drawing.Point(6, 114);
            this.lbMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(68, 18);
            this.lbMonth.TabIndex = 84;
            this.lbMonth.Text = "Month:";
            // 
            // lbVehicleInvoice
            // 
            this.lbVehicleInvoice.Depth = 0;
            this.lbVehicleInvoice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbVehicleInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVehicleInvoice.Location = new System.Drawing.Point(152, 169);
            this.lbVehicleInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbVehicleInvoice.Name = "lbVehicleInvoice";
            this.lbVehicleInvoice.Size = new System.Drawing.Size(68, 18);
            this.lbVehicleInvoice.TabIndex = 84;
            this.lbVehicleInvoice.Text = "Vehicle:";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 710);
            this.Controls.Add(this.pnData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.pnData.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbInvoice.ResumeLayout(false);
            this.gbInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerFee)).EndInit();
            this.pnElectric.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel lbCustomer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustomerId;
        private Bunifu.Framework.UI.BunifuFlatButton btnChooseCus;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private MaterialSkin.Controls.MaterialLabel lbPhone;
        private MaterialSkin.Controls.MaterialLabel lbSex;
        private MaterialSkin.Controls.MaterialLabel lbVehicle;
        private MaterialSkin.Controls.MaterialLabel llbAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private MaterialSkin.Controls.MaterialLabel lbName;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSerFee;
        private System.Windows.Forms.GroupBox gbInvoice;
        private MaterialSkin.Controls.MaterialLabel lbInvoiceID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtInvoiceID;
        private System.Windows.Forms.ComboBox cbMonth;
        private MaterialSkin.Controls.MaterialLabel lbMonth;
        private System.Windows.Forms.CheckBox ckbVehicle;
        private System.Windows.Forms.CheckBox ckbWater;
        private System.Windows.Forms.CheckBox ckbRoom;
        private MaterialSkin.Controls.MaterialLabel lbWater;
        private MaterialSkin.Controls.MaterialLabel lbRoom;
        private MaterialSkin.Controls.MaterialLabel lbVehicleInvoice;
        private System.Windows.Forms.Panel pnElectric;
        private Bunifu.Framework.UI.BunifuFlatButton btnElecEnter;
        private MaterialSkin.Controls.MaterialLabel lbInputElec;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtElecNum;
        private MaterialSkin.Controls.MaterialLabel lbCusId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCusIDInvoice;
        private System.Windows.Forms.ComboBox cbYear;
        private MaterialSkin.Controls.MaterialLabel lbYear;
        private System.Windows.Forms.RichTextBox txtDescription;
        private MaterialSkin.Controls.MaterialLabel lnDescription;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private MaterialSkin.Controls.MaterialLabel lbRoomID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRoom;
        private MaterialSkin.Controls.MaterialLabel lbSum;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSum;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistory;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
    }
}