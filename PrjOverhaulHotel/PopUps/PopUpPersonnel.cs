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
    public partial class PopUpPersonnel : Form
    {
        int employeeID, profileID, accountID;
        string imagePath, imageLoc;
        public PopUpPersonnel()
        {
            InitializeComponent();
            this.employeeID = -1;
            btnSaveGuest.Visible = false;
        }

        public PopUpPersonnel(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            btnAddGuest.Visible = false;
        }

        private void PopUpPersonnel_Load(object sender, EventArgs e)
        {
            GlobalProcedure.fncDatabaseConnection();
            dtmBirthdate.Value = DateTime.Now;
            displayDetails();
            displayRole();
        }

        private void displayDetails()
        {
            if (employeeID > 0)
            {
                GlobalProcedure.procEmployeeGetByAccountID(employeeID);
                if (GlobalProcedure.datHotel.Rows.Count > 0)
                {
                    accountID = Convert.ToInt32(GlobalProcedure.datHotel.Rows[0]["AID"]);
                    txtFirstname.Text = GlobalProcedure.datHotel.Rows[0]["FIRST NAME"].ToString();
                    txtMiddlename.Text = GlobalProcedure.datHotel.Rows[0]["MIDDLE NAME"].ToString();
                    txtLastname.Text = GlobalProcedure.datHotel.Rows[0]["LAST NAME"].ToString();
                    txtUsername.Text = GlobalProcedure.datHotel.Rows[0]["USERNAME"].ToString();
                    txtPassword.Text = GlobalProcedure.datHotel.Rows[0]["PASSWORD"].ToString();
                    txtContactno.Text = GlobalProcedure.datHotel.Rows[0]["CONTACT NUMBER"].ToString();
                    txtEmailadd.Text = GlobalProcedure.datHotel.Rows[0]["EMAIL ADDRESS"].ToString();
                    txtAddress.Text = GlobalProcedure.datHotel.Rows[0]["ADDRESS"].ToString();
                    cmbGender.Text = GlobalProcedure.datHotel.Rows[0]["GENDER"].ToString();
                    cmbRole.Text = GlobalProcedure.datHotel.Rows[0]["ROLE"].ToString();
                    txtLastOnline.Text = GlobalProcedure.datHotel.Rows[0]["EMPLOYEE LAST ONLINE"].ToString();
                    txtHourlyRate.Text = GlobalProcedure.datHotel.Rows[0]["HOURLY RATE"].ToString();
                    cmbWorkshift.Text = GlobalProcedure.datHotel.Rows[0]["WORKSHIFT"].ToString();
                    dtmBirthdate.Value = Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["BIRTHDATE"].ToString());
                    imagePath = GlobalProcedure.datHotel.Rows[0]["IMAGE"].ToString();
                    lblEmployment.Text = "Employment Date: " + Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["EMPLOYMENT DATE"].ToString()).ToString("MMM dd, yyyy");

                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        imgProfile.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        imgProfile.Image = Properties.Resources.rb_8551;
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog profilePic = new OpenFileDialog();
            profilePic.Filter = "Images Files (*.jpg;*.gif;*.bmp)|*.jpg;*.gif;*.bmp";
            if (profilePic.ShowDialog() == DialogResult.OK)
            {
                imgProfile.Image = new Bitmap(profilePic.FileName);
                imageLoc = profilePic.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseAcc_Click(object sender, EventArgs e)
        {
            new PopUpAccounts().ShowDialog();
            accountID = UserAccount.getAccountID();
            GlobalProcedure.procGuestGetByAccountID(accountID);
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                txtFirstname.Text = GlobalProcedure.datHotel.Rows[0]["FIRST NAME"].ToString();
                txtMiddlename.Text = GlobalProcedure.datHotel.Rows[0]["MIDDLE NAME"].ToString();
                txtLastname.Text = GlobalProcedure.datHotel.Rows[0]["LAST NAME"].ToString();
                txtUsername.Text = GlobalProcedure.datHotel.Rows[0]["USERNAME"].ToString();
                txtPassword.Text = GlobalProcedure.datHotel.Rows[0]["PASSWORD"].ToString();
                txtContactno.Text = GlobalProcedure.datHotel.Rows[0]["CONTACT NUMBER"].ToString();
                txtEmailadd.Text = GlobalProcedure.datHotel.Rows[0]["EMAIL ADDRESS"].ToString();
                txtAddress.Text = GlobalProcedure.datHotel.Rows[0]["ADDRESS"].ToString();
                cmbGender.Text = GlobalProcedure.datHotel.Rows[0]["GENDER"].ToString();
                dtmBirthdate.Value = Convert.ToDateTime(GlobalProcedure.datHotel.Rows[0]["BIRTHDATE"].ToString());
                imagePath = GlobalProcedure.datHotel.Rows[0]["IMAGE"].ToString();

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    imgProfile.Image = Image.FromFile(imagePath);
                }
                else
                {
                    imgProfile.Image = Properties.Resources.rb_8551;
                }
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                btnSee.Image = Properties.Resources.eye1;
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (txtPassword.UseSystemPasswordChar == false)
            {
                btnSee.Image = Properties.Resources.eye_off1;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSaveGuest_Click(object sender, EventArgs e)
        {
            GlobalProcedure.procEmployeeUpdate(accountID, txtFirstname.Text, txtMiddlename.Text,
                txtLastname.Text, txtUsername.Text, txtPassword.Text, cmbRole.Text, cmbWorkshift.Text,
                Convert.ToDouble(txtHourlyRate.Text), txtContactno.Text, txtEmailadd.Text,
                txtAddress.Text, cmbGender.Text, dtmBirthdate.Value.ToString("yyyy-MM-dd"), imageLoc);
            this.Close();
        }

        private void displayRole()
        {
            GlobalProcedure.procRoleData();
            if (GlobalProcedure.datHotel.Rows.Count > 0)
            {
                cmbRole.Items.Clear();
                cmbRole.Items.Add("");
                foreach (DataRow row1 in GlobalProcedure.datHotel.Rows)
                {
                    cmbRole.Items.Add(row1["roleName"].ToString());
                }
            }
            else
            {
                cmbRole.Items.Clear();
            }
            displayDetails();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (accountID > 0)
            {
                GlobalProcedure.procGuestDelete(accountID);
            }
                GlobalProcedure.procEmployeeAdd(txtFirstname.Text, txtMiddlename.Text, txtLastname.Text,
                    txtUsername.Text, txtPassword.Text, cmbRole.Text, cmbWorkshift.Text, txtContactno.Text,
                    txtEmailadd.Text, txtAddress.Text, cmbGender.Text, dtmBirthdate.Value.ToString("yyyy-MM-dd"),
                    imageLoc, DateTime.Now.ToString("yyyy-MM-dd HH\\:mm\\:ss"));
                this.Close();
        }
    }
}
