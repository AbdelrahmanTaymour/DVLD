using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsCountry
    {
        public short CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry(short countryID = -1, string countryName = "")
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public static clsCountry Find(short CountryID)
        {
            string CountryName = "";

            return clsCountryData.GetCountryInfoByID(CountryID, ref CountryName)
                ? new clsCountry(CountryID, CountryName)
                : null;
        }
        public static clsCountry Find(string countryName)
        {
            short ID = -1;

            return clsCountryData.GetCountryInfoByCountryName(countryName, ref ID)
                ? new clsCountry(ID, countryName)
                : null;
        }
    
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
