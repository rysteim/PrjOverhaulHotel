using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class FrmStaffPersonnel : Form
    {
        int userID = UserAccount.getUserID();

        public FrmStaffPersonnel()
        {
            InitializeComponent();
        }

        private void FrmStaffPersonnel_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            maximizeButtons();
            displayProfile();
            displayPersonnel();
            displayRole();
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

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
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

        private void btnGuests_Click(object sender, EventArgs e)
        {
            new FrmStaffGuests().Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            new FrmStaffRoom().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            statusOnline();
            new FrmStartUp().Show();
            this.Hide();
        }

        private void statusOnline()
        {
            GlobalProcedure.procGuestActive(userID, DateTime.Now.ToString("yyyy-MM-dd HH\\:mm\\:ss"));
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

        private void displayPersonnel()
        {
            GlobalProcedure.procEmployeeData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgPersonnel.Rows.Clear();
                lblTotal.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgPersonnel.Rows.Add(
                        row1["AID"].ToString(),
                        row1["LAST NAME"].ToString(),
                        row1["FIRST NAME"].ToString(),
                        row1["MIDDLE NAME"].ToString(),
                        row1["ROLE"].ToString(),
                        row1["EMPLOYEE STATUS"].ToString(),
                        row1["EMPLOYEE LAST ONLINE"].ToString(),
                        row1["WORKSHIFT"].ToString(),
                        $"₱{Convert.ToDouble(row1["HOURLY RATE"].ToString()):F2}",
                        row1["CONTACT NUMBER"].ToString(),
                        row1["EMAIL ADDRESS"].ToString(),
                        row1["ADDRESS"].ToString(),
                        row1["GENDER"].ToString(),
                        Convert.ToDateTime(row1["BIRTHDATE"].ToString()).ToString("MMM dd, yyyy"),
                        Convert.ToDateTime(row1["EMPLOYMENT DATE"].ToString()).ToString("MMM dd, yyyy"),
                        row1["IMAGE"].ToString()
                    );
                }
            }
            else
            {
                dtgPersonnel.Rows.Clear();
            }
        }
        private void displayImage()
        {
            if (dtgPersonnel.Rows.Count > 0)
            {
                string imagePath = dtgPersonnel.CurrentRow.Cells[15].Value.ToString();
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

        private void searchPersonnel()
        {
            GlobalProcedure.procEmployeeSearch(txtName.Text, cmbRole.Text, cmbShift.Text);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgPersonnel.Rows.Clear();
                lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgPersonnel.Rows.Add(
                        row1["AID"].ToString(),
                        row1["LAST NAME"].ToString(),
                        row1["FIRST NAME"].ToString(),
                        row1["MIDDLE NAME"].ToString(),
                        row1["ROLE"].ToString(),
                        row1["EMPLOYEE STATUS"].ToString(),
                        row1["EMPLOYEE LAST ONLINE"].ToString(),
                        row1["WORKSHIFT"].ToString(),
                        $"₱{Convert.ToDouble(row1["HOURLY RATE"].ToString()):F2}",
                        row1["CONTACT NUMBER"].ToString(),
                        row1["EMAIL ADDRESS"].ToString(),
                        row1["ADDRESS"].ToString(),
                        row1["GENDER"].ToString(),
                        Convert.ToDateTime(row1["BIRTHDATE"].ToString()).ToString("MMM dd, yyyy"),
                        Convert.ToDateTime(row1["EMPLOYMENT DATE"].ToString()).ToString("MMM dd, yyyy"),
                        row1["IMAGE"].ToString()
                    );
                }
            }
            else
            {
                lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                dtgPersonnel.Rows.Clear();
            }
        }

        private void dtgPersonnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string imagePath = dtgPersonnel.CurrentRow.Cells[15].Value.ToString();
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

        private void displayRole()
        {
            GlobalProcedure.procRoleData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                cmbRole.Items.Clear();
                cmbRole.Items.Add("");
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    cmbRole.Items.Add(row1["roleName"].ToString());
                }
            }
            else
            {
                cmbRole.Items.Clear();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            searchPersonnel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new PopUpPersonnel().ShowDialog();
            displayPersonnel();
            displayImage();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            new PopUpPersonnel(Convert.ToInt32(dtgPersonnel.CurrentRow.Cells[0].Value)).ShowDialog();
            displayPersonnel();
            displayImage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procEmployeeDelete(Convert.ToInt32(dtgPersonnel.CurrentRow.Cells[0].Value));
            displayPersonnel();
            displayImage();
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
