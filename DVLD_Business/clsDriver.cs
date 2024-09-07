using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsDriver
    {
        public enum enMode { AddNew = 0, Update=1}
        public enMode Mode = enMode.AddNew;

        public int DriverID { get; set; }
        public int PersonID { get;set; }
        public clsPerson PersonInfo;
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver(int DriverID = -1, int PersonID = -1, int CreatedByUserID = -1, DateTime CreatedDate = default)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            PersonInfo = clsPerson.Find(PersonID);

            Mode = (DriverID == -1) ? enMode.AddNew : enMode.Update;
        }

        bool _AddNewDriver()
        {
            this.DriverID = clsDriverData.AddNewDriver(this.PersonID, this.CreatedByUserID);

            return this.DriverID != -1;
        }
        bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID);
        }
        public static clsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1; DateTime CreatedDate = DateTime.Now;

            return clsDriverData.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedDate, ref CreatedByUserID) 
                ? new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate) 
                : null;

        }
        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1; DateTime CreatedDate = DateTime.Now;


            return clsDriverData.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedDate, ref CreatedByUserID)
                ? new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate)
                : null;

        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if(_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;


                case enMode.Update:
                    return _UpdateDriver();
            }

            return false;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }
        public static DataTable GetLicenses(int DriverID)
        {
            return clsLicenseData.GetDriverLicenses(DriverID);
        }
        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return clsInternationalLicense.GetDriverInternationalLicenses(DriverID);
        }

    }
}
