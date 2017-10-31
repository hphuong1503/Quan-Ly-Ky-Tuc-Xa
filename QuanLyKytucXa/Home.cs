using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKytucXa
{
    public partial class Home : MaterialForm
    {

        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        // this function to embeded form to panel
        public void embeded(Form frmEmbeded)
        {
            pnMain.Controls.Clear();
            frmEmbeded.FormBorderStyle = FormBorderStyle.None;
            frmEmbeded.TopLevel = false;
            frmEmbeded.Visible = true;
            frmEmbeded.Dock = DockStyle.Fill;
            pnMain.Controls.Add(frmEmbeded);
            pnMain.Show();
        }
        private Login frmLogin = new Login();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.ShowDialog();
            this.Visible = true;


        }
        private Room frmRoom = new Room();
        private Customer frmCustomer = new Customer();
        private Invoice frmInvoice = new Invoice();
        private ServiceFee frmService = new ServiceFee();
        private Reservation frmReservation = new Reservation();
        private Edit frmEdit = new Edit();

        static Color HOVER_MENU_COLOR = ColorTranslator.FromHtml("#FBDA6C");
        static System.Drawing.Color MENU_COLOR = System.Drawing.Color.White;

        public void choose(Panel panel)
        {
            pnRoom.BackColor = MENU_COLOR;
            pnCustomer.BackColor = MENU_COLOR;
            pnReservation.BackColor = MENU_COLOR;
            pnInvoice.BackColor = MENU_COLOR;
            pnEdit.BackColor = MENU_COLOR;
            panel.BackColor = HOVER_MENU_COLOR;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            embeded(frmRoom);
            choose(pnRoom);
           
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            embeded(frmCustomer);
            frmCustomer.load();
            choose(pnCustomer);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            embeded(frmInvoice);
            choose(pnInvoice);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            embeded(frmReservation);
            choose(pnReservation);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            embeded(frmEdit);
            choose(pnEdit);
        }

        private void buttom_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.ShowDialog();
            this.Visible = true;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
