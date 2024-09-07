using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsApplication
    {
        public enum enMode { AddNew=0,Update=1};
        public enMode Mode = enMode.AddNew;
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 8
        };
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        private clsPerson _PersonInfo;
        private clsApplicationType _ApplicationTypeInfo;
        private clsUser _CreatedByUserInfo;

        public clsPerson PersonInfo
        {
            get
            {
                if (_PersonInfo == null && ApplicantPersonID > 0)
                {
                    _PersonInfo = clsPerson.Find(ApplicantPersonID);
                }
                return _PersonInfo;
            }
        }
        public clsApplicationType ApplicationTypeInfo
        {
            get
            {
                if(_ApplicationTypeInfo == null && ApplicationTypeID>0)
                {
                    _ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);
                }
                return _ApplicationTypeInfo;
            }
        }
        public clsUser CreatedByUserInfo
        {
            get
            {
                if (_CreatedByUserInfo == null && CreatedByUserID > 0)
                {
                    _CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
                }
                return _CreatedByUserInfo;
            }
        }
        public string StatusText
        {
            get
            {
                switch(ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }
        public string ApplicantFullName
        {
            get
            {
                return PersonInfo.FullName;
            }
        }

        public clsApplication(int ApplicationID = -1, int ApplicantPersonID = -1, int ApplicationTypeID = -1,
            DateTime ApplicationDate = default, enApplicationStatus ApplicationStatus = enApplicationStatus.New,
            DateTime LastStatusDate = default, float PaidFees = 0f, int CreatedByUserID = -1)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            Mode = (ApplicationID == -1) ? enMode.AddNew : enMode.Update;
        }

        bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }
        bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationID,this.ApplicantPersonID,this.ApplicationDate,this.ApplicationTypeID,
                (byte)this.ApplicationStatus,this.LastStatusDate,this.PaidFees,this.CreatedByUserID);
        }

        public static clsApplication FindBaseApplication(int ApplicationID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            int ApplicationTypeID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            byte ApplicationStatus = 1;
            float PaidFees = 0;

            return clsApplicationData.GetApplicationInfoByID(ApplicationID, ref PersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID)
                
                ? new clsApplication(ApplicationID, PersonID, ApplicationTypeID, ApplicationDate, (enApplicationStatus)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                
                : null;

        }
        public bool Cancel()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, (short)enApplicationStatus.Cancelled);
        }
        public bool Complete()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, (short)enApplicationStatus.Completed);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateApplication();
            }
            return false;
        }

        public bool Delete()
        {
            return clsApplicationData.DeleteApplication(this.ApplicationID);
        }
        public bool DoesPersonHaveActiveApplication(int ApplicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(this.ApplicantPersonID, ApplicationTypeID);
        }
        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationData.IsApplicationExist(ApplicationID);
        }

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
        }

        public static int GetActiveApplicationID(int PersonID, clsApplication.enApplicationType ApplicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }
        public static int GetActiveApplicationIDForLicenseClass(int PersonID, enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID,(int)ApplicationTypeID, LicenseClassID);
        }
        public int GetActiveApplicationID (clsApplication.enApplicationType ApplicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(this.ApplicantPersonID, (int)ApplicationTypeID);
        }

    }
}
