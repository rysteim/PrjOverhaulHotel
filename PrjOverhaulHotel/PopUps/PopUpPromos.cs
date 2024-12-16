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
    public partial class PopUpPromos : Form
    {
        int reservationID;
        public PopUpPromos()
        {
            InitializeComponent();
        }

        public PopUpPromos(int reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUpPromos_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayPromos();
        }

        private void displayPromos()
        {
            GlobalProcedure.procPromoActiveData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgPromos.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgPromos.Rows.Add(
                        row1["id"].ToString(),
                        row1["promoName"].ToString(),
                        row1["description"].ToString(),
                        $"{Convert.ToDouble(row1["discount"].ToString()):F2}%"
                    );
                }
            }
            else
            {
                dtgPromos.Rows.Clear();
            }
        }

        private void btnAddPromos_Click(object sender, EventArgs e)
        {
            UserAccount.setPromoID(Convert.ToInt32(dtgPromos.CurrentRow.Cells[0].Value));
            this.Close();
        }
    }
}
