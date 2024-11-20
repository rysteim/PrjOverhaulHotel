using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjOverhaulHotel
{
    internal class UserAccount
    {
        public static int userID, roomID, addonID;
        public static string firstName;
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

        public static int getAddonID()
        {
            return addonID;
        }

        public static void setAddonID(int newID)
        {
            addonID = newID;
        }

        public static void setProfile(string newFirstName, string newRole, string image)
        {
            firstName = newFirstName;
            role = newRole;
            imageLoc = image;
        }

        public static string getFirstName()
        {
            return firstName;
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
