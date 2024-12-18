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
    public partial class FrmSignup : Form
    {
        string imageLoc;
        int profileID, accountID;
        public FrmSignup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmStartUp().Show();
            this.Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog profilePic = new OpenFileDialog();
            profilePic.Filter = "Images Files (*.jpg;*.gif;*.bmp)|*.jpg;*.gif;*.bmp";
            if (profilePic.ShowDialog() == DialogResult.OK)
            {
                imgProfile.Image = new Bitmap(profilePic.FileName);
                imageLoc = profilePic.FileName;
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

        private void FrmSignup_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            dtmBirthdate.Value = DateTime.Now;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                // Add profile.
                GlobalProcedure.procProfileAdd(txtFirstname.Text, txtMiddlename.Text, txtLastname.Text,
                    txtContactno.Text, txtEmailadd.Text, txtAddress.Text, cmbGender.Text, dtmBirthdate.Value, imageLoc);

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
                GlobalProcedure.procAccountDefaultMembership(accountID);

                MessageBox.Show("Account successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new FrmStartUp(txtUsername.Text).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display a message)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
