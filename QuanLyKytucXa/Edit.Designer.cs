namespace QuanLyKytucXa
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnShow = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnServiceFee = new System.Windows.Forms.Panel();
            this.lbServiceFee = new System.Windows.Forms.Label();
            this.btnServiceFee = new System.Windows.Forms.PictureBox();
            this.pnRentType = new System.Windows.Forms.Panel();
            this.pnVehicle = new System.Windows.Forms.Panel();
            this.pnRoomType = new System.Windows.Forms.Panel();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.btnRoomType = new System.Windows.Forms.PictureBox();
            this.pnLeft.SuspendLayout();
            this.pnServiceFee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnServiceFee)).BeginInit();
            this.pnRoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRoomType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(108)))));
            this.pnLeft.Controls.Add(this.btnShow);
            this.pnLeft.Controls.Add(this.pnServiceFee);
            this.pnLeft.Controls.Add(this.pnRentType);
            this.pnLeft.Controls.Add(this.pnVehicle);
            this.pnLeft.Controls.Add(this.pnRoomType);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(64, 710);
            this.pnLeft.TabIndex = 13;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.Depth = 0;
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShow.Location = new System.Drawing.Point(45, 0);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShow.Name = "btnShow";
            this.btnShow.Primary = false;
            this.btnShow.Size = new System.Drawing.Size(19, 710);
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = ">";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pnServiceFee
            // 
            this.pnServiceFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnServiceFee.BackColor = System.Drawing.Color.Transparent;
            this.pnServiceFee.Controls.Add(this.lbServiceFee);
            this.pnServiceFee.Controls.Add(this.btnServiceFee);
            this.pnServiceFee.Location = new System.Drawing.Point(0, 205);
            this.pnServiceFee.Name = "pnServiceFee";
            this.pnServiceFee.Size = new System.Drawing.Size(64, 150);
            this.pnServiceFee.TabIndex = 33;
            this.pnServiceFee.Click += new System.EventHandler(this.btnServiceFee_Click);
            this.pnServiceFee.MouseHover += new System.EventHandler(this.pnServiceFee_MouseHover);
            // 
            // lbServiceFee
            // 
            this.lbServiceFee.AutoSize = true;
            this.lbServiceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceFee.ForeColor = System.Drawing.Color.Black;
            this.lbServiceFee.Location = new System.Drawing.Point(1, 96);
            this.lbServiceFee.Name = "lbServiceFee";
            this.lbServiceFee.Size = new System.Drawing.Size(64, 13);
            this.lbServiceFee.TabIndex = 27;
            this.lbServiceFee.Text = "Service Fee";
            this.lbServiceFee.MouseHover += new System.EventHandler(this.pnServiceFee_MouseHover);
            // 
            // btnServiceFee
            // 
            this.btnServiceFee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceFee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServiceFee.BackgroundImage")));
            this.btnServiceFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServiceFee.Location = new System.Drawing.Point(8, 44);
            this.btnServiceFee.Name = "btnServiceFee";
            this.btnServiceFee.Size = new System.Drawing.Size(47, 49);
            this.btnServiceFee.TabIndex = 26;
            this.btnServiceFee.TabStop = false;
            this.btnServiceFee.Click += new System.EventHandler(this.btnServiceFee_Click);
            this.btnServiceFee.MouseHover += new System.EventHandler(this.pnServiceFee_MouseHover);
            // 
            // pnRentType
            // 
            this.pnRentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRentType.BackColor = System.Drawing.Color.Transparent;
            this.pnRentType.Location = new System.Drawing.Point(0, 355);
            this.pnRentType.Name = "pnRentType";
            this.pnRentType.Size = new System.Drawing.Size(64, 150);
            this.pnRentType.TabIndex = 33;
            this.pnRentType.Click += new System.EventHandler(this.btnRentType_Click);
            this.pnRentType.MouseHover += new System.EventHandler(this.pnRentType_MouseHover);
            // 
            // pnVehicle
            // 
            this.pnVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnVehicle.BackColor = System.Drawing.Color.Transparent;
            this.pnVehicle.Location = new System.Drawing.Point(1, 505);
            this.pnVehicle.Name = "pnVehicle";
            this.pnVehicle.Size = new System.Drawing.Size(64, 150);
            this.pnVehicle.TabIndex = 33;
            this.pnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            this.pnVehicle.MouseHover += new System.EventHandler(this.pnVehicle_MouseHover);
            // 
            // pnRoomType
            // 
            this.pnRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRoomType.BackColor = System.Drawing.Color.Transparent;
            this.pnRoomType.Controls.Add(this.lbRoomType);
            this.pnRoomType.Controls.Add(this.btnRoomType);
            this.pnRoomType.Location = new System.Drawing.Point(0, 55);
            this.pnRoomType.MinimumSize = new System.Drawing.Size(0, 150);
            this.pnRoomType.Name = "pnRoomType";
            this.pnRoomType.Size = new System.Drawing.Size(65, 150);
            this.pnRoomType.TabIndex = 32;
            this.pnRoomType.Click += new System.EventHandler(this.btnRoomType_Click);
            this.pnRoomType.MouseHover += new System.EventHandler(this.pnRoomType_MouseHover);
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomType.ForeColor = System.Drawing.Color.Black;
            this.lbRoomType.Location = new System.Drawing.Point(3, 89);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(47, 13);
            this.lbRoomType.TabIndex = 25;
            this.lbRoomType.Text = "Account";
            this.lbRoomType.MouseHover += new System.EventHandler(this.pnRoomType_MouseHover);
            // 
            // pnEdit
            // 
            this.pnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEdit.Location = new System.Drawing.Point(64, 0);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(981, 710);
            this.pnEdit.TabIndex = 14;
            // 
            // btnRoomType
            // 
            this.btnRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoomType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoomType.BackgroundImage")));
            this.btnRoomType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoomType.Location = new System.Drawing.Point(7, 37);
            this.btnRoomType.Name = "btnRoomType";
            this.btnRoomType.Size = new System.Drawing.Size(48, 49);
            this.btnRoomType.TabIndex = 22;
            this.btnRoomType.TabStop = false;
            this.btnRoomType.Click += new System.EventHandler(this.btnRoomType_Click);
            this.btnRoomType.MouseHover += new System.EventHandler(this.pnRoomType_MouseHover);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 710);
            this.Controls.Add(this.pnEdit);
            this.Controls.Add(this.pnLeft);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Edit";
            this.Text = "Edit";
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.pnServiceFee.ResumeLayout(false);
            this.pnServiceFee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnServiceFee)).EndInit();
            this.pnRoomType.ResumeLayout(false);
            this.pnRoomType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRoomType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnShow;
        private System.Windows.Forms.Label lbServiceFee;
        private System.Windows.Forms.PictureBox btnServiceFee;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.Panel pnServiceFee;
        private System.Windows.Forms.Panel pnRentType;
        private System.Windows.Forms.Panel pnVehicle;
        private System.Windows.Forms.Panel pnRoomType;
        private System.Windows.Forms.PictureBox btnRoomType;
    }
}