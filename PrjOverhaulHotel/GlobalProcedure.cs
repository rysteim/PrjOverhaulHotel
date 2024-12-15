using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Collections.Specialized;

namespace PrjOverhaulHotel
{
    internal static class GlobalProcedure
    {
        public static string servername;
        public static string databasename;
        public static string username;
        public static string password;
        public static string port;

        public static MySqlConnection conHotel;
        public static MySqlCommand sqlCommand;
        public static string strConnection;

        public static MySqlDataAdapter mySqlDataAdapter;
        public static MySqlDataReader readerHotel;
        public static DataTable datHotel;
        public static string imageLoc;

        public static bool fncConnectToDatabase()
        {
            try
            {
                servername = "Localhost";
                databasename = "overhaul_hotel";
                username = "root";
                password = "";
                port = "3306";

                strConnection = "Server=" + servername + ";" +
                    "Database=" + databasename + ";" +
                    "User=" + username + ";" +
                    "Password=" + password + ";" +
                    "Port=" + port + ";" +
                    "Convert Zero Datetime=true";
                conHotel = new MySqlConnection(strConnection);
                sqlCommand = new MySqlCommand(strConnection, conHotel);
                if (conHotel.State == ConnectionState.Closed)
                {
                    sqlCommand.Connection = conHotel;
                    conHotel.Open();
                    return true;
                }
                else
                {
                    conHotel.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static void fncDatabaseConnection()
        {
            try
            {
                if (fncConnectToDatabase().Equals("False")) conHotel.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procLogIn(String username, String password)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_logIn";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_username", username);
                sqlCommand.Parameters.AddWithValue("@p_password", password);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex} \nInvalid username or password.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PROFILE PROCEDURES

        public static void procProfileAdd(String firstName, String middleName, String lastName, String contactNo, 
            String emailAddress, String address, String gender, DateTime birthdate, String imageLoc)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_profileAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_firstname", firstName);
                sqlCommand.Parameters.AddWithValue("@p_middlename", middleName);
                sqlCommand.Parameters.AddWithValue("@p_lastname", lastName);
                sqlCommand.Parameters.AddWithValue("@p_contactNo", contactNo);
                sqlCommand.Parameters.AddWithValue("@p_emailAddress", emailAddress);
                sqlCommand.Parameters.AddWithValue("@p_address", address);
                sqlCommand.Parameters.AddWithValue("@p_gender", gender);
                sqlCommand.Parameters.AddWithValue("@p_birthdate", birthdate.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("@p_image", imageLoc);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procProfileUpdate(int userID, String firstName, String middleName, String lastName, String contactNo,
            String emailAddress, String address, String gender, DateTime birthdate, String imageLoc)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_profileUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", userID);
                sqlCommand.Parameters.AddWithValue("@p_firstname", firstName);
                sqlCommand.Parameters.AddWithValue("@p_middlename", middleName);
                sqlCommand.Parameters.AddWithValue("@p_lastname", lastName);
                sqlCommand.Parameters.AddWithValue("@p_contactNo", contactNo);
                sqlCommand.Parameters.AddWithValue("@p_emailAddress", emailAddress);
                sqlCommand.Parameters.AddWithValue("@p_address", address);
                sqlCommand.Parameters.AddWithValue("@p_gender", gender);
                sqlCommand.Parameters.AddWithValue("@p_birthdate", birthdate.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("@p_image", imageLoc);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procProfileGetIDByFullName(String firstName, String middleName, String lastName, String emailAdd)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_profileGetIDByFullName";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_firstName", firstName);
                sqlCommand.Parameters.AddWithValue("@p_middleName", middleName);
                sqlCommand.Parameters.AddWithValue("@p_lastName", lastName);
                sqlCommand.Parameters.AddWithValue("@p_emailadd", emailAdd);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ACCOUNT PROCEDURES

        public static void procAccountAdd(int profileID, String username, String password)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_profileID", profileID);
                sqlCommand.Parameters.AddWithValue("@p_username", username);
                sqlCommand.Parameters.AddWithValue("@p_password", password);
                sqlCommand.Parameters.AddWithValue("@p_dateCreated", DateTime.Now.ToString("yyyy-MM-dd"));
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAccountUpdate(int id, string username, string password)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", id);
                sqlCommand.Parameters.AddWithValue("@p_username", username);
                sqlCommand.Parameters.AddWithValue("@p_password", password);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAccountGetIDByUsername(string username)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountGetIDByUsername";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_username", username);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAccountGetByID(int userID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountGetByID";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_accountid", userID);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // MEMBERSHIP PROCEDURES

        public static void procMembershipData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_membershipData";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAccountDefaultMembership(int accountID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountDefaultMembership";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_accountID", accountID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAccountSetMembership(int accountID, int membershipID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountSetMembership";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_accountID", accountID);
                sqlCommand.Parameters.AddWithValue("@p_membershipID", membershipID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ROOM PROCEDURES

        public static void procRoomData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomData";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomGetByID(int roomID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomGetByID";
                sqlCommand.Parameters.AddWithValue("@p_roomID", roomID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomActive(string date)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomActive";
                sqlCommand.Parameters.AddWithValue("@p_date", date);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomCheckAvailability(int roomID, string date)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomCheckAvailability";
                sqlCommand.Parameters.AddWithValue("@p_roomID", roomID);
                sqlCommand.Parameters.AddWithValue("@p_date", date);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomCheckRoomStatus(string date)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomCheckRoomStatus";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_date", date);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomGetByName(string roomName)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomGetByName";
                sqlCommand.Parameters.AddWithValue("@p_roomName", roomName);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomAdd(string roomName, string roomType, string description, double price)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_roomName", roomName);
                sqlCommand.Parameters.AddWithValue("@p_roomType", roomType);
                sqlCommand.Parameters.AddWithValue("@p_description", description);
                sqlCommand.Parameters.AddWithValue("@p_priceperday", price);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomUpdate(int roomID, string roomName, string roomType, 
            string description, double price)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", roomID);
                sqlCommand.Parameters.AddWithValue("@p_roomName", roomName);
                sqlCommand.Parameters.AddWithValue("@p_roomType", roomType);
                sqlCommand.Parameters.AddWithValue("@p_description", description);
                sqlCommand.Parameters.AddWithValue("@p_priceperday", price);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomDelete(int roomID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomDelete";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", roomID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomReserveStatus(int roomID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomReserveStatus";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", roomID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomOccupiedStatus(int roomID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomOccupiedStatus";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", roomID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomAvailableStatus(int roomID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomAvailableStatus";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", roomID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomTypes()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomTypes";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomSearch(String roomName, String type, String status)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomSearch";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_roomName", roomName);
                sqlCommand.Parameters.AddWithValue("@p_roomType", type);
                sqlCommand.Parameters.AddWithValue("@p_status", status);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomAvailable()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomAvailable";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // GUEST PROCEDURES

        public static void procGuestData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_guestData";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procGuestGetByAccountID(int accountID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_guestGetByAccountID";
                sqlCommand.Parameters.AddWithValue("@p_accountID", accountID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procGuestActive(int accountID, string datetime)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_guestActive";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", accountID);
                sqlCommand.Parameters.AddWithValue("@p_lastOnline", datetime);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procGuestUpdate(int accountID, string firstName, string middleName, string lastName,
            string contactNo, string emailAddress, string address, string gender, string birthdate, string image,
            int membership, string username, string password)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_guestUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_aid", accountID);
                sqlCommand.Parameters.AddWithValue("@p_firstName", firstName);
                sqlCommand.Parameters.AddWithValue("@p_middleName", middleName);
                sqlCommand.Parameters.AddWithValue("@p_lastName", lastName);
                sqlCommand.Parameters.AddWithValue("@p_contactNo", contactNo);
                sqlCommand.Parameters.AddWithValue("@p_emailAddress", emailAddress);
                sqlCommand.Parameters.AddWithValue("@p_address", address);
                sqlCommand.Parameters.AddWithValue("@p_gender", gender);
                sqlCommand.Parameters.AddWithValue("@p_birthdate", birthdate);
                sqlCommand.Parameters.AddWithValue("@p_image", image);
                sqlCommand.Parameters.AddWithValue("@p_membership", membership);
                sqlCommand.Parameters.AddWithValue("@p_username", username);
                sqlCommand.Parameters.AddWithValue("@p_password", password);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procGuestDelete(int accountID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_guestDelete";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", accountID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procGuestSearch(String fullName, String membership, String status)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_guestSearch";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_fullName", fullName);
                sqlCommand.Parameters.AddWithValue("@p_membership", membership);
                sqlCommand.Parameters.AddWithValue("@p_status", status);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ROLE PROCEDURES

        public static void procRoleData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roleData";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EMPLOYEE PROCEDURES

        public static void procEmployeeData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_employeeData";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procEmployeeGetByAccountID(int accountID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_employeeGetByAccountID";
                sqlCommand.Parameters.AddWithValue("@p_id", accountID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procEmployeeAdd(string firstName, string middleName,
            string lastName, string username, string password, string roleName, string workShift,
            string contactNo, string emailAdd, string address, string gender,
            string birthdate, string image, string date)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_employeeAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_firstName", firstName);
                sqlCommand.Parameters.AddWithValue("@p_middleName", middleName);
                sqlCommand.Parameters.AddWithValue("@p_lastName", lastName);
                sqlCommand.Parameters.AddWithValue("@p_username", username);
                sqlCommand.Parameters.AddWithValue("@p_password", password);
                sqlCommand.Parameters.AddWithValue("@p_roleName", roleName);
                sqlCommand.Parameters.AddWithValue("@p_workShift", workShift);
                sqlCommand.Parameters.AddWithValue("@p_contactNo", contactNo);
                sqlCommand.Parameters.AddWithValue("@p_emailAdd", emailAdd);
                sqlCommand.Parameters.AddWithValue("@p_address", address);
                sqlCommand.Parameters.AddWithValue("@p_gender", gender);
                sqlCommand.Parameters.AddWithValue("@p_birthdate", birthdate);
                sqlCommand.Parameters.AddWithValue("@p_image", image);
                sqlCommand.Parameters.AddWithValue("@p_dateCreated", date);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Employee added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procEmployeeCheckAvailability(string firstName, string middleName,
            string lastName, string username, string password, string roleName, string workShift,
            string contactNo, string emailAdd, string address, string gender,
            string birthdate, string image, string date)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_employeeCheckAvailability";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_firstName", firstName);
                sqlCommand.Parameters.AddWithValue("@p_middleName", middleName);
                sqlCommand.Parameters.AddWithValue("@p_lastName", lastName);
                sqlCommand.Parameters.AddWithValue("@p_username", username);
                sqlCommand.Parameters.AddWithValue("@p_password", password);
                sqlCommand.Parameters.AddWithValue("@p_roleName", roleName);
                sqlCommand.Parameters.AddWithValue("@p_workShift", workShift);
                sqlCommand.Parameters.AddWithValue("@p_contactNo", contactNo);
                sqlCommand.Parameters.AddWithValue("@p_emailAdd", emailAdd);
                sqlCommand.Parameters.AddWithValue("@p_address", address);
                sqlCommand.Parameters.AddWithValue("@p_gender", gender);
                sqlCommand.Parameters.AddWithValue("@p_birthdate", birthdate);
                sqlCommand.Parameters.AddWithValue("@p_image", image);
                sqlCommand.Parameters.AddWithValue("@p_dateCreated", date);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Employee added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procEmployeeUpdate(int accountID, string firstName, string middleName,
            string lastName, string username, string password, string roleName, string workShift,
            double hourlyRate, string contactNo, string emailAdd, string address, string gender,
            string birthdate, string image)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_employeeUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", accountID);
                sqlCommand.Parameters.AddWithValue("@p_firstName", firstName);
                sqlCommand.Parameters.AddWithValue("@p_middleName", middleName);
                sqlCommand.Parameters.AddWithValue("@p_lastName", lastName);
                sqlCommand.Parameters.AddWithValue("@p_username", username);
                sqlCommand.Parameters.AddWithValue("@p_password", password);
                sqlCommand.Parameters.AddWithValue("@p_roleName", roleName);
                sqlCommand.Parameters.AddWithValue("@p_workShift", workShift);
                sqlCommand.Parameters.AddWithValue("@p_hourlyRate", hourlyRate);
                sqlCommand.Parameters.AddWithValue("@p_contactNo", contactNo);
                sqlCommand.Parameters.AddWithValue("@p_emailAdd", emailAdd);
                sqlCommand.Parameters.AddWithValue("@p_address", address);
                sqlCommand.Parameters.AddWithValue("@p_gender", gender);
                sqlCommand.Parameters.AddWithValue("@p_birthdate", birthdate);
                sqlCommand.Parameters.AddWithValue("@p_image", image);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procEmployeeDelete(int accountID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_employeeDelete";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", accountID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procEmployeeLastOnline(int accountID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_employeeLastOnline";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", accountID);
                sqlCommand.Parameters.AddWithValue("@p_lastOnline", DateTime.Now);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procEmployeeSearch(String fullName, String role, String workshift)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_employeeSearch";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_fullName", fullName);
                sqlCommand.Parameters.AddWithValue("@p_role", role);
                sqlCommand.Parameters.AddWithValue("@p_workshift", workshift);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ADDON PROCEDURES

        public static void procAddonData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonData";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonAdd(string addonName, double price, string description)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_addonName", addonName);
                sqlCommand.Parameters.AddWithValue("@p_price", price);
                sqlCommand.Parameters.AddWithValue("@p_description", description);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonGetByID(int addonID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonGetByID";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", addonID);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonGetByName(string addonName)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonGetByName";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_addonName", addonName);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonSearch(String addonName)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonSearch";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_addonName", addonName);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonUpdate(int addonID, string addonName, double price, string description)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", addonID);
                sqlCommand.Parameters.AddWithValue("@p_addonName", addonName);
                sqlCommand.Parameters.AddWithValue("@p_price", price);
                sqlCommand.Parameters.AddWithValue("@p_description", description);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonDelete(int addonID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonDelete";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", addonID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PROMO PROCEDURES

        public static void procPromoData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_promoData";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procPromoAdd(string promoName, double discount, string description)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_promoAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_promoName", promoName);
                sqlCommand.Parameters.AddWithValue("@p_discount", discount);
                sqlCommand.Parameters.AddWithValue("@p_description", description);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procPromoSearch(String promoName)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_promoSearch";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_promoName", promoName);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procPromoGetByID(int promoID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_promoGetByID";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", promoID);

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procPromoUpdate(int promoID, string promoName, double discount, string description)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_promoUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", promoID);
                sqlCommand.Parameters.AddWithValue("@p_promoName", promoName);
                sqlCommand.Parameters.AddWithValue("@p_discount", discount);
                sqlCommand.Parameters.AddWithValue("@p_description", description);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procPromoDelete(int promoID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_promoDelete";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", promoID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // RESERVATION PROCEDURES

        public static void procReservationData()
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationData";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationGetByID(int reservationID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationGetByID";
                sqlCommand.Parameters.AddWithValue("@p_id", reservationID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationAdd(int accountID, int promoID, string invoice, 
            string bookingDate)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_accountID", accountID);
                sqlCommand.Parameters.AddWithValue("@p_promoID", promoID);
                sqlCommand.Parameters.AddWithValue("@p_invoice", invoice);
                sqlCommand.Parameters.AddWithValue("@p_bookingDate", bookingDate);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Reservation added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationGetByAccountID(int accountID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationGetByAccountID";
                sqlCommand.Parameters.AddWithValue("@p_id", accountID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationApprove(int reservationID, string date)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationApprove";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", reservationID);
                sqlCommand.Parameters.AddWithValue("@p_date", date);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Reservation added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationSearchByName(string name)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationSearchByName";
                sqlCommand.Parameters.AddWithValue("@p_name", name);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationGetTotalAmount(int reservationID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationGetTotalAmount";
                sqlCommand.Parameters.AddWithValue("@p_id", reservationID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationGetAccountID(int reservationID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationGetAccountID";
                sqlCommand.Parameters.AddWithValue("@p_id", reservationID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationDelete(int reservationID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationDelete";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", reservationID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationGetTotalDays(int reservationID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationGetTotalDays";
                sqlCommand.Parameters.AddWithValue("@p_id", reservationID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procReservationSetTotalDays(int reservationID, int totalDays)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_reservationSetTotalDays";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", reservationID);
                sqlCommand.Parameters.AddWithValue("@p_totalDays", totalDays);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ROOM RESERVATION PROCEDURES

        public static void procRoomReservationData(int reservationID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomReservationData";
                sqlCommand.Parameters.AddWithValue("@p_reservationID", reservationID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomReservationAdd(int reservationID, int roomID, string checkIn, string checkOut, double total)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomReservationAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_reservationID", reservationID);
                sqlCommand.Parameters.AddWithValue("@p_roomID", roomID);
                sqlCommand.Parameters.AddWithValue("@p_checkIn", checkIn);
                sqlCommand.Parameters.AddWithValue("@p_checkOut", checkOut);
                sqlCommand.Parameters.AddWithValue("@p_totalRoomPrice", total);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomReservationUpdate(int rrid, int reservationID, int roomID, string checkIn, string checkOut, double total)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomReservationUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", rrid);
                sqlCommand.Parameters.AddWithValue("@p_reservationID", reservationID);
                sqlCommand.Parameters.AddWithValue("@p_roomID", roomID);
                sqlCommand.Parameters.AddWithValue("@p_checkIn", checkIn);
                sqlCommand.Parameters.AddWithValue("@p_checkOut", checkOut);
                sqlCommand.Parameters.AddWithValue("@p_totalRoomPrice", total);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procRoomReservationDelete(int rrid)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_roomReservationDelete";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_rrid", rrid);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ADDON RESERVATION PROCEDURES

        public static void procAddonReservationData(int reservationID)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonReservationData";
                sqlCommand.Parameters.AddWithValue("@p_id", reservationID);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                mySqlDataAdapter.SelectCommand = GlobalProcedure.sqlCommand;
                datHotel.Clear();
                mySqlDataAdapter.Fill(GlobalProcedure.datHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonReservationAdd(int reservationID, int addonsID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonReservationAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_reservationID", reservationID);
                sqlCommand.Parameters.AddWithValue("@p_addonsID", addonsID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonReservationDelete(int raid)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonReservationDelete";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", raid);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAddonReservationUpdate(int raid, int reservationID, int addonsID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_addonReservationUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", raid);
                sqlCommand.Parameters.AddWithValue("@p_reservationID", reservationID);
                sqlCommand.Parameters.AddWithValue("@p_addonsID", addonsID);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
