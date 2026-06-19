using ContactsDataAccessLayer;
using System;
using System.Data;


namespace ContactsBusinessLayer
{
    public class clsContact
    {
        private enum enMode { Update= 1, AddNew =2}

        public int ContactID { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
        enMode Mode { get; set; }

        private clsContact(int contactID, string firstName, string lastName, string email, string phone, string address, DateTime dateOfBirth, int countryID, string imagePath)
        {
            this.ContactID = contactID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.CountryID = countryID;
            this.ImagePath = imagePath;
            Mode = enMode.Update;
        }
        public clsContact()
        {
            this.ContactID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";

            this.Mode = enMode.AddNew;
        }

        public static clsContact Find(int ID)
        {
            string firstName = default,lastName = default,email= default,phone = default,address = default,imagePath = default;
            int countryID = default;
            DateTime dateOfBirth = default;

            if(clsContactDataAccess.GetContactInfoByID(ID, ref firstName, ref lastName, ref email,ref phone,ref address,ref dateOfBirth,ref countryID,ref imagePath))
            {
                return new clsContact(ID, firstName, lastName, email, phone, address, dateOfBirth, countryID, imagePath);
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewContact()
        {
            
            this.ContactID = clsContactDataAccess.AddNewContact(this.FirstName, this.LastName,
                this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);

            return (ContactID != -1);
        }
        private bool _UpdateContactWithID()
        {
           return  clsContactDataAccess.UpdateContactWithID(this.ContactID, this.FirstName, this.LastName,
                this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
        }
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                   
                case enMode.Update:
                     return _UpdateContactWithID();
                    
            }
            return false;
        }
        public static bool DeleteContactWithID(int ID)
        {
            if (!clsContactDataAccess.IsContactExists(ID))
                return false;
            
            return clsContactDataAccess.DeleteContact(ID);
        }

        public static DataTable GetAllContacts()
        {
            return clsContactDataAccess.GetAllContacts();
        }

        public static DataTable GetAllDetails()
        {
            return clsContactDataAccess.GetAllDetails();
        }

        public static bool IsExits(int ID)
        {
            return clsContactDataAccess.IsContactExists(ID);
        }
       
    }
}
