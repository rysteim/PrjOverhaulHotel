using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjOverhaulHotel.PopUps
{
    public partial class PopUpReservation : Form
    {
        int accountID, reservationID, promoID;
        public PopUpReservation()
        {
            InitializeComponent();
        }

        public PopUpReservation(int reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseAccount_Click(object sender, EventArgs e)
        {
            new PopUpAccounts().ShowDialog();
            accountID = UserAccount.getAccountID();
            displayDetails();
        }

        private void txtPromoName_MouseClick(object sender, MouseEventArgs e)
        {
            new PopUpPromos().ShowDialog();
            promoID = UserAccount.getPromoID();
            displayPromo();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string invoice = "INV" + random.Next(100000, 999999).ToString("D6");
            GlobalProcedure.procReservationAdd(accountID, promoID, invoice, DateTime.Now.ToString("yyyy-MM-dd"));
            GlobalProcedure.procReservationGetByAccountID(accountID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                reservationID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString());
            }
            displayReservationDetails();
        }

        private void displayDetails()
        {
            GlobalProcedure.procGuestGetByAccountID(accountID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtFullname.Text = GlobalProcedure.datHotel.Rows[0]["FULLNAME"].ToString();
                txtMembership.Text = GlobalProcedure.datHotel.Rows[0]["MEMBERSHIP"].ToString();
                txtContactno.Text = GlobalProcedure.datHotel.Rows[0]["CONTACT NUMBER"].ToString();
                txtEmailadd.Text = GlobalProcedure.datHotel.Rows[0]["EMAIL ADDRESS"].ToString();
                txtAddress.Text = GlobalProcedure.datHotel.Rows[0]["ADDRESS"].ToString();
                txtGender.Text = GlobalProcedure.datHotel.Rows[0]["GENDER"].ToString();
                txtBirthdate.Text = Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["BIRTHDATE"].ToString()).ToString("MMMM dd, yyyy");
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
                lblBookingDate.Text = "Booking Date: " + GlobalProcedure.datHotel.Rows[0]["BOOKING DATE"].ToString();
                lblInvoice.Text = "Invoice Number: " + GlobalProcedure.datHotel.Rows[0]["INVOICE"].ToString();
            }
        }
    }
}
