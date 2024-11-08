using MySqlX.XDevAPI.Relational;
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
    public partial class FrmStaffReservation : Form
    {
        int userID = UserAccount.getUserID();
        public FrmStaffReservation()
        {
            InitializeComponent();
        }

        private void FrmStaffReservation_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            maximizeButtons(); 
            displayProfile();
            displayReservations();
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

        private void btnAP_Click(object sender, EventArgs e)
        {
            new FrmStaffAP().Show();
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
            lblName.Text = UserAccount.getUsername();
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

        private void displayReservations()
        {
            GlobalProcedure.procReservationData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgReservations.Rows.Clear();
                lblTotal.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgReservations.Rows.Add(
                        row1["RESERVATION ID"].ToString(),
                        row1["FULL NAME"].ToString(),
                        row1["TOTAL ROOMS"].ToString(),
                        row1["PROMO NAME"].ToString(),
                        row1["TOTAL ADDONS"].ToString(),
                        row1["INVOICE"].ToString(),
                        row1["RESERVATION STATUS"].ToString(),
                        Convert.ToDateTime(row1["BOOKING DATE"].ToString()).ToString("yyyy-MM-dd"),
                        row1["TOTAL DAYS"].ToString(),
                        row1["TOTAL AMOUNT"].ToString(),
                        row1["PAID AMOUNT"].ToString(),
                        row1["REMAINING BALANCE"].ToString(),
                        row1["IMAGE"].ToString()
                    );
                }
            }
            else
            {
                dtgReservations.Rows.Clear();
            }
        }

        private void dtgReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string imagePath = dtgReservations.CurrentRow.Cells[12].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    picInfo.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picInfo.Image = Properties.Resources.rb_8551;
                }
            }
        }

        private void btnTotalRooms_Click(object sender, EventArgs e)
        {
            new PopUpReservationRooms().ShowDialog();
        }
    }
}
