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
    public partial class PopUpReservationRooms : Form
    {
        public PopUpReservationRooms()
        {
            InitializeComponent();
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
            GlobalProcedure.procRoomReservationData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgRooms.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgRooms.Rows.Add(
                        row1["ROOM RESERVATION ID"].ToString(),
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

        private void pnlLogin_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            btnAddSave.Visible = true;
            btnEditReservation.Visible = true;
            pnlDetails.Visible = false;
            pnlEdit.Visible = false;
            btnEditSave.Visible = false;
            btnAddReservation.Visible = false;
        }

        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            btnEditSave.Visible = true;
            btnAddReservation.Visible = true;
            pnlDetails.Visible = false;
            pnlAdd.Visible = false;
            btnAddSave.Visible = false;
            btnEditReservation.Visible = false;
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            btnAddReservation.Visible = true;
            btnEditReservation.Visible = true;
            pnlDetails.Visible = true;
            btnAddSave.Visible = false;
            btnEditSave.Visible = false;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            displayRoomReservation();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            btnAddReservation.Visible = true;
            btnEditReservation.Visible = true;
            pnlDetails.Visible = true;
            btnAddSave.Visible = false;
            btnEditSave.Visible = false;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            displayRoomReservation();
        }
    }
}
