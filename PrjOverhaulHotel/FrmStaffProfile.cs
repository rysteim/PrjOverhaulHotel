using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace PrjOverhaulHotel
{
    public partial class FrmStaffProfile : Form
    {
        int userID = UserAccount.getUserID();
        int roleID;
        string imagePath, role;
        public FrmStaffProfile()
        {
            InitializeComponent();
            btnSave.Visible = false;
            btnUpload.Visible = false;
        }

        private void FrmStaffProfile_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            btnSave.Visible = false;
            btnUpload.Visible = false;
            displayProfile();
            displayDetails();
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
                imgIcon.Image = Image.FromFile(imagePath);
            }
            else
            {
                imgIcon.Image = Properties.Resources.rb_8551;
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                btnSee.Image = Properties.Resources.eye1;
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (txtPassword.UseSystemPasswordChar == false)
            {
                btnSee.Image = Properties.Resources.eye_off1;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void displayDetails()
        {
            GlobalProcedure.procAccountGetByID(userID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtFirstname.Text = GlobalProcedure.datHotel.Rows[0]["FIRST NAME"].ToString();
                txtMiddlename.Text = GlobalProcedure.datHotel.Rows[0]["MIDDLE NAME"].ToString();
                txtLastname.Text = GlobalProcedure.datHotel.Rows[0]["LAST NAME"].ToString();
                txtUsername.Text = GlobalProcedure.datHotel.Rows[0]["USERNAME"].ToString();
                txtPassword.Text = GlobalProcedure.datHotel.Rows[0]["PASSWORD"].ToString();
                txtContactno.Text = GlobalProcedure.datHotel.Rows[0]["CONTACT NUMBER"].ToString();
                txtEmailadd.Text = GlobalProcedure.datHotel.Rows[0]["EMAIL ADDRESS"].ToString();
                txtAddress.Text = GlobalProcedure.datHotel.Rows[0]["ADDRESS"].ToString();
                cmbGender.Text = GlobalProcedure.datHotel.Rows[0]["GENDER"].ToString();
                dtmBirthdate.Value = Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["BIRTHDATE"].ToString());
                imagePath = GlobalProcedure.datHotel.Rows[0]["IMAGE"].ToString();

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    imgProfile.Image = Image.FromFile(imagePath);
                }
                else
                {
                    imgProfile.Image = Properties.Resources.rb_8551;
                }

                String accRole = GlobalProcedure.datHotel.Rows[0]["ROLE"].ToString();
                GlobalProcedure.procRoleData();
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    foreach (DataRow row in GlobalProcedure.datHotel.Rows)
                    {
                        string roleName = row["roleName"].ToString();
                        int newRoleID = Convert.ToInt32(row["id"]);

                        if (accRole == roleName)
                        {
                            role = roleName;
                            roleID = newRoleID;
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnUpload.Visible = true;

            txtFirstname.ReadOnly = false;
            txtMiddlename.ReadOnly = false;
            txtLastname.ReadOnly = false;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtContactno.ReadOnly = false;
            txtEmailadd.ReadOnly = false;
            txtAddress.ReadOnly = false;

            btnEdit.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnUpload.Visible = false;
            btnEdit.Visible = true;

            GlobalProcedure.procProfileUpdate(userID, txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, txtContactno.Text,
                txtEmailadd.Text, txtAddress.Text, cmbGender.Text, dtmBirthdate.Value, imagePath);
            GlobalProcedure.procAccountUpdate(userID, txtUsername.Text, txtPassword.Text);

            txtFirstname.ReadOnly = true;
            txtMiddlename.ReadOnly = true;
            txtLastname.ReadOnly = true;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtContactno.ReadOnly = true;
            txtEmailadd.ReadOnly = true;
            txtAddress.ReadOnly = true;

            UserAccount.setProfile(txtFirstname.Text, imagePath);

            displayDetails();
            displayProfile();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog profilePic = new OpenFileDialog();
            profilePic.Filter = "Images Files (*.jpg;*.gif;*.bmp)|*.jpg;*.gif;*.bmp";
            if (profilePic.ShowDialog() == DialogResult.OK)
            {
                imgProfile.Image = new Bitmap(profilePic.FileName);
                imagePath = profilePic.FileName;
            }
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
