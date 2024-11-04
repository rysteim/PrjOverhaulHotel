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
        public FrmStartUp()
        {
            InitializeComponent();
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
            new FrmSignup().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procLogIn(txtUsername.Text, txtPassword.Text);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                clearInputs();
                userID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["id"].ToString());
                new FrmStaffDashboard(userID).ShowDialog();
                this.Close();
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
