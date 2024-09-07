using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsLicenseClass
    {
        public enum enMode { AddNew=0, Update=1}
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { get; set; }
        public string LicenseCalssName { get; set; }
        public string LicenseCalssDescription { get; set; }
        public byte MinAge { get; set; }
        public byte ValidtityLength { get; set; }
        public float ClassFees { get; set; }

        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.LicenseCalssName = "";
            this.LicenseCalssDescription = "";
            this.MinAge =18;
            this.ValidtityLength = 10;
            this.ClassFees = 0;

            Mode = enMode.AddNew;
        }
        public clsLicenseClass(int LicenseClassID, string LicenseCalssName, string LicenseCalssDescription, byte MinAge, byte ValidtityLength, float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.LicenseCalssName = LicenseCalssName;
            this.LicenseCalssDescription = LicenseCalssDescription;
            this.MinAge = MinAge;
            this.ValidtityLength = ValidtityLength;
            this.ClassFees = ClassFees;

            Mode = enMode.Update;
        }

        public static clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = ""; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }
        public static clsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }

        bool __AddLicenseClass()
        {
            this.LicenseClassID = clsLicenseClassData.AddNewLicenseClass(this.LicenseCalssName, this.LicenseCalssDescription,
                this.MinAge, this.ValidtityLength, this.ClassFees);

            return (this.LicenseClassID != -1);
        }

        bool _UpdateLicenseClass()
        {
            return clsLicenseClassData.UpdateLicenseClass(this.LicenseClassID, this.LicenseCalssName, this.LicenseCalssDescription,
                this.MinAge, this.ValidtityLength, this.ClassFees);
        }
        
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (__AddLicenseClass())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicenseClass();

            }

            return false;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassData.GetAllLicenseClasses();
        }

    }
}
