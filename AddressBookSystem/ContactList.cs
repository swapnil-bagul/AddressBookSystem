using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
        public class ContactList
        {
           
            public string firstName;
            public string lastName;
            public string address;
            public string city;
            public string state;
            public int zipCode;
            public long phoneNumber;
            public string email;

           // Create constructor 
            public ContactList(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string email)
            {

                this.firstName = firstName;
                this.lastName = lastName;
                this.address = address;
                this.city = city;
                this.state = state;
                this.zipCode = zipCode;
                this.phoneNumber = phoneNumber;
                this.email = email;

            }


        }
   
}

