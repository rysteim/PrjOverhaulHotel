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
        int customerID;
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procCustomerAdd(txtFirstname.Text, txtMiddlename.Text, txtLastname.Text,
                txtContactno.Text, txtEmailadd.Text, txtAddress.Text, cmbGender.Text, dtmBirthdate.Value, imageLoc);
            GlobalProcedure.procAccountGetByUsername(txtUsername.Text);
            customerID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString());
            GlobalProcedure.procAccountAdd(customerID, txtUsername.Text, txtPassword.Text);
        }

    }
}
