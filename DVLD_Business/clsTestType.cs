using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3}

        public clsTestType.enTestType TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }

        public clsTestType()
        {
            TestTypeID = clsTestType.enTestType.VisionTest;
            TestTypeTitle = "";
            TestTypeDescription = "";
            TestTypeFees = 0;
            Mode = enMode.AddNew;
        }
        private clsTestType(clsTestType.enTestType TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            Mode = enMode.Update;
        }

        bool _AddNewTestType()
        {
            this.TestTypeID = (clsTestType.enTestType) clsTestTypeData.AddNewTestType(this.TestTypeTitle,this.TestTypeDescription, this.TestTypeFees);
            return (this.TestTypeTitle != "");
        }
        bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType((int)this.TestTypeID, this.TestTypeTitle,this.TestTypeDescription, this.TestTypeFees);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTestType())
                    {

                        Mode = enMode.Update;
                        return true;

                    }
                    else
                        return false;



                case enMode.Update:

                    return _UpdateTestType();
            }


            return false;
        }
        public static clsTestType Find(clsTestType.enTestType TestTypeID)
        {
            string Title = "", Description=""; float Fees=0;

            if (clsTestTypeData.GetTestTypeInfoByID((int) TestTypeID, ref Title,ref Description, ref Fees))

                return new clsTestType(TestTypeID, Title, Description,Fees);
            else
                return null;
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

    }
}
