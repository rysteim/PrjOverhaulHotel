using Guna.UI2.WinForms;
using PrjOverhaulHotel.Form_for_Guests;
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
        int userID = UserAccount.getUserID();

        public FrmStaffDashboard()
        {
            InitializeComponent();
        }

        private void FrmStaffDashboard_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            maximizeButtons();
            statusOnline();
            displayProfile();
            displayDetails();
            roleAccess();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButtons()
        {
            pnlButtons.Size = new System.Drawing.Size(201, 555);
        }

        private void minimizeButtons()
        {
            pnlButtons.Size = new System.Drawing.Size(60, 555);
        }

        private bool compareButtons()
        {
            if (pnlButtons.Size == new System.Drawing.Size(201, 555))
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
            this.WindowState = FormWindowState.Minimized;
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
            new FrmStaffProfile().Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            new FrmStaffReservation().Show();
            this.Hide();
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            new FrmStaffAP().Show();
            this.Hide();
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            new FrmStaffGuests().Show();
            this.Hide();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            new FrmStaffPersonnel().Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            new FrmStaffRoom().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            statusOnline();
            FrmStartUp startUp = new FrmStartUp();
            this.Close();
            startUp.Show();
        }

        private void displayProfile()
        {
            lblName.Text = UserAccount.getFirstName();
            lblPosition.Text = UserAccount.getRole(); 
            
            string imagePath = UserAccount.getImage();

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                imgProfile.Image = Image.FromFile(imagePath);
            }
            else
            {
                imgProfile.Image = Properties.Resources.rb_8551;
            }
        }

        private void btnGuestView_Click(object sender, EventArgs e)
        {
            new FrmGuestDashboard().Show();
            this.Hide();
        }

        private void displayDetails()
        {
            GlobalProcedure.procRoomActive(Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd")));
            //MessageBox.Show($"{DateTime.Now}");
            lblActiveRooms.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
        }

        private void statusOnline()
        {
            GlobalProcedure.procGuestActive(userID, DateTime.Now.ToString("yyyy-MM-dd HH\\:mm\\:ss"));
        }

        private void roleAccess()
        {
            string role = UserAccount.getRole();
            if (role == "Front Desk Staff")
            {
                btnPersonnel.Visible = false;
                btnRooms.Visible = false;
            }
            else if (role == "Housekeeping Staff")
            {
                btnReservation.Visible = false;
                btnPersonnel.Visible = false;
                btnAP.Visible = false;
                btnGuests.Location = new Point(0, 45);
                btnRooms.Location = new Point(0, 90);
            }
            else if (role == "Manager")
            {

            }
        }
    }
}
