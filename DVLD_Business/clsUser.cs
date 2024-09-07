using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update=1}
        public enMode Mode = enMode.AddNew;
        public enum enRole { Administrator = 1, LicenseOfficer = 2, AdminSupport = 3, GeneralUser = 4 };
        public int UserID { get; set; }
        public int PersonID { get; set; }
        clsPerson _personInfo;
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public enRole Role { get; set; }
        clsRole _roleInfo; 

        public clsPerson PersonInfo
        {
            get
            {
                if(_personInfo == null && PersonID > 0)
                {
                    _personInfo = clsPerson.Find(PersonID);
                }
                return _personInfo;
            }
        }
        
        public clsRole RoleInfo
        {
            get
            {
                if(_roleInfo == null && Role > 0)
                {
                    _roleInfo = clsRole.Find((short)Role);
                }
                return _roleInfo;
            }
        }
        public clsUser(int UserID = default, int PersonID = default, string Username= default, string Password = default, bool IsActive = default, enRole RoleID = default)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Role = RoleID;

            Mode = (UserID == default) ? enMode.AddNew : enMode.Update;
        }

        bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.Username, 
                clsLibarary.ComputeHash(this.Password), this.IsActive, (short)this.Role);

            return (this.UserID != -1);
        }
        bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.Username, 
                clsLibarary.ComputeHash(this.Password), this.IsActive, (short)this.Role);
        }

        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string Username = "", Password = "";
            bool IsActive = false;
            short? RoleID = -1;

            bool IsFound = clsUserData.GetUserInfoByUserID(UserID, ref PersonID, ref Username, ref Password, ref IsActive, ref RoleID);

            if (IsFound)
                return new clsUser(UserID, PersonID, Username, Password, IsActive, (enRole)RoleID);
            else
                return null;
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string Username = "", Password = "";
            bool IsActive = false;
            short? RoleID = -1;

            bool IsFound = clsUserData.GetUserInfoByPersonID(PersonID, ref UserID, ref Username, ref Password, ref IsActive, ref RoleID);

            if (IsFound)
                return new clsUser(UserID, PersonID, Username, Password, IsActive, (enRole)RoleID);
            else
                return null;
        }
        public static clsUser FindByUsernameAndPassword(string Username, string Password)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false;
            short? RoleID = -1;

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword(Username, clsLibarary.ComputeHash(Password),
                ref UserID, ref PersonID, ref IsActive, ref RoleID);

            if (IsFound)
                return new clsUser(UserID, PersonID, Username, Password, IsActive, (enRole)RoleID);
            else
                return null;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public bool UpdatePassword(int UserID, string NewPassword)
        {
            return clsUserData.UpdatePassword(UserID, clsLibarary.ComputeHash(NewPassword));
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }
        public static bool IsUserExist(string Username)
        {
            return clsUserData.IsUserExist(Username);
        }
        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }


    }
}
