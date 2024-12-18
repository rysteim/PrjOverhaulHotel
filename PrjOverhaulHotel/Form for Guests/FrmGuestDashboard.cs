using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjOverhaulHotel.Form_for_Guests
{
    public partial class FrmGuestDashboard : Form
    {
        int userID = UserAccount.getUserID();
        int reservationID;
        public FrmGuestDashboard()
        {
            InitializeComponent();
        }

        private void FrmGuestDashboard_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            getReservationID();
            displayProfile();
            maximizeButtons();
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
            this.WindowState = FormWindowState.Normal;
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

        private void roleAccess()
        {
            string role = UserAccount.getRole();
            if (role == "Guest")
            {
                pnlReservation.Visible = true;
                btnEmployeeView.Visible = false;
            }
            else
            {
                btnEmployeeView.Visible = true;
                pnlReservation.Visible = false;
            }
        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            new FrmGuestReservation().Show();
            this.Hide();
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            new FrmGuestAP().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            statusOnline();
            new FrmStartUp().Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new FrmGuestHistory().Show();
            this.Hide();
        }

        private void statusOnline()
        {
            GlobalProcedure.procGuestActive(userID, DateTime.Now.ToString("yyyy-MM-dd HH\\:mm\\:ss"));
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new FrmGuestProfile().Show();
            this.Hide();
        }

        private void btnEmployeeView_Click(object sender, EventArgs e)
        {
            new FrmStaffDashboard().Show();
            this.Close();
        }

        private void getReservationID()
        {
            GlobalProcedure.procReservationCurrent(userID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                reservationID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["RESERVATION_ID"]);
                string status = GlobalProcedure.datHotel.Rows[0]["RESERVATION STATUS"].ToString();
                if (status == "Approved")
                {
                    btnCheckOut.Visible = true;
                    lblMessage.Visible = false;
                }
                else 
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = $"Status: {status}";
                    btnCheckOut.Visible = false;
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}
