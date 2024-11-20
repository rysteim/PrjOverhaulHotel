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
    public partial class PopUpAddons : Form
    {
        int reservationID;
        public PopUpAddons()
        {
            InitializeComponent();
        }

        public PopUpAddons(int reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;  
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUpAddons_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayAddons();
        }

        private void displayAddons()
        {
            GlobalProcedure.procAddonData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgAddons.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgAddons.Rows.Add(
                        row1["id"].ToString(),
                        row1["addonName"].ToString(),
                        row1["description"].ToString(),
                        $"₱{Convert.ToDouble(row1["price"].ToString()):F2}"
                    );
                }
            }
            else
            {
                dtgAddons.Rows.Clear();
            }
        }

        private void btnAddAddon_Click(object sender, EventArgs e)
        {
            UserAccount.setAddonID(Convert.ToInt32(dtgAddons.CurrentRow.Cells[0].Value));
            this.Close();
        }
    }
}
