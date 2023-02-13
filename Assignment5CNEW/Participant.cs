using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5CNEW
{
    internal class Participant
    {
        private string firstName = string.Empty;
        private string lastName = "";

        private Address address;

        public Participant()
        {
            address = new Address();
        }

        public Participant(string firstName, string lastName, Address adr)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            if (adr != null)
                address = adr;
            else
                address = new Address();
        }

        public Participant(Participant theOther)
        {
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
            this.address = new Address(theOther.address);
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get { return lastName.ToUpper() + ", " + firstName; }
        }

        public bool Validate()
        {
            bool adrsOK = address.Validate();
            bool nameOK = (!string.IsNullOrEmpty(firstName) && (!string.IsNullOrEmpty(lastName)));
            return adrsOK && nameOK;
        }

        public override string ToString()
        {
            string strOut = string.Format("{0, -20} {1}", FullName, address.ToString());
            return strOut;
        }
    }
}
