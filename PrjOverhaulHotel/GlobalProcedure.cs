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

        public static void procAccountUpdate(int id, string username, string password, int role)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountUpdate";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_id", id);
                sqlCommand.Parameters.AddWithValue("@p_roleID", id);
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
    }
}
