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

        }
    }
}
