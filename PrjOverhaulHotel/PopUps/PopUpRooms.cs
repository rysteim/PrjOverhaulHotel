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
        DateTime inDate, outDate;
        public PopUpRooms(DateTime inDate, DateTime outDate)
        {
            InitializeComponent();
            this.inDate = inDate;
            this.outDate = outDate;
        }

        public PopUpRooms(int reservationID, DateTime inDate, DateTime outDate)
        {
            this.reservationID = reservationID;
            this.inDate = inDate;
            this.outDate = outDate;
        }

        private void PopUpAddRooms_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayAvailableRooms();
            roomStatusUpdate();
        }

        private void displayAvailableRooms()
        {
            GlobalProcedure.procRoomAvailable(inDate, outDate);
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
            GlobalProcedure.procRoomCheckRoomStatus(reservationID, DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
