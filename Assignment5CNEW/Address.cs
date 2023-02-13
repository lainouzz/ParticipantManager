using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5CNEW
{
    internal class Address
    {
        private string street;
        private string zipCode;
        private string city;
        private Countries country;

        #region CONSTRUCTORS

        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zip;
            this.city = city;
            this.country = country;
        }

        public Address(string street, string zip, string city) :
            this(street, zip, city, Countries.Sverige)
        {

        }

        public Address() : this(string.Empty, string.Empty, string.Empty)
        {

        }

        public Address(Address theOther)
        {
            this.street = theOther.street;
            this.zipCode = theOther.zipCode;
            this.city = theOther.city;
            this.country = theOther.country;
        }

        #endregion

        #region PROPERTIES
        public string Street
        {
            get { return street; }

            set
            {
                street = value;
            }
        }

        public string City
        {
            get { return city; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    city = value;
            }
        }
        public string ZipCode
        {
            get { return zipCode; }

            set
            {
                zipCode = value;
            }
        }

        public Countries Country
        {
            get { return country; }

            set
            {
                country = value;
            }
        }
        #endregion


        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        public string GetAddressLabel()
        {
            string strOut = street + Environment.NewLine;
            strOut += zipCode + " " + city;
            return strOut;
        }

        public override string ToString()
        {
            string strOut = string.Format("{0, -25} {1, -8} {2, -10} {3}",
                street, zipCode, city, GetCountryString());

            return strOut;
        }

        public bool Validate()
        {

            bool ok = !string.IsNullOrEmpty(city);

            return ok;
        }
    }
}
