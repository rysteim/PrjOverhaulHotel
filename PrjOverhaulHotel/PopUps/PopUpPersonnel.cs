﻿using System;
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
    public partial class PopUpPersonnel : Form
    {
        int employeeID, profileID, accountID;
        string imagePath;
        public PopUpPersonnel()
        {
            InitializeComponent();
            this.employeeID = -1;
            btnSaveGuest.Visible = false;
        }

        public PopUpPersonnel(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            btnSaveGuest.Visible = false;
        }

        private void PopUpPersonnel_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayDetails();
            displayRole();
        }

        private void displayDetails()
        {
            if (employeeID > 0)
            {
                GlobalProcedure.procEmployeeGetByAccountID(employeeID);
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
                    cmbRole.Text = GlobalProcedure.datHotel.Rows[0]["ROLE"].ToString();
                    txtLastOnline.Text = GlobalProcedure.datHotel.Rows[0]["EMPLOYEE LAST ONLINE"].ToString();
                    txtHourlyRate.Text = GlobalProcedure.datHotel.Rows[0]["HOURLY RATE"].ToString();
                    cmbWorkshift.Text = GlobalProcedure.datHotel.Rows[0]["WORKSHIFT"].ToString();
                    dtmBirthdate.Value = Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["BIRTHDATE"].ToString());
                    imagePath = GlobalProcedure.datHotel.Rows[0]["IMAGE"].ToString();
                    lblEmployment.Text = "Employment Date: " + Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["EMPLOYMENT DATE"].ToString()).ToString("MMM dd, yyyy");

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            displayDetails();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
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
                //if (accountID > 0)
                //    GlobalProcedure.procAccountDefaultMembership(accountID);
                //GlobalProcedure.procAccountSetMembership(accountID, cmbMembership.SelectedIndex);

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
