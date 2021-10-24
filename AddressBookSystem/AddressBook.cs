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
                Console.WriteLine("---------------------------------------------------------------");
                contact.SetRange(0, contact);
                getDetails();
            }
            else
            {
                Console.WriteLine("Enter Correct Name");
            }
           
             
        }
        public void removeContact()
        {
            Console.WriteLine("Enter First name which you want remove that contact: ");
            string name = Console.ReadLine();
            if (contact.Contains(name))
            {
                Console.WriteLine("Enter Sr. No....\n0. 1st Person\n1. 2nd Person\n2. 3rd person\n3. 4th Person");
                int srNum = Convert.ToInt32(Console.ReadLine());
                contact.RemoveRange  (0*srNum ,7*srNum ) ;
                Console.WriteLine("You Have Removed Contact Details");

            }
            else
            {
                Console.WriteLine("Enter Correct Name");
            }


        }

    }
}
