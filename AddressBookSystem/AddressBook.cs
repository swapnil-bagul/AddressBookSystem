using System;
using System.Collections.Generic;
using System.Collections;


namespace AddressBookSystem
{
    class ContactDetails
    {
        private string firstName, lastName, address, city, state, email;
        private int zip;
        private long phoneNumber;


        ArrayList contact = new ArrayList();


        public void setDetails()
        {
           
            Console.WriteLine("Enter Your Contact Deatils: ");
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            contact.Add(firstName);
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            contact.Add(lastName);
            Console.Write("Enter Address: ");
            address= Console.ReadLine();
            contact.Add(address);
            Console.Write("Enter City: ");
            city = Console.ReadLine();
            contact.Add(city);
            Console.Write("Enter State: ");
            state = Console.ReadLine();
            contact.Add(state);
            Console.Write("Enter Zip: ");
            zip = Convert.ToInt32 (Console.ReadLine());
            contact.Add(zip);
            Console.Write("Enter Phone Number: ");
            phoneNumber = Convert.ToInt64 (Console.ReadLine());
            contact.Add(phoneNumber);
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            contact.Add(email);
        }
      
        public void getDetails()
        {
            Console.WriteLine("Contact Details:\n" + "First Name: " + firstName + "\nLast Name: " + lastName + "\nAddress: " + address + "\nCity: " + city + "\nState: " + state + "\nZip: " + zip + "\nPhone Number: " + phoneNumber + "\nEmail: " + email);
           
        }
        public void editContact()
        {
            Console.WriteLine("Enter First name which you want edit that contact: ");
            string name = Console.ReadLine();
            if (contact.Contains(name ))
            {
                setDetails();
            }

            contact.SetRange(0, contact);
            getDetails();

        }

    }
}
