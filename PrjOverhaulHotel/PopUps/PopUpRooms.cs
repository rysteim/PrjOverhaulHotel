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
            roomStatusUpdate();
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
                        row1["ROOM_ID"].ToString(),
                        row1["ROOM_NAME"].ToString(),
                        row1["ROOM_TYPE"].ToString(),
                        $"₱{Convert.ToDouble(row1["PRICE_PER_DAY"].ToString()):F2}"
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

        private void roomStatusUpdate()
        {
            GlobalProcedure.procRoomCheckRoomStatus(DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
