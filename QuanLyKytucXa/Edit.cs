using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class Edit : MaterialForm
    {
        public Edit()
        {
            InitializeComponent();
            btnShow.Visible = false;
            System.Drawing.Color HOVER_COLOR = System.Drawing.ColorTranslator.FromHtml("#6CC3C1");
            System.Drawing.Color MENU_COLOR = System.Drawing.ColorTranslator.FromHtml("#6CC3C1");
        }
        public void embeded(Form frmEmbeded)
        {
            //foreach (Control ctl in panel3.Controls)
            //ctl.Dispose();
            pnEdit.Controls.Clear();//Xõa các control trong form cũ
            frmEmbeded.FormBorderStyle = FormBorderStyle.None;
            frmEmbeded.TopLevel = false;//quan trọng là dòng này thiếu là chít
            frmEmbeded.Visible = true;
            frmEmbeded.Dock = DockStyle.Fill;
            pnEdit.Controls.Add(frmEmbeded);//thêm form mới vào panel
            pnEdit.Show();
        }
        private Account frmACC = new Account();
        private ServiceFee frmServiceFee = new ServiceFee();
        //private RentType frmRentType = new RentType();
        //private Vehicle frmVehicle = new Vehicle();
        System.Drawing.Color PN_LEFT_COLOR = System.Drawing.ColorTranslator.FromHtml("#FBDA6C");
        System.Drawing.Color PN_LEFT_HOVER_COLOR = System.Drawing.ColorTranslator.FromHtml("#6CC3C1");
        private void btnRoomType_Click(object sender, EventArgs e)
        {
            embeded(frmACC);
            frmACC.Dock = System.Windows.Forms.DockStyle.Fill;
            pnLeft.Size = new System.Drawing.Size(19, 600);
            pnRoomType.Visible = false;
            pnRentType.Visible = false;
            pnServiceFee.Visible = false;
            pnVehicle.Visible = false;
            btnShow.Visible = true;
            pnRoomType.BackColor = PN_LEFT_HOVER_COLOR;
            pnRentType.BackColor = PN_LEFT_COLOR;
            pnServiceFee.BackColor = PN_LEFT_COLOR;
            pnVehicle.BackColor = PN_LEFT_COLOR;
        }

        private void btnServiceFee_Click(object sender, EventArgs e)
        {
            embeded(frmServiceFee);
            frmServiceFee.Dock = System.Windows.Forms.DockStyle.Fill;
            pnLeft.Size = new System.Drawing.Size(19, 600);

            pnRoomType.Visible = false;
            pnRentType.Visible = false;
            pnServiceFee.Visible = false;
            pnVehicle.Visible = false;
            btnShow.Visible = true;

            pnRoomType.BackColor = PN_LEFT_COLOR;
            pnRentType.BackColor = PN_LEFT_COLOR;
            pnServiceFee.BackColor = PN_LEFT_HOVER_COLOR;
            pnVehicle.BackColor = PN_LEFT_COLOR;
        }
        private void btnRentType_Click(object sender, EventArgs e)
        {
            //embeded(frmRentType);
            //frmRentType.Dock = System.Windows.Forms.DockStyle.Fill;
            pnLeft.Size = new System.Drawing.Size(19, 600);

            pnRoomType.Visible = false;
            pnRentType.Visible = false;
            pnServiceFee.Visible = false;
            pnVehicle.Visible = false;
            btnShow.Visible = true;

            pnRoomType.BackColor = PN_LEFT_COLOR;
            pnRentType.BackColor = PN_LEFT_HOVER_COLOR;
            pnServiceFee.BackColor = PN_LEFT_COLOR;
            pnVehicle.BackColor = PN_LEFT_COLOR;
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            //embeded(frmVehicle);
            //frmVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            pnLeft.Size = new System.Drawing.Size(19, 600);

            pnRoomType.Visible = false;
            pnRentType.Visible = false;
            pnServiceFee.Visible = false;
            pnVehicle.Visible = false;
            btnShow.Visible = true;

            pnRoomType.BackColor = PN_LEFT_COLOR;
            pnRentType.BackColor = PN_LEFT_COLOR;
            pnServiceFee.BackColor = PN_LEFT_COLOR;
            pnVehicle.BackColor = PN_LEFT_HOVER_COLOR;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            pnLeft.Size = new System.Drawing.Size(64, 600);
            pnRoomType.Visible = true;
            pnRentType.Visible = true;
            pnServiceFee.Visible = true;
            pnVehicle.Visible = true;
            pnRoomType.Size = new System.Drawing.Size(64, 150);
            pnRentType.Size = new System.Drawing.Size(64, 150);
            pnServiceFee.Size = new System.Drawing.Size(64, 150);
            pnVehicle.Size = new System.Drawing.Size(64, 150);
            btnShow.Visible = false;
        }

        private void pnRoomType_MouseHover(object sender, EventArgs e)
        {
            pnRoomType.BackColor = PN_LEFT_HOVER_COLOR;
            pnRentType.BackColor = PN_LEFT_COLOR;
            pnServiceFee.BackColor = PN_LEFT_COLOR;
            pnVehicle.BackColor = PN_LEFT_COLOR;
        }

        private void pnServiceFee_MouseHover(object sender, EventArgs e)
        {
            pnRoomType.BackColor = PN_LEFT_COLOR;
            pnRentType.BackColor = PN_LEFT_COLOR;
            pnServiceFee.BackColor = PN_LEFT_HOVER_COLOR;
            pnVehicle.BackColor = PN_LEFT_COLOR;
        }

        private void pnRentType_MouseHover(object sender, EventArgs e)
        {
            pnRoomType.BackColor = PN_LEFT_COLOR;
            pnRentType.BackColor = PN_LEFT_HOVER_COLOR;
            pnServiceFee.BackColor = PN_LEFT_COLOR;
            pnVehicle.BackColor = PN_LEFT_COLOR;
        }

        private void pnVehicle_MouseHover(object sender, EventArgs e)
        {
            pnRoomType.BackColor = PN_LEFT_COLOR;
            pnRentType.BackColor = PN_LEFT_COLOR;
            pnServiceFee.BackColor = PN_LEFT_COLOR;
            pnVehicle.BackColor = PN_LEFT_HOVER_COLOR;
        }
    }
}
