using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddContactDetails
    {
        //List Data Structure
        
        public static void SetDetails()
        {
            List<String> Details = new List<string>();
            List<long> Details1 = new List<long>();
            Console.Write("Enter The Number of Person Details You Are Adding:");
            int numOfPerson = Convert.ToInt32(Console.ReadLine());
            int startNum = 1;

            while (startNum <=numOfPerson )
            {

                Console.WriteLine("Enter Your Contact Deatils: ");
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();
                Details.Add(firstName);
                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();
                Details.Add(lastName);
                Console.Write("Enter Address: ");
                string address = Console.ReadLine();
                Details.Add(address );
                Console.Write("Enter City: ");
                string city = Console.ReadLine();
                Details.Add(city);
                Console.Write("Enter State: ");
                string state = Console.ReadLine();
                Details.Add(state);
                Console.Write("Enter Phone Number: ");
                long phoneNumber =Convert.ToInt64(Console.ReadLine());
                Details1.Add(phoneNumber);
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                Details.Add(email);
                Console.Write("Enter Zip: ");
                long zip = Convert.ToInt32 (Console.ReadLine());
                Details1.Add(zip);

                startNum++;
            }
            Console.WriteLine("Number Of Contact In Address Book : " + startNum);
            Details.ForEach(Console.WriteLine);
            Console.WriteLine("Contact Information: ");
            Details1.ForEach(Console.WriteLine);


        }
    }

    class AddressBook
    {
        static void Main(string[] args)
        {
            AddContactDetails.SetDetails();
          
           
        }
    }
}
