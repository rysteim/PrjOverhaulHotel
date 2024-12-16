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
    public partial class PopUpPromosAP : Form
    {
        int promoID;
        public PopUpPromosAP()
        {
            InitializeComponent();
            this.promoID = -1;
        }
        public PopUpPromosAP(int promoID)
        {
            InitializeComponent();
            this.promoID = promoID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procPromoAdd(txtPromoName.Text, Convert.ToDouble(txtPromoDiscount.Text),
                txtDescription.Text, dtmStart.Value, dtmEnd.Value);
            this.Close();
        }

        private void btnSaveAddon_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procPromoUpdate(promoID, txtPromoName.Text,
                Convert.ToDouble(txtPromoDiscount.Text), txtDescription.Text, 
                dtmStart.Value, dtmEnd.Value);
            this.Close();
        }

        private void PopUpPromosAP_Load(object sender, EventArgs e)
        {
            if (promoID > 0)
            {
                btnAddPromo.Visible = false;
                displayPromo();
            }
            else
            {
                btnSavePromo.Visible = false;
            }
        }

        private void displayPromo()
        {
            GlobalProcedure.procPromoGetByID(promoID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtPromoName.Text = GlobalProcedure.datHotel.Rows[0]["promoName"].ToString();
                txtPromoDiscount.Text = GlobalProcedure.datHotel.Rows[0]["discount"].ToString();
                txtDescription.Text = GlobalProcedure.datHotel.Rows[0]["description"].ToString();
                dtmStart.Value = Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["dateStart"]);
                dtmEnd.Value = Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["dateEnd"]);
            }
        }
    }
}
