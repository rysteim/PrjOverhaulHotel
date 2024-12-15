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
    public partial class PopUpAddonsAP : Form
    {
        int addonID;
        public PopUpAddonsAP()
        {
            InitializeComponent();
            addonID = -1;
        }

        public PopUpAddonsAP(int addonID)
        {
            InitializeComponent();
            this.addonID = addonID;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUpAddonsAP_Load(object sender, EventArgs e)
        {
            if (addonID > 0)
            {
                btnAddAddon.Visible = false;
                displayAddon();
            }
            else
            {
                btnSaveAddon.Visible = false;
            }
        }

        private void displayAddon()
        {
            GlobalProcedure.procAddonGetByID(addonID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtAddonName.Text = GlobalProcedure.datHotel.Rows[0]["addonName"].ToString();
                txtAddonPrice.Text = GlobalProcedure.datHotel.Rows[0]["price"].ToString();
                txtDescription.Text = GlobalProcedure.datHotel.Rows[0]["description"].ToString();
            }
        }

        private void btnSaveAddon_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procAddonUpdate(addonID, txtAddonName.Text, 
                Convert.ToDouble(txtAddonPrice.Text), txtDescription.Text);
            this.Close();
        }

        private void btnAddAddon_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procAddonAdd(txtAddonName.Text, Convert.ToDouble(txtAddonPrice.Text),
                txtDescription.Text);
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
