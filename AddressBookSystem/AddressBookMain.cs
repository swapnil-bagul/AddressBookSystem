using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object of class AddressBookClass
            AddressBookClass function  = new AddressBookClass(); 
            
            string yes = "y";
            string y;

            do
            {

                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("1. Add Contact \n2. Display Contact \n3. Edit Contact \n4. Remove  Contact");
                Console.WriteLine("\nEnter your option");
                int option  = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        Console.WriteLine("how many contact you want to add:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (
                            int i = 0; i < num; i++)
                        {
                            function.GetContactDetails();
                        }
                        break;
                    case 2:
                        function.ContactDetails();
                        break;

                    case 3:
                        function.editContact();
                        break;

                    case 4:
                        function.removeContact();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\ndo you want to continue? press...y/n");
                y = Console.ReadLine();


            } while (yes == y);
            Console.ReadLine();


        }
    }
}
