using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddContactDetails
    {
        private string firstName, lastName, address, city, state, email;
        private int zip;
        private long phoneNumber;

        public void setDetails()
        {
            Console.WriteLine("Enter Your Contact Deatils: ");
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            address = Console.ReadLine();
            Console.Write("Enter City: ");
            city = Console.ReadLine();
            Console.Write("Enter State: ");
            state = Console.ReadLine();
            Console.Write("Enter Zip: ");
            zip = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            phoneNumber = Convert.ToInt64 (Console.ReadLine());
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
        }
        public void getDetails()
        {
            Console.WriteLine("Contact Details:\n" + "First Name: " + firstName + "\nLast Name: " + lastName + "\nAddress: " + address + "\nCity: " + city + "\nState: " + state + "\nZip: " + zip + "Phone Number: " + phoneNumber + "\nEmail: " + email);

        }
    }
}
