using Microsoft.Win32;
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
    public partial class PopUpInfo : Form
    {
        int reservationID, accountID;

        public PopUpInfo()
        {
            InitializeComponent();
            this.reservationID = 1;
        }

        public PopUpInfo(int reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;
        }

        private void PopUpInfo_Load(object sender, EventArgs e)
        {
            getAccountID();
            displayInfo();
        }

        private void displayInfo()
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

            GlobalProcedure.procReservationGetByID(reservationID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                lblBookingDate.Text = $"Booking Date: \n{Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["bookingDate"].ToString()).ToString("MMM dd, yyyy")}";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getAccountID()
        {
            GlobalProcedure.procReservationGetByID(reservationID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                accountID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["accountID"].ToString());
            }
        }
    }
}
