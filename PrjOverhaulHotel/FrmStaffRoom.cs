﻿using PrjOverhaulHotel.PopUps;
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
    public partial class FrmStaffRoom : Form
    {
        int userID = UserAccount.getUserID();
        public FrmStaffRoom()
        {
            InitializeComponent();
        }

        private void FrmStaffRoom_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            maximizeButtons();
            displayProfile();
            displayRooms();
            displayTypes();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButtons()
        {
            pnlButtons.Size = new System.Drawing.Size(201, 555);
        }

        private void minimizeButtons()
        {
            pnlButtons.Size = new System.Drawing.Size(60, 555);
        }

        private bool compareButtons()
        {
            if (pnlButtons.Size == new System.Drawing.Size(201, 555))
            {
                return true;
            }
            else
            {
                maximizeButtons();
                return false;
            }
        }

        private void button_Move(object sender, EventArgs e)
        {
            compareButtons();
        }

        private void pnlButtons_MouseLeave(object sender, EventArgs e)
        {
            minimizeButtons();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile.FillColor = Color.FromArgb(0, 135, 97);
            btnProfile.FillColor2 = Color.FromArgb(0, 135, 97);
            btnProfile.FillColor3 = Color.Black;
            btnProfile.FillColor4 = Color.Black;
            lblName.ForeColor = Color.White;
            lblPosition.ForeColor = Color.White;
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.FillColor = Color.White;
            btnProfile.FillColor2 = Color.White;
            btnProfile.FillColor3 = Color.White;
            btnProfile.FillColor4 = Color.White;
            lblName.ForeColor = Color.Black;
            lblPosition.ForeColor = Color.Black;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new FrmStaffProfile().Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new FrmStaffDashboard().Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            new FrmStaffReservation().Show();
            this.Hide();
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            new FrmStaffAP().Show();
            this.Hide();
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            new FrmStaffGuests().Show();
            this.Hide();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            new FrmStaffPersonnel().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FrmStartUp().Show();
            this.Hide();
        }

        private void displayProfile()
        {
            lblName.Text = UserAccount.getFirstName();
            lblPosition.Text = UserAccount.getRole();

            string imagePath = UserAccount.getImage();

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                imgProfile.Image = Image.FromFile(imagePath);
            }
            else
            {
                imgProfile.Image = Properties.Resources.rb_8551;
            }
        }

        private void displayRooms()
        {
            GlobalProcedure.procRoomData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgRooms.Rows.Clear();
                lblTotal.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                    {
                    dtgRooms.Rows.Add(
                        row1["id"].ToString(),
                        row1["roomName"].ToString(),
                        row1["roomType"].ToString(),
                        row1["status"].ToString(),
                        $"₱{Convert.ToDouble(row1["pricePerDay"].ToString()):F2}"
                    );
                }
            }
            else
            {
                 dtgRooms.Rows.Clear();
            }
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
        }
        
        private void searchRooms()
        {
            GlobalProcedure.procRoomSearch(txtRoomName.Text, cmbRoomType.Text, cmbRoomStatus.Text);
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    dtgRooms.Rows.Clear();
                    lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                    foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                    {
                        dtgRooms.Rows.Add(
                            row1["id"].ToString(),
                            row1["roomName"].ToString(),
                            row1["roomType"].ToString(),
                            row1["status"].ToString(),
                            $"₱{Convert.ToDouble(row1["pricePerDay"].ToString()):F2}"
                        );
                    }
                }
                else
                {
                lblResult.Text = GlobalProcedure.datHotel.Rows.Count.ToString();
                dtgRooms.Rows.Clear();
                }
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            searchRooms();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            new PopUpRoomMain().ShowDialog();
            displayRooms();
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            new PopUpRoomMain(Convert.ToInt32(dtgRooms.CurrentRow.Cells[0].Value)).ShowDialog();
            displayRooms();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procRoomDelete(Convert.ToInt32(dtgRooms.CurrentRow.Cells[0].Value));
            displayRooms();
        }
    }
}
