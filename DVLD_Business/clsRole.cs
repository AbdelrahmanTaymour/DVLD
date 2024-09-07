using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsRole
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        public short? RoleID { get; set; }
        public string RoleName { get; set; }

        public clsRole(short? RoleID = null, string RoleName = default)
        {
            this.RoleID = RoleID;
            this.RoleName = RoleName;

            Mode = (RoleID == default) ? enMode.AddNew : enMode.Update;
        }

        bool _AddNewRole()
        {
            this.RoleID = clsRoleData.AddNewRole(this.RoleName);
            return this.RoleID.HasValue;
        }
        bool _UpdateRole()
        {
            return clsRoleData.UpdateRole(this.RoleID, this.RoleName);
        }
        public bool save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRole())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateRole();
            }
            return false;
        }

        public static clsRole Find(short? RoleID)
        {
            string RoleName = default;

            return clsRoleData.GetRoleByID(RoleID, ref RoleName)
                ? new clsRole(RoleID, RoleName) 
                : null;
        }
        public static clsRole Find(string RoleName)
        {
            short? RoleID = null;

            return clsRoleData.GetRoleByRoleName(RoleName, ref RoleID)
                ? new clsRole(RoleID, RoleName)
                : null;
        }

        public static bool DeleteRole(short? RoleID)
        {
            return clsRoleData.DeleteRole(RoleID);
        }
        public static DataTable GetAllRoles()
        {
            return clsRoleData.GetAllRoles();
        }
    }
}
