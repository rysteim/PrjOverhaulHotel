using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class PopUpGuest : Form
    {
        int profileID, accountID, guestID;
        string imagePath;
        public PopUpGuest()
        {
            InitializeComponent();

            this.guestID = -1;
            btnSaveGuest.Visible = false;
            lblCreated.Visible = false;
        }

        public PopUpGuest(int guestID)
        {
            InitializeComponent();

            this.guestID = guestID;
            btnAddGuest.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUpGuest_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            dtmBirthdate.Value = DateTime.Now;
            displayDetails();
            displayMembership();
        }

        private void displayDetails()
        {
            if (guestID > 0)
            {
                GlobalProcedure.procGuestGetByAccountID(guestID);
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
                    cmbMembership.Text = GlobalProcedure.datHotel.Rows[0]["MEMBERSHIP"].ToString();
                    dtmBirthdate.Value = Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["BIRTHDATE"].ToString());
                    imagePath = GlobalProcedure.datHotel.Rows[0]["IMAGE"].ToString();
                    lblCreated.Text = "Account Created On: " + Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["ACCOUNT CREATED ON"].ToString()).ToString("MMM dd, yyyy");

                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        imgProfile.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        imgProfile.Image = Properties.Resources.rb_8551;
                    }
                }
            }  
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
            displayDetails();
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


        private void btnSaveGuest_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procGuestUpdate(guestID, txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, txtContactno.Text,
                txtEmailadd.Text, txtAddress.Text, cmbGender.Text, dtmBirthdate.Value.ToString("yyyy-MM-dd"),
                imagePath, cmbMembership.SelectedIndex, txtUsername.Text, txtPassword.Text);
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Add profile.
                GlobalProcedure.procProfileAdd(txtFirstname.Text, txtMiddlename.Text, txtLastname.Text,
                    txtContactno.Text, txtEmailadd.Text, txtAddress.Text, cmbGender.Text, dtmBirthdate.Value, imagePath);

                // Get profile ID by full name and email.
                GlobalProcedure.procProfileGetIDByFullName(txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, txtEmailadd.Text);
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                    profileID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString());

                // Add account using profile ID with username and password.
                GlobalProcedure.procAccountAdd(profileID, txtUsername.Text, txtPassword.Text);

                // Get account ID by username.
                GlobalProcedure.procAccountGetIDByUsername(txtUsername.Text);
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                    accountID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString());

                // Assign account membership if guest.
                if (accountID > 0)
                    GlobalProcedure.procAccountDefaultMembership(accountID);
                GlobalProcedure.procAccountSetMembership(accountID, cmbMembership.SelectedIndex);

                MessageBox.Show("Guest added succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display a message)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
