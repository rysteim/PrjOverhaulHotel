using MySqlX.XDevAPI.Relational;
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
    public partial class PopUpRooms : Form
    {
        int reservationID;
        public PopUpRooms()
        {
            InitializeComponent();
        }

        public PopUpRooms(int reservationID)
        {
            this.reservationID = reservationID;
        }

        private void PopUpAddRooms_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayAvailableRooms();
        }

        private void displayAvailableRooms()
        {
            GlobalProcedure.procRoomAvailable();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgRooms.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgRooms.Rows.Add(
                        row1["id"].ToString(),
                        row1["roomName"].ToString(),
                        row1["roomType"].ToString(),
                        $"₱{Convert.ToDouble(row1["pricePerDay"].ToString()):F2}"
                    );
                }
            }
            else
            {
                dtgRooms.Rows.Clear();
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            UserAccount.setRoomID(Convert.ToInt32(dtgRooms.CurrentRow.Cells[0].Value));
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
