using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class PopUpAccounts : Form
    {
        public PopUpAccounts()
        {
            InitializeComponent();
        }

        private void PopUpAccounts_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            displayAccounts();
        }

        private void displayAccounts()
        {
            GlobalProcedure.procGuestData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgAccounts.Rows.Clear();
                lblTotal.Text = "Total Accounts: " + GlobalProcedure.datHotel.Rows.Count.ToString();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgAccounts.Rows.Add(
                        row1["AID"].ToString(),
                        row1["MEMBERSHIP"].ToString(),
                        row1["FIRST NAME"].ToString(),
                        row1["MIDDLE NAME"].ToString(),
                        row1["LAST NAME"].ToString(),
                        row1["USERNAME"].ToString(),
                        row1["STATUS"].ToString(),
                        row1["CONTACT NUMBER"].ToString(),
                        Convert.ToDateTime(row1["BIRTHDATE"].ToString()).ToString("MMM dd, yyyy"),
                        row1["EMAIL ADDRESS"].ToString(),
                        row1["ADDRESS"].ToString(),
                        row1["GENDER"].ToString(),
                        Convert.ToDateTime(row1["ACCOUNT CREATED ON"].ToString()).ToString("MMM dd, yyyy"),
                        row1["IMAGE"].ToString()
                    );
                }
            }
            else
            {
                dtgAccounts.Rows.Clear();
            }
        }

        private void searchGuests()
        {
            GlobalProcedure.procGuestSearch(txtSearch.Text, "", "");
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                dtgAccounts.Rows.Clear();
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    dtgAccounts.Rows.Add(
                        row1["AID"].ToString(),
                        row1["MEMBERSHIP"].ToString(),
                        row1["FIRST NAME"].ToString(),
                        row1["MIDDLE NAME"].ToString(),
                        row1["LAST NAME"].ToString(),
                        row1["USERNAME"].ToString(),
                        row1["STATUS"].ToString(),
                        row1["CONTACT NUMBER"].ToString(),
                        Convert.ToDateTime(row1["BIRTHDATE"].ToString()).ToString("MMM dd, yyyy"),
                        row1["EMAIL ADDRESS"].ToString(),
                        row1["ADDRESS"].ToString(),
                        row1["GENDER"].ToString(),
                        Convert.ToDateTime(row1["ACCOUNT CREATED ON"].ToString()).ToString("MMM dd, yyyy"),
                        row1["IMAGE"].ToString()
                    );
                }
            }
            else
            {
                dtgAccounts.Rows.Clear();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchGuests();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            UserAccount.setAccountID(Convert.ToInt32(dtgAccounts.CurrentRow.Cells[0].Value));
            this.Close();
        }
    }
}
