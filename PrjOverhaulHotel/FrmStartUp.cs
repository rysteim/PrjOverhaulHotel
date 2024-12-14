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
    public partial class FrmStartUp : Form
    {
        private int row, userID;
        private string firstName, role, imageLoc;
        public FrmStartUp()
        {
            InitializeComponent();
        }

        public FrmStartUp(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void FrmStartUp_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmSignup().Show();
            this.Hide();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GlobalProcedure.procLogIn(txtUsername.Text, txtPassword.Text);
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    clearInputs();
                    userID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["ACCOUNTID"].ToString());
                    firstName = GlobalProcedure.datHotel.Rows[0]["FIRST NAME"].ToString();
                    role = GlobalProcedure.datHotel.Rows[0]["ROLE"].ToString();
                    imageLoc = GlobalProcedure.datHotel.Rows[0]["IMAGE"].ToString();
                    UserAccount.setUserID(userID);
                    UserAccount.setProfile(firstName, role, imageLoc);
                    new FrmStaffDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procLogIn(txtUsername.Text, txtPassword.Text);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                clearInputs();
                userID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["ACCOUNTID"].ToString());
                firstName = GlobalProcedure.datHotel.Rows[0]["FIRST NAME"].ToString();
                role = GlobalProcedure.datHotel.Rows[0]["ROLE"].ToString();
                imageLoc = GlobalProcedure.datHotel.Rows[0]["IMAGE"].ToString();
                GlobalProcedure.procGuestActive(userID, DateTime.Now.ToString("yyyy-MM-dd HH\\:mm\\:ss"));

                UserAccount.setUserID(userID);
                UserAccount.setProfile(firstName, role, imageLoc);
                new FrmStaffDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void clearInputs()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
