using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrjOverhaulHotel
{
    public partial class FrmStaffAP : Form
    {
        int userID = UserAccount.getUserID();
        public FrmStaffAP()
        {
            InitializeComponent();
        }

        private void FrmStaffAP_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            maximizeButtons();
            displayProfile();
            displayAddons();
            displayPromos();
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

        private void btnGuests_Click(object sender, EventArgs e)
        {
            new FrmStaffGuests().Show();
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

        private void displayAddons()
        {
            GlobalProcedure.procAddonData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgAddons.Rows.Clear();
                lblTotalAddon.Text = "Total Addons: " + GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgAddons.Rows.Add(
                        row1["id"].ToString(),
                        row1["addonName"].ToString(),
                        row1["description"].ToString(),
                        $"₱{Convert.ToDouble(row1["price"].ToString()):F2}"
                    );
                }
            }
            else
            {
                dtgAddons.Rows.Clear();
            }
        }

        private void displayPromos()
        {
            GlobalProcedure.procPromoData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgPromo.Rows.Clear();
                lblTotalPromo.Text = "Total Promos: " + GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgPromo.Rows.Add(
                        row1["id"].ToString(),
                        row1["promoName"].ToString(),
                        row1["description"].ToString(),
                        $"{Convert.ToDouble(row1["discount"].ToString()):F2}%"
                    );
                }
            }
            else
            {
                dtgPromo.Rows.Clear();
            }
        }

        private void searchAddon()
        {
            GlobalProcedure.procAddonSearch(txtSearchAddon.Text);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgAddons.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgAddons.Rows.Add(
                        row1["id"].ToString(),
                        row1["addonName"].ToString(),
                        row1["description"].ToString(),
                        $"₱{Convert.ToDouble(row1["price"].ToString()):F2}"
                    );
                }
            }
            else
            {
                dtgAddons.Rows.Clear();
            }
        }

        private void searchPromo()
        {
            GlobalProcedure.procPromoSearch(txtSearchPromo.Text);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgPromo.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgPromo.Rows.Add(
                        row1["id"].ToString(),
                        row1["promoName"].ToString(),
                        row1["description"].ToString(),
                        $"{Convert.ToDouble(row1["discount"].ToString()):F2}%"
                    );
                }
            }
            else
            {
                dtgPromo.Rows.Clear();
            }
        }

        private void dtgAddons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAddonName.Text = dtgAddons.CurrentRow.Cells[1].Value.ToString();
                lblAddonDescription.Text = dtgAddons.CurrentRow.Cells[2].Value.ToString();
                txtAddonPrice.Text = dtgAddons.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void dtgPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPromoName.Text = dtgPromo.CurrentRow.Cells[1].Value.ToString();
                lblPromoDescription.Text = dtgPromo.CurrentRow.Cells[2].Value.ToString();
                txtPromoDiscount.Text = dtgPromo.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void txtSearchAddon_TextChanged(object sender, EventArgs e)
        {
            searchAddon();
        }

        private void txtSearchPromo_TextChanged(object sender, EventArgs e)
        {
            searchPromo();
        }
    }
}
