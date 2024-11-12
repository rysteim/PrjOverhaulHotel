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
        int reservationID;
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
            GlobalProcedure.fncDatabaseConnection();
            displayRoomReservation();
            btnEditSave.Visible = false;
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
                        row1["ROOM NAME"].ToString(),
                        row1["ROOM TYPE"].ToString(),
                        $"₱{Convert.ToDouble(row1["PRICE PER DAY"].ToString()):F2}",
                        $"₱{Convert.ToDouble(row1["TOTAL PRICE"].ToString()):F2}",
                        Convert.ToDateTime(row1["CHECK-IN DATE"].ToString()).ToString("yyyy-MM-dd"),
                        Convert.ToDateTime(row1["CHECK-OUT DATE"].ToString()).ToString("yyyy-MM-dd")
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
            GlobalProcedure.procRoomGetByID(UserAccount.getRoomID());
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtAddRoomName.Text = GlobalProcedure.datHotel.Rows[0]["roomName"].ToString();
                txtAddRoomType.Text = GlobalProcedure.datHotel.Rows[0]["roomType"].ToString();
                txtAddPricePerDay.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString()):F2}";
                pricePerDay = Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString());
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
                dtmEditCheckin.Value = Convert.ToDateTime(dtgRooms.CurrentRow.Cells[5].Value);
                dtmEditCheckout.Value = Convert.ToDateTime(dtgRooms.CurrentRow.Cells[6].Value);
                displayRoomPriceEdit();
            }
        }

        private void displayRoomPriceAdd()
        {
            TimeSpan dateDifference = dtmAddCheckout.Value - dtmAddCheckin.Value;

            totalDays = (double)dateDifference.TotalDays;

            roomPrice = totalDays * pricePerDay;

            if (roomPrice > 0) 
                txtAddRoomPrice.Text = $"₱{roomPrice:F2}";
            else
                txtEditRoomPrice.Text = "Invalid dates.";
        }

        private void displayRoomPriceEdit()
        {
            TimeSpan dateDifference = dtmEditCheckout.Value - dtmEditCheckin.Value;

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

        private void pnlLogin_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            btnAddSave.Visible = true;
            btnAddReservation.Visible = false;
            pnlDetails.Visible = false;
            pnlEdit.Visible = false;
            btnEditSave.Visible = false;
            btnEditReservation.Visible = false;
            btnDeleteReservation.Visible = false;
            btnCancel.Visible = false;

            new PopUpRooms().ShowDialog();
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
            btnCancel.Visible = false;

            displayRoomEdit();
            displayRoomPriceEdit();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procRoomReservationDelete(Convert.ToInt32(dtgRooms.CurrentRow.Cells[0].Value));

            displayRoomReservation();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            btnAddReservation.Visible = true;
            btnEditReservation.Visible = true;
            btnDeleteReservation.Visible = true;
            btnCancel.Visible = true;
            pnlDetails.Visible = true;
            btnAddSave.Visible = false;
            btnEditSave.Visible = false;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;

            GlobalProcedure.procRoomReservationAdd(reservationID, UserAccount.getRoomID(), 
                dtmAddCheckin.Value.ToString("yyyy-MM-dd"), dtmAddCheckout.Value.ToString("yyyy-MM-dd"), roomPrice);

            roomPrice = 0;
            displayRoomReservation();
            clearAddFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtmAddCheck_ValueChanged(object sender, EventArgs e)
        {
            displayRoomPriceAdd();
        }

        private void dtmEditCheck_ValueChanged(object sender, EventArgs e)
        {
            displayRoomPriceEdit();
        }

        private void txtEditRoomName_MouseClick(object sender, MouseEventArgs e)
        {
            new PopUpRooms().ShowDialog();
            displayRoomEdit();
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

        private void cmbEditRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            btnAddReservation.Visible = true;
            btnEditReservation.Visible = true;
            pnlDetails.Visible = true;
            btnDeleteReservation.Visible = true;
            btnCancel.Visible = true;
            btnAddSave.Visible = false;
            btnEditSave.Visible = false;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;

            MessageBox.Show($"{UserAccount.getRoomID()}");
            GlobalProcedure.procRoomReservationUpdate(Convert.ToInt32(dtgRooms.CurrentRow.Cells[0].Value), reservationID, UserAccount.getRoomID(),
                dtmEditCheckin.Value.ToString("yyyy-MM-dd"), dtmEditCheckout.Value.ToString("yyyy-MM-dd"), roomPrice);

            roomPrice = 0;
            displayRoomReservation();
            clearEditFields();
        }
    }
}
