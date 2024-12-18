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

namespace PrjOverhaulHotel
{
    public partial class FrmStaffGuests : Form
    {
        int userID = UserAccount.getUserID();
        public FrmStaffGuests()
        {
            InitializeComponent();
        }

        private void FrmStaffGuests_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            maximizeButtons();
            displayProfile();
            displayGuests();
            displayMembership();
            displayImage();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new FrmStaffProfile().Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new FrmStaffDashboard().Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            new FrmStaffReservation().Show();
            this.Hide();
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            new FrmStaffAP().Show();
            this.Hide();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            new FrmStaffPersonnel().Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            new FrmStaffRoom().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FrmStartUp().Show();
            this.Hide();
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

        private void displayGuests()
        {
            GlobalProcedure.procGuestData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgGuests.Rows.Clear();
                lblTotal.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgGuests.Rows.Add(
                        row1["AID"].ToString(),
                        row1["MEMBERSHIP"].ToString(),
                        row1["LAST NAME"].ToString(),
                        row1["FIRST NAME"].ToString(),
                        row1["MIDDLE NAME"].ToString(),
                        row1["USERNAME"].ToString(),
                        row1["STATUS"].ToString(),
                        row1["CONTACT NUMBER"].ToString(),
                        Convert.ToDateTime(row1["BIRTHDATE"].ToString()).ToString("MMM dd, yyyy"),
                        row1["EMAIL ADDRESS"].ToString(),
                        row1["ADDRESS"].ToString(),
                        row1["GENDER"].ToString(),
                        Convert.ToDateTime(row1["ACCOUNT CREATED ON"].ToString()).ToString("MMM dd, yyyy"),
                        row1["IMAGE"].ToString()
                    );
                }
            }
            else
            {
                dtgGuests.Rows.Clear();
            }
        }

        private void displayMembership()
        {
            GlobalProcedure.procMembershipData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                cmbMembership.Items.Clear();
                cmbMembership.Items.Add("");
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    cmbMembership.Items.Add(row1["membershipStatus"].ToString());
                }
            }
            else
            {
                cmbMembership.Items.Clear();
            }
        }

        private void displayImage()
        {
            if(dtgGuests.Rows.Count > 0)
            {
                string imagePath = dtgGuests.CurrentRow.Cells[13].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    imgSelect.Image = Image.FromFile(imagePath);
                }
                else
                {
                    imgSelect.Image = Properties.Resources.rb_8551;
                }
            }
        }

        private void searchGuests()
        {
            GlobalProcedure.procGuestSearch(txtGuestName.Text, cmbMembership.Text, cmbStatus.Text);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgGuests.Rows.Clear();
                lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgGuests.Rows.Add(
                        row1["AID"].ToString(),
                        row1["MEMBERSHIP"].ToString(),
                        row1["LAST NAME"].ToString(),
                        row1["FIRST NAME"].ToString(),
                        row1["MIDDLE NAME"].ToString(),
                        row1["USERNAME"].ToString(),
                        row1["STATUS"].ToString(),
                        row1["CONTACT NUMBER"].ToString(),
                        Convert.ToDateTime(row1["BIRTHDATE"].ToString()).ToString("MMM dd, yyyy"),
                        row1["EMAIL ADDRESS"].ToString(),
                        row1["ADDRESS"].ToString(),
                        row1["GENDER"].ToString(),
                        Convert.ToDateTime(row1["ACCOUNT CREATED ON"].ToString()).ToString("MMM dd, yyyy"),
                        row1["IMAGE"].ToString()
                    );
                }
            }
            else
            {
                lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                dtgGuests.Rows.Clear();
            }
        }

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {
            searchGuests();
        }

        private void dtgGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                displayImage();
            }
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            new PopUpGuest().ShowDialog();
            displayGuests();
        }

        private void btnManageGuest_Click(object sender, EventArgs e)
        {
            new PopUpGuest(Convert.ToInt32(dtgGuests.CurrentRow.Cells[0].Value)).ShowDialog();
            displayGuests();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procGuestDelete(Convert.ToInt32(dtgGuests.CurrentRow.Cells[0].Value));
            displayGuests();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void roleAccess()
        {
            string role = UserAccount.getRole();
            if (role == "Front Desk Staff")
            {
                btnPersonnel.Visible = false;
                btnRooms.Location = new Point(0, 180);
            }
            else if (role == "Housekeeping Staff")
            {
                btnReservation.Visible = false;
                btnPersonnel.Visible = false;
                btnAP.Visible = false;
                btnGuests.Location = new Point(0, 45);
                btnRooms.Location = new Point(0, 90);
            }
            else if (role == "Manager")
            {

            }
        }
    }
}
