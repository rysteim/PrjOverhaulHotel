﻿using System;
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
    public partial class FrmGuestProfile : Form
    {
        int userID = UserAccount.getUserID();
        int roleID;
        string imagePath, role;
        public FrmGuestProfile()
        {
            InitializeComponent();
            btnSave.Visible = false;
            btnUpload.Visible = false;
        }

        private void FrmGuestProfile_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayProfile();
            displayDetails();
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

        private void btnAP_Click(object sender, EventArgs e)
        {
            new FrmGuestAP().Show();
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

                if (GlobalProcedure.datHotel.Rows[0]["ROLE"].ToString() == "Guest")
                {
                    roleID = 1;
                    role = GlobalProcedure.datHotel.Rows[0]["ROLE"].ToString();
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
    }
}
