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
    public partial class FrmGuestAP : Form
    {
        int userID = UserAccount.getUserID();
        int reservationID;
        double totalDays, pricePerDay, roomPrice;
        public FrmGuestAP()
        {
            InitializeComponent();
        }

        public FrmGuestAP(int reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;
        }

        private void FrmGuestAP_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            getReservationID();
            displayAddonsReservation();
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

        private void changeStatus()
        {
            GlobalProcedure.procReservationStatus(reservationID, "Has Additionals", DateTime.Now.ToString("yyyy-MM-dd"));
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

        private void getReservationID()
        {
            GlobalProcedure.procReservationCurrent(userID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                reservationID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["RESERVATION_ID"]);
                string status = GlobalProcedure.datHotel.Rows[0]["RESERVATION STATUS"].ToString();
                if (status == "For Check Out")
                {
                    pnlPreview.Visible = true;
                    pnlAP.Visible = false;
                    lblMessage.Text = "Please wait for check out. Thank you!";
                }
                else
                {
                    pnlAP.Visible = true;
                    pnlPreview.Visible = false;
                }
            }
            else
            {
                pnlPreview.Visible = true;
                pnlAP.Visible = false;
            }
        }

        private void btnAddons_Click(object sender, EventArgs e)
        {
            new PopUpAddons().ShowDialog();
            GlobalProcedure.procAddonGetByID(UserAccount.getAddonID());
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtAddonName.Text = GlobalProcedure.datHotel.Rows[0]["addonName"].ToString();
                txtPrice.Text = $"₱{Convert.ToDouble(GlobalProcedure.datHotel.Rows[0]["price"].ToString()):F2}";
                lblDescription.Text = GlobalProcedure.datHotel.Rows[0]["description"].ToString();
            }
        }

        private void btnAddAddon_Click(object sender, EventArgs e)
        {
            if (UserAccount.getAddonID() > 0)
            {
                GlobalProcedure.procAddonReservationAdd(reservationID, UserAccount.getAddonID(), "For Approval");
                UserAccount.setAddonID(-1);
                clearFields();
                changeStatus();
            }
            else
            {
                MessageBox.Show("Please select an addon.");
            }

            displayAddonsReservation();
        }

        private void btnEditAddon_Click(object sender, EventArgs e)
        {
            clearFields();

            if (UserAccount.getAddonID() > 0)
            {
                GlobalProcedure.procAddonReservationUpdate(Convert.ToInt32(dtgAddons.CurrentRow.Cells[0].Value),
                    reservationID, UserAccount.getAddonID(), "For Approval");
                UserAccount.setAddonID(-1);
                changeStatus();
                clearFields();
            }
            else
            {
                MessageBox.Show("Please select an addon.");
            }

            displayAddonsReservation();
        }

        private void btnDeleteAddon_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procAddonReservationDelete(Convert.ToInt32(dtgAddons.CurrentRow.Cells[0].Value));
            changeStatus();
            displayAddonsReservation();
        }

        private void clearFields()
        {
            txtAddonName.Clear();
            txtPrice.Clear();
            lblDescription.Text = "";
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new FrmGuestProfile().Show();
            this.Hide();
        }
    }
}
