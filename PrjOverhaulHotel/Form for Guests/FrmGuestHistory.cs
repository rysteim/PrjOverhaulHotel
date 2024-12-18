using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class FrmGuestHistory : Form
    {
        int userID = UserAccount.getUserID();
        int reservationID;
        public FrmGuestHistory()
        {
            InitializeComponent();
        }

        private void FrmGuestHistory_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayReservations();
            displayReservationDetails();
            displayProfile();
            maximizeButtons();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new FrmGuestDashboard().Show();
            this.Hide();
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

        private void displayReservations()
        {

            GlobalProcedure.procReservationSeeHistory(userID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                pnlHistory.Visible = true;
                pnlPreview.Visible = false;
                dtgHistory.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgHistory.Rows.Add(
                        row1["RESERVATION_ID"].ToString(),
                        Convert.ToDateTime(row1["BOOKING DATE"].ToString()).ToString("yyyy-MM-dd"),
                        row1["PROMO NAME"].ToString(),
                        row1["INVOICE"].ToString(),
                        row1["TOTAL DAYS"].ToString(),
                        row1["IMAGE"].ToString()
                    );
                }
            }
            else
            {
                dtgHistory.Rows.Clear();
                pnlPreview.Visible = true;
                pnlHistory.Visible = false;
            }
        }

        private void displayReservationDetails()
        {
            if (dtgHistory.Rows.Count > 0)
            {
                GlobalProcedure.procReservationGetAccountID(Convert.ToInt32(dtgHistory.CurrentRow.Cells[0].Value));
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    txtRoomsReserved.Text = GlobalProcedure.datHotel.Rows[0]["TOTAL ROOMS"].ToString();
                    txtTotalAddons.Text = GlobalProcedure.datHotel.Rows[0]["TOTAL ADDONS"].ToString();
                    txtTotalAmount.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["TOTAL AMOUNT"].ToString()):F2}";
                    txtTotalPaid.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["PAID AMOUNT"].ToString()):F2}";
                    txtRemainingBalance.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["REMAINING BALANCE"].ToString()):F2}";
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new FrmGuestProfile().Show();
            this.Hide();
        }

        private void dtgHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayReservationDetails();
        }
    }
}
