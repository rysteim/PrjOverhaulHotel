using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjOverhaulHotel
{
    internal class UserAccount
    {
        public static int userID, roomID;
        public static string username;
        public static string role;
        public static string imageLoc;

        public static int getUserID()
        {
            return userID;
        }

        public static void setUserID(int newID)
        {
            userID = newID;
        }

        public static int getRoomID()
        {
            return roomID;
        }

        public static void setRoomID(int newID)
        {
            roomID = newID;
        }
        public static void setProfile(string newUsername, string newRole, string image)
        {
            username = newUsername;
            role = newRole;
            imageLoc = image;
        }

        public static string getUsername()
        {
            return username;
        }

        public static string getRole()
        {
            return role;
        }

        public static string getImage()
        {
            return imageLoc;
        }
    }
}
