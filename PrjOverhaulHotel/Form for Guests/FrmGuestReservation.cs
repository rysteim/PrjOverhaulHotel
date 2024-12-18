using PrjOverhaulHotel.PopUps;
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
    public partial class FrmGuestReservation : Form
    {
        int userID = UserAccount.getUserID();
        int accountID, reservationID, promoID;
        public FrmGuestReservation()
        {
            InitializeComponent();
        }

        private void FrmGuestReservation_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            getReservationID();
            getIDs();
            displayPromo();
            displayProfile(); 
            displayReservationDetails();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new FrmGuestProfile().Show();
            this.Hide();
        }

        private void statusOnline()
        {
            GlobalProcedure.procGuestActive(userID, DateTime.Now.ToString("yyyy-MM-dd HH\\:mm\\:ss"));
        }

        private void btnTotalRooms_Click(object sender, EventArgs e)
        {
            new PopUpReservationRooms(reservationID).ShowDialog();
            getIDs();
            displayPromo();
            displayReservationDetails();
        }

        private void btnAddons_Click(object sender, EventArgs e)
        {
            new PopUpReservationAddons(reservationID).ShowDialog();
            getIDs();
            displayPromo();
            displayReservationDetails();
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

        private void displayReservationDetails()
        {
            GlobalProcedure.procReservationGetAccountID(reservationID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtRoomsReserved.Text = GlobalProcedure.datHotel.Rows[0]["TOTAL ROOMS"].ToString();
                txtTotalAddons.Text = GlobalProcedure.datHotel.Rows[0]["TOTAL ADDONS"].ToString();
                txtTotalDays.Text = GlobalProcedure.datHotel.Rows[0]["TOTAL DAYS"].ToString();
                txtTotalAmount.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["TOTAL AMOUNT"].ToString()):F2}";
                txtTotalPaid.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["PAID AMOUNT"].ToString()):F2}";
                txtRemainingBalance.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["REMAINING BALANCE"].ToString()):F2}";
                lblBookingDate.Text = "Booking Date: " + Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["BOOKING DATE"]).ToString("MMMM dd, yyyy");
                lblInvoice.Text = "Invoice Number: " + GlobalProcedure.datHotel.Rows[0]["INVOICE"].ToString();
            }
        }

        private void getIDs()
        {
            GlobalProcedure.procReservationGetByID(reservationID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                UserAccount.setPromoID(Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["promoID"]));
                promoID = UserAccount.getPromoID();
            }
        }

        private void btnSelectPromo_Click(object sender, EventArgs e)
        {
            new PopUpPromos().ShowDialog();
            promoID = UserAccount.getPromoID();
            displayPromo();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnSelectPromo.Visible = false;
            btnConfirm.Visible = false;

            Random random = new Random();
            string invoice = "INV" + random.Next(100000, 999999).ToString("D6");

            while (true)
            {
                GlobalProcedure.procReservationCheckInvoice(invoice);
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    invoice = "INV" + random.Next(100000, 999999).ToString("D6");
                }
                else
                {
                    break;
                }
            }

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            GlobalProcedure.procReservationAdd(userID, promoID, invoice, date);
            GlobalProcedure.procReservationGetByAccountID(userID, invoice);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                reservationID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString());
                btnAddons.Visible = true;
                btnTotalRooms.Visible = true;
                displayReservationDetails();
            }
        }

        private void displayPromo()
        {
            GlobalProcedure.procPromoGetByID(promoID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtPromoName.Text = GlobalProcedure.datHotel.Rows[0]["promoName"].ToString();
                lblPromoDescription.Text = GlobalProcedure.datHotel.Rows[0]["description"].ToString();
                txtPromoDiscount.Text = $"{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["discount"].ToString()):F2}%";
            }
        }

        private void getReservationID()
        {
            GlobalProcedure.procReservationCurrent(userID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                reservationID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["RESERVATION_ID"]);
                string status = GlobalProcedure.datHotel.Rows[0]["RESERVATION STATUS"].ToString();
                if (status == "For Approval")
                {
                    btnSelectPromo.Visible = false;
                    btnConfirm.Visible = false;
                    pnlNoReservation.Visible = true;
                    pnlReserved.Visible = false;
                }
                else
                {
                    pnlReserved.Visible = true;
                    pnlNoReservation.Visible = false;
                    lblMessage.Text += $"\n\nStatus: {status}";
                }
            }
        }
    }
}
