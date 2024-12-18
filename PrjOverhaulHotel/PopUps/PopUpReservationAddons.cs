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
    public partial class PopUpReservationAddons : Form
    {
        int reservationID;
        public PopUpReservationAddons()
        {
            InitializeComponent();
            this.reservationID = -1;
        }

        public PopUpReservationAddons(int reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;
        }

        private void PopUpReservationAddons_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayAddonsReservation();
            btnEditSave.Visible = false;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
        }

        private void displayAddonsReservation()
        {
            if (reservationID > -1)
            {
                GlobalProcedure.procAddonReservationData(reservationID);
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    dtgAddons.Rows.Clear();
                    foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                    {
                        dtgAddons.Rows.Add(
                            row1["RAID"].ToString(),
                            row1["ADDON NAME"].ToString(),
                            row1["DESCRIPTION"].ToString(),
                            $"₱{Convert.ToDouble(row1["PRICE"].ToString()):F2}"
                        );
                    }
                }
                else
                {
                    dtgAddons.Rows.Clear();
                }
            }
        }

        private void dtgAddons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAddonName.Text = dtgAddons.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = dtgAddons.CurrentRow.Cells[3].Value.ToString();
                lblDescription.Text = dtgAddons.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void displayAddonAdd()
        {
            if (UserAccount.getAddonID() > 0)
            {
                GlobalProcedure.procAddonGetByID(UserAccount.getAddonID());
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    txtAddAddonname.Text = GlobalProcedure.datHotel.Rows[0]["addonName"].ToString();
                    txtAddPrice.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["price"].ToString()):F2}";
                    txtAddDescription.Text = GlobalProcedure.datHotel.Rows[0]["description"].ToString();
                }
            }
        }

        private void displayAddonEdit()
        {
            GlobalProcedure.procAddonGetByName(dtgAddons.CurrentRow.Cells[1].Value.ToString());
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                UserAccount.setAddonID(Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString()));
                txtEditAddonname.Text = dtgAddons.CurrentRow.Cells[1].Value.ToString();
                txtEditPrice.Text = dtgAddons.CurrentRow.Cells[3].Value.ToString();
                txtEditDescription.Text = dtgAddons.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void clearFields()
        {
            txtAddonName.Clear();
            txtPrice.Clear();
            lblDescription.Text = "";
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            clearFields();
            pnlAdd.Visible = true;
            btnAddSave.Visible = true;
            btnAddAddon.Visible = false;
            pnlEdit.Visible = false;
            pnlDetails.Visible = false;
            btnEditAddon.Visible = false;
            btnEditSave.Visible = false;
            btnDeleteAddon.Visible = false;

            new PopUpAddons().ShowDialog();
            displayAddonAdd();
        }

        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            clearFields();
            pnlEdit.Visible = true;
            btnEditSave.Visible = true;
            btnEditAddon.Visible = false;
            pnlAdd.Visible = false;
            pnlDetails.Visible = false;
            btnAddAddon.Visible = false;
            btnAddSave.Visible = false;
            btnDeleteAddon.Visible = false;

            displayAddonEdit();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            btnAddAddon.Visible = true;
            btnEditAddon.Visible = true;
            btnDeleteAddon.Visible = true;
            btnCancel.Visible = true;
            pnlDetails.Visible = true;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            btnAddSave.Visible = false;
            btnEditSave.Visible = false;

            string status = "For Approval";
            GlobalProcedure.procAddonReservationAdd(reservationID, UserAccount.getAddonID(), status);
            UserAccount.setAddonID(-1);

            displayAddonsReservation();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            btnAddAddon.Visible = true;
            btnEditAddon.Visible = true;
            btnDeleteAddon.Visible = true;
            btnCancel.Visible = true;
            pnlDetails.Visible = true;
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            btnAddSave.Visible = false;
            btnEditSave.Visible = false;

            string status = "For Approval";
            GlobalProcedure.procAddonReservationUpdate(Convert.ToInt32(dtgAddons.CurrentRow.Cells[0].Value), reservationID, 
                UserAccount.getAddonID(), status);
            UserAccount.setAddonID(-1);

            displayAddonsReservation();
        }

        private void btnDeleteAddon_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procAddonReservationDelete(Convert.ToInt32(dtgAddons.CurrentRow.Cells[0].Value));
            displayAddonsReservation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procReservationGetTotalAmount(reservationID);
            this.Close();
        }

        private void txtEditAddonname_MouseClick(object sender, MouseEventArgs e)
        {
            new PopUpAddons().ShowDialog();
            //displayAddonEdit();
            GlobalProcedure.procAddonGetByID(UserAccount.getAddonID());
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtEditAddonname.Text = GlobalProcedure.datHotel.Rows[0]["addonName"].ToString();
                txtEditDescription.Text = GlobalProcedure.datHotel.Rows[0]["description"].ToString();
                txtEditPrice.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["price"].ToString()):F2}";
            }
        }
    }
}
