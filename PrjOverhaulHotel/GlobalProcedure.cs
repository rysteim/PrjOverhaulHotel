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
                MessageBox.Show("Connection succesful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
