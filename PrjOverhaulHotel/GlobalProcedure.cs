using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public static void procCustomerAdd(String firstName, String middleName, String lastName, String contactNo, 
            String emailAddress, String address, String gender, DateTime birthdate, String imageLoc)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_customerAdd";
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

        public static void procAccountAdd(int customerID, String username, String password)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountAdd";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@p_customerID", customerID);
                sqlCommand.Parameters.AddWithValue("@p_username", username);
                sqlCommand.Parameters.AddWithValue("@p_password", password);
                sqlCommand.Parameters.AddWithValue("@p_dateCreated", DateTime.Now.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void procAccountGetByUsername(String username)
        {
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter();
                datHotel = new DataTable();

                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "proc_accountGetByUsername";
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
    }
}
