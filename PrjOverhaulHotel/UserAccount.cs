using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrjOverhaulHotel
{
    internal class UserAccount
    {
        public static int userID, roomID, addonID, promoID, accountID;
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

        public static int getPromoID()
        {
            return promoID;
        }

        public static void setPromoID(int newID)
        {
            promoID = newID;
        }

        public static int getAccountID()
        {
            return accountID;
        }

        public static void setAccountID(int newID)
        {
            accountID = newID;
        }

        public static void setProfile(string newFirstName, string image)
        {
            firstName = newFirstName;
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

        public static void setRole(string newRole)
        {
            role = newRole;
        }

        public static string getImage()
        {
            return imageLoc;
        }
    }
}
