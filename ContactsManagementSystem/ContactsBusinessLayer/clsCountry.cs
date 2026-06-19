using ContactsDataAccessLayer;
using System;
using System.Data;


namespace ContactsBusinessLayer
{
    public class clsCountry
    {
        public enum enMode { Update = 1, AddNew = 2 };

        public int CountryID { get; private set; }
        public string CountryName { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        public enMode Mode { get; private set;}

        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
            Code = "";
            PhoneCode = "";
            Mode = enMode.AddNew;
        }
        private clsCountry(int countryID,string countryName, string code, string phoneCode)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
            this.Code = code;
            this.PhoneCode = phoneCode;
            this.Mode = enMode.Update;
        }
        public static clsCountry Find(int countryID)
        {
            string countryName = "";
            string code = "";
            string phoneCode = "";
            if(clsCountryDataAccess.GetCountryInfoByID(countryID,ref countryName, ref code, ref phoneCode))
            {
                return new clsCountry(countryID, countryName, code, phoneCode);
            }
            else
            {
                return null;
            }

        }
        public static clsCountry Find(string countryName)
        {
            int countryID = -1;
            string code = "";
            string phoneCode = "";
            if (clsCountryDataAccess.GetCountryInfoByName(countryName, ref countryID,ref code,ref phoneCode))
            {
                return new clsCountry(countryID, countryName,code,phoneCode);
            }
            else
            {
                return null;
            }

        }
        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryDataAccess.AddNewCountry(this.CountryName,this.Code,this.PhoneCode);
            return (this.CountryID != -1);


        }

        private bool _UpdateCountry()
        {
            return clsCountryDataAccess.UpdateCountryWithID(this.CountryID, this.CountryName,this.Code,this.PhoneCode);
          
        }
        public bool Save()
        {
            switch (this.Mode) 
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:
                            return _UpdateCountry();
                            

            }
            return false;
        }
        public static bool DeleteCountryWithID(int ID)
        {
            return clsCountryDataAccess.DeleteCountryWithID(ID);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }
        public static DataTable GetAllCountriesNames()
        {
            return clsCountryDataAccess.GetAllCountriesNames();
        }

        public static bool IsCountryExist(int ID)
        {
            return clsCountryDataAccess.IsCountryExist(ID);
        }
        public static bool IsCountryExist(string countryName)
        {
            return clsCountryDataAccess.IsCountryExist(countryName);
        }
    }
}
