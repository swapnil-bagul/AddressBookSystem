using System;

namespace AddressBookSystem
{
    class ContactDetails
    {
        private string firstName, lastName, address, city, state, email;
        private int zip;
        private long phoneNumber;
        public ContactDetails (string firstName,string lastName,string address,string city,string state,int zip,long phoneNumber,string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
            
        }
        public void getDetails()
        {
            Console.WriteLine("Contact Details:\n"+"First Name: "+firstName+"\nLast Name: "+lastName+"\nAddress: "+address+"\nCity: "+city +"\nState: "+state +"\nZip: "+zip+"Phone Number: "+phoneNumber +"\nEmail: "+email    );
        }
    }

    class AddressBook
    {

        static void Main(string[] args)
        {
            ContactDetails details = new ContactDetails("Swapnil","Bagul","Nandurbar","Nandurbar","Maharastra",425412,7410177019,"swapnilbagul@gmail.com");
            details.getDetails();
            Console.ReadLine();
       
        }
    }
}
