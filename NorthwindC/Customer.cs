﻿//Tebibu Solomon
//8/26/2022
//using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindC
{
    public class Customer
    {
        //Class variables
        private string customerId = "n/a";
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";

        //gets and sets
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }
        public string ContactTitle
        {
            get { return this.contactTitle; }
            set { this.contactTitle = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }

        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }

        }
        public string Fax
        {
            get { return this.fax; }
            set { this.phone = fax; }

        }
        public Customer() : this("n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")

        {

            // Empty Constructor


        }
        // Methods
        public Customer(string aCustomerId, string aCompanyName, string aContactName,string aContactTitle, string aAddress, string aCity
            , string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
           

        {

            this.CustomerId = aCustomerId;
            this.CompanyName = aCompanyName;
            this.ContactName = aContactName;
            this.ContactTitle = aContactTitle;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Fax = aFax;
            

        }
        // Methods Go Here
        public override string ToString()
        {
            string message = "";
            message = message + "CustomerId: " + this.CustomerId + "\n";
            message = message + "CompanyName: " + this.CompanyName + "\n";
            message = message + "ContactTitle: " + this.ContactTitle + "\n";
            message = message + "Address: " + this.Address + "\n";
            message = message + "City: " + this.City + "\n";
            message = message + "Region: " + this.Region + "\n";
            message = message + "PostalCode: " + this.PostalCode + "\n";
            message = message + "Country: " + this.Country + "\n";
            message = message + "Phone: " + this.Phone + "\n";
            message = message + "Fax: " + this.Fax + "\n";
            return message;


        }















    }

}
