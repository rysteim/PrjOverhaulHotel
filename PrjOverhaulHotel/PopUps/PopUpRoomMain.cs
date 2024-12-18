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
    public partial class PopUpRoomMain : Form
    {
        int roomID, rrID;
        public PopUpRoomMain()
        {
            InitializeComponent();
            btnSave.Visible = false;
        }

        public PopUpRoomMain(int roomID, int rrID)
        {
            InitializeComponent();
            this.roomID = roomID;
            this.rrID = rrID;
            fillFields();
            btnAdd.Visible = false;
        }

        private void PopUpRoomMain_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayTypes();
        }

        private void displayTypes()
        {
            GlobalProcedure.procRoomTypes();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                cmbRoomType.Items.Clear();
                cmbRoomType.Items.Add("");
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    cmbRoomType.Items.Add(row1["roomType"].ToString());
                }

            }
            else
            {
                cmbRoomType.Items.Clear();
            }
            if (btnSave.Visible == true)
                fillFields();
        }

        private void fillFields()
        {
            GlobalProcedure.procRoomGetByID(this.roomID);
            if (GlobalProcedure.datHotel.Rows.Count > 0 )
            {
                txtRoomName.Text = GlobalProcedure.datHotel.Rows[0]["roomName"].ToString();
                cmbRoomType.Text = GlobalProcedure.datHotel.Rows[0]["roomType"].ToString();
                txtPricePerDay.Text = GlobalProcedure.datHotel.Rows[0]["pricePerDay"].ToString();
                txtDescription.Text = GlobalProcedure.datHotel.Rows[0]["description"].ToString();
            }
            GlobalProcedure.procRoomReservationGetByID(rrID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                cmbStatus.Text = GlobalProcedure.datHotel.Rows[0]["roomStatus"].ToString();
            }
            else
            {
                lblStatus.Visible = false;
                cmbStatus.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procRoomAdd(txtRoomName.Text, cmbRoomType.Text, 
                txtDescription.Text, Convert.ToDouble(txtPricePerDay.Text));
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procRoomUpdate(roomID, rrID, txtRoomName.Text, cmbRoomType.Text,
                txtDescription.Text, Convert.ToDouble(txtPricePerDay.Text), cmbStatus.Text);
            this.Close();
        }
    }
}
