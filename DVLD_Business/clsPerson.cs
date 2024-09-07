using System;
using System.Data;
using System.Text;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0,Update=1}
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public short NationalityCountryID { get; set; }

        string _ImagePath;
        clsCountry _CountryInfo;

        public string FullName
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(FirstName)
                    .Append(" ")
                    .Append(SecondName)
                    .Append(" ")
                    .Append(ThirdName)
                    .Append(" ")
                    .Append(LastName);

                return sb.ToString();
            }
        }
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public clsCountry CountryInfo
        {
            get
            {
                if(_CountryInfo == null && NationalityCountryID>0)
                {
                    _CountryInfo = clsCountry.Find(NationalityCountryID);
                }
                return _CountryInfo;
            }
        }

        public clsPerson(int PersonID = -1, string FirstName = "", string SecondName= "", string ThirdName = "",
            string LastName = "", string NationalNo = "", DateTime DateOfBirth = default, byte Gendor = 0,
             string Address = "", string Phone = "", string Email = "", short NationalityCountryID = -1, string ImagePath = "")
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;


            Mode = (PersonID == -1) ? enMode.AddNew : enMode.Update;
        }

        bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, 
                this.NationalNo, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, 
                this.NationalityCountryID, this.ImagePath);

            return (PersonID != -1);
        }
        bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.NationalNo, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            short NationalityCountryID = -1;
            byte Gendor = 0;

            bool isFound = clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref SecondName,
          ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth,
           ref Gendor, ref Address, ref Phone, ref Email,
           ref NationalityCountryID, ref ImagePath);

            if (isFound)
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                    DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            short NationalityCountryID = -1;
            byte Gendor = 0;

            bool isFound = clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID ,ref FirstName, ref SecondName, 
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email,
                ref NationalityCountryID, ref ImagePath);

            if (isFound)
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;

        }
    }
}
