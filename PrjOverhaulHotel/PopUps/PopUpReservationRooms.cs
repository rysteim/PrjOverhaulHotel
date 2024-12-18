using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjOverhaulHotel.PopUps
{
    public partial class PopUpReservationRooms : Form
    {
        int reservationID, prevRoomID;
        double totalDays, pricePerDay, roomPrice;
        public PopUpReservationRooms()
        {
            InitializeComponent();
        }
        public PopUpReservationRooms(int reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;
        }

        private void PopUpReservationAddons_Load(object sender, EventArgs e)
        {
            dtmIn.Value = DateTime.Now;
            dtmOut.Value = DateTime.Now;

            GlobalProcedure.fncDatabaseConnection();
            displayRoomReservation();
            btnEditSave.Visible = false;
            btnAddSave.Visible = false;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
        }

        private void displayRoomReservation()
        {
            GlobalProcedure.procRoomReservationData(reservationID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgRooms.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgRooms.Rows.Add(
                        row1["RRID"].ToString(),
                        row1["ROOM_NAME"].ToString(),
                        row1["ROOM_TYPE"].ToString(),
                        $"₱{Convert.ToDouble(row1["PRICE_PER_DAY"].ToString()):F2}",
                        $"₱{Convert.ToDouble(row1["TOTAL_PRICE"].ToString()):F2}",
                        Convert.ToDateTime(row1["CHECK-IN_DATE"].ToString()).ToString("yyyy-MM-dd"),
                        Convert.ToDateTime(row1["CHECK-OUT_DATE"].ToString()).ToString("yyyy-MM-dd")
                    );
                }
            }
            else
            {
                dtgRooms.Rows.Clear();
            }
        }

        private void displayRoomAdd()
        {
            if (UserAccount.getRoomID() > 0)
            {
                GlobalProcedure.procRoomGetByID(UserAccount.getRoomID());
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    txtAddRoomName.Text = GlobalProcedure.datHotel.Rows[0]["roomName"].ToString();
                    txtAddRoomType.Text = GlobalProcedure.datHotel.Rows[0]["roomType"].ToString();
                    txtAddPricePerDay.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString()):F2}";
                    pricePerDay = Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString());
                    txtAddCheckIn.Text = dtmIn.Value.ToString("MMMM dd, yyyy");
                    txtAddCheckOut.Text = dtmOut.Value.ToString("MMMM dd, yyyy");
                    displayRoomPriceAdd();
                }
            }
        }

        private void displayRoomEdit()
        {
            GlobalProcedure.procRoomGetByName(dtgRooms.CurrentRow.Cells[1].Value.ToString());
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                UserAccount.setRoomID(Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString()));
                txtEditRoomName.Text = GlobalProcedure.datHotel.Rows[0]["roomName"].ToString();
                txtEditRoomType.Text = GlobalProcedure.datHotel.Rows[0]["roomType"].ToString();
                txtEditPricePerDay.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString()):F2}";
                pricePerDay = Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString());
                txtEditCheckIn.Text = dtmIn.Value.ToString("MMMM dd, yyyy");
                txtEditCheckOut.Text = dtmOut.Value.ToString("MMMM dd, yyyy");
                displayRoomPriceEdit();
            }
        }

        private void displayRoomPriceAdd()
        {
            TimeSpan dateDifference = dtmOut.Value - dtmIn.Value;

            totalDays = (double)dateDifference.TotalDays;

            roomPrice = totalDays * pricePerDay;

            if (roomPrice > 0) 
                txtAddRoomPrice.Text = $"₱{roomPrice:F2}";
            else
                txtAddRoomPrice.Text = "Invalid dates.";
        }

        private void displayRoomPriceEdit()
        {
            TimeSpan dateDifference = dtmOut.Value - dtmIn.Value;

            totalDays = (double)dateDifference.TotalDays;

            roomPrice = totalDays * pricePerDay;

            if (roomPrice > 0)
                txtEditRoomPrice.Text = $"₱{roomPrice:F2}";
            else
                txtEditRoomPrice.Text = "Invalid dates.";
        }

        private void dtgRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtRoomname.Text = dtgRooms.CurrentRow.Cells[1].Value.ToString();
                txtRoomType.Text = dtgRooms.CurrentRow.Cells[2].Value.ToString();
                txtTotalPrice.Text = dtgRooms.CurrentRow.Cells[3].Value.ToString();
                txtPricePerDay.Text = dtgRooms.CurrentRow.Cells[4].Value.ToString();
                txtCheckinDate.Text = $"{Convert.ToDateTime(dtgRooms.CurrentRow.Cells[5].Value.ToString()).ToString("MMMM dd, yyyy")}";
                txtCheckoutDate.Text = $"{Convert.ToDateTime(dtgRooms.CurrentRow.Cells[6].Value.ToString()).ToString("MMMM dd, yyyy")}";
            }
        }

        private void clearTextFields()
        {
            txtRoomname.Clear();
            txtRoomType.Clear();
            txtTotalPrice.Clear();
            txtPricePerDay.Clear();
            txtCheckinDate.Clear();
            txtCheckoutDate.Clear();
        }

        private void clearAddFields()
        {
            txtAddRoomName.Clear();
            txtAddRoomType.Clear();
            txtAddPricePerDay.Clear();
            txtAddRoomPrice.Clear();
        }

        private void clearEditFields()
        {
            txtEditRoomName.Clear();
            txtEditRoomType.Clear();
            txtEditPricePerDay.Clear();
            txtEditRoomPrice.Clear();
        }

        private void roomStatusUpdate()
        {
            GlobalProcedure.procRoomCheckRoomStatus(reservationID, DateTime.Now.ToString("yyyy-MM-dd"));
        }

        private void pnlLogin_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            new PopUpRooms(dtmIn.Value, dtmOut.Value).ShowDialog();

            if (UserAccount.getRoomID() > 0)
            {
                pnlAdd.Visible = true;
                btnAddSave.Visible = true;
                btnAddReservation.Visible = false;
                pnlDetails.Visible = false;
                pnlEdit.Visible = false;
                btnEditSave.Visible = false;
                btnEditReservation.Visible = false;
                btnDeleteReservation.Visible = false;
            }

            displayRoomAdd();
        }

        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            btnEditSave.Visible = true;
            btnEditReservation.Visible = false;
            pnlDetails.Visible = false;
            pnlAdd.Visible = false;
            btnAddSave.Visible = false;
            btnAddReservation.Visible = false;
            btnDeleteReservation.Visible = false;

            GlobalProcedure.procRoomGetByName(dtgRooms.CurrentRow.Cells[1].Value.ToString());
            if (GlobalProcedure.datHotel.Rows.Count > 0)
                prevRoomID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString());

                displayRoomEdit();
            displayRoomPriceEdit();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procRoomReservationDelete(Convert.ToInt32(dtgRooms.CurrentRow.Cells[0].Value));

            displayRoomReservation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procReservationGetTotalAmount(reservationID);
            this.Close();
        }

        private void txtEditRoomName_MouseClick(object sender, MouseEventArgs e)
        {
            new PopUpRooms(dtmIn.Value, dtmOut.Value).ShowDialog();
            //displayRoomEdit();
            GlobalProcedure.procRoomGetByID(UserAccount.getRoomID());
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtEditRoomName.Text = GlobalProcedure.datHotel.Rows[0]["roomName"].ToString();
                txtEditRoomType.Text = GlobalProcedure.datHotel.Rows[0]["roomType"].ToString();
                txtEditPricePerDay.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString()):F2}";
                pricePerDay = Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString());
                displayRoomPriceEdit();
            }
        }
        private void txtAddRoomName_MouseClick(object sender, MouseEventArgs e)
        {
            new PopUpRooms(dtmIn.Value, dtmOut.Value).ShowDialog();
            GlobalProcedure.procRoomGetByID(UserAccount.getRoomID());
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtAddRoomName.Text = GlobalProcedure.datHotel.Rows[0]["roomName"].ToString();
                txtAddRoomType.Text = GlobalProcedure.datHotel.Rows[0]["roomType"].ToString();
                txtAddPricePerDay.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString()):F2}";
                pricePerDay = Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString());
                displayRoomPriceAdd();
            }
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtAddRoomPrice.Text != "Invalid dates.")
            {
                btnAddReservation.Visible = true;
                btnEditReservation.Visible = true;
                btnDeleteReservation.Visible = true;
                pnlDetails.Visible = true;
                btnAddSave.Visible = false;
                btnEditSave.Visible = false;
                pnlAdd.Visible = false;
                pnlEdit.Visible = false;

                GlobalProcedure.procRoomReservationAdd(reservationID, UserAccount.getRoomID(),
                    dtmIn.Value.ToString("yyyy-MM-dd"), dtmOut.Value.ToString("yyyy-MM-dd"), roomPrice);
                GlobalProcedure.procReservationGetTotalDays(reservationID);
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                    GlobalProcedure.procReservationSetTotalDays(reservationID, Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["TOTAL DAYS"].ToString()));

                UserAccount.setRoomID(-1);

                roomPrice = 0;
                displayRoomReservation();
                roomStatusUpdate();
                clearAddFields();
            }
            else
            {
                MessageBox.Show("Invalid dates. Please try again!");
            }
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (txtEditRoomPrice.Text != "Invalid dates.")
            {
                btnAddReservation.Visible = true;
                btnEditReservation.Visible = true;
                pnlDetails.Visible = true;
                btnDeleteReservation.Visible = true;
                btnAddSave.Visible = false;
                btnEditSave.Visible = false;
                pnlAdd.Visible = false;
                pnlEdit.Visible = false;

                GlobalProcedure.procRoomReservationUpdate(Convert.ToInt32(dtgRooms.CurrentRow.Cells[0].Value), reservationID, UserAccount.getRoomID(),
                    dtmIn.Value.ToString("yyyy-MM-dd"), dtmOut.Value.ToString("yyyy-MM-dd"), roomPrice);
                GlobalProcedure.procReservationGetTotalAmount(reservationID);

                UserAccount.setRoomID(-1);
                roomPrice = 0;
                displayRoomReservation();
                roomStatusUpdate();
                clearEditFields();
            }
            else
            {
                MessageBox.Show("Invalid dates. Please try again!");
            }
        }
    }
}
