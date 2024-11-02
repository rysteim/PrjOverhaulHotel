using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjOverhaulHotel
{
    public partial class FrmStaffDashboard : Form
    {
        public FrmStaffDashboard()
        {
            InitializeComponent();
        }

        private void FrmStaffDashboard_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButtons()
        {
            pnlButtons.Size = new System.Drawing.Size(200, 555);
        }

        private void minimizeButtons()
        {
            pnlButtons.Size = new System.Drawing.Size(60, 555);
        }

        private bool compareButtons()
        {
            if (pnlButtons.Size == new System.Drawing.Size(200, 555))
            {
                return true;
            }
            else
            {
                maximizeButtons();
                return false;
            }
        }

        private void button_Move(object sender, EventArgs e)
        {
            compareButtons();
        }

        private void pnlButtons_MouseLeave(object sender, EventArgs e)
        {
            minimizeButtons();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile.FillColor = Color.FromArgb(0, 135, 97);
            btnProfile.FillColor2 = Color.FromArgb(0, 135, 97);
            btnProfile.FillColor3 = Color.Black;
            btnProfile.FillColor4 = Color.Black;
            lblName.ForeColor = Color.White;
            lblPosition.ForeColor = Color.White;
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.FillColor = Color.White;
            btnProfile.FillColor2 = Color.White;
            btnProfile.FillColor3 = Color.White;
            btnProfile.FillColor4 = Color.White;
            lblName.ForeColor = Color.Black;
            lblPosition.ForeColor = Color.Black;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "PROFILE";
            pnlProfile.Visible = true;
            pnlDashboard.Visible = false;
            pnlReservation.Visible = false;
            pnlAP.Visible = false;
            pnlGuests.Visible = false;
            pnlPersonnel.Visible = false;
            pnlRooms.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "HOTELLIERE";
            pnlDashboard.Visible = true;
            pnlProfile.Visible = false;
            pnlReservation.Visible = false;
            pnlAP.Visible = false;
            pnlGuests.Visible = false;
            pnlPersonnel.Visible = false;
            pnlRooms.Visible = false;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "RESERVATION";
            pnlReservation.Visible = true;
            pnlDashboard.Visible = false;
            pnlProfile.Visible = false;
            pnlAP.Visible = false;
            pnlGuests.Visible = false;
            pnlPersonnel.Visible = false;
            pnlRooms.Visible = false;
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "ADD-ONS/PROMO";
            pnlAP.Visible = true;
            pnlReservation.Visible = false;
            pnlDashboard.Visible = false;
            pnlProfile.Visible = false;
            pnlGuests.Visible = false;
            pnlPersonnel.Visible = false;
            pnlRooms.Visible = false;
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "GUEST";
            pnlGuests.Visible = true;
            pnlAP.Visible = false;
            pnlReservation.Visible = false;
            pnlDashboard.Visible = false;
            pnlProfile.Visible = false;
            pnlPersonnel.Visible = false;
            pnlRooms.Visible = false;
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "PERSONNEL";
            pnlPersonnel.Visible = true;
            pnlGuests.Visible = false;
            pnlAP.Visible = false;
            pnlReservation.Visible = false;
            pnlDashboard.Visible = false;
            pnlProfile.Visible = false;
            pnlRooms.Visible = false;
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "ROOMS";
            pnlRooms.Visible = true;
            pnlPersonnel.Visible = false;
            pnlGuests.Visible = false;
            pnlAP.Visible = false;
            pnlReservation.Visible = false;
            pnlDashboard.Visible = false;
            pnlProfile.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FrmStartUp().ShowDialog();
            this.Close();
        }
    }
}
