using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            //create object
            ContactDetails addressBook = new ContactDetails();
            string yes = "y";
            string y;

            do
            {
                Console.WriteLine("----------------------Welcome to Address Book----------------------");
                Console.WriteLine("1. Add Contact\n2. Edit Contact\n3. Remove Contact ");
                Console.WriteLine("Enter a Option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter number of contact you are Adding: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= num; i++)
                        {
                            
                            addressBook.setDetails();
                            Console.WriteLine("---------------------------------------------------------------");
                            addressBook.getDetails();

                        }
                        break;
                    case 2:
                        addressBook.editContact();
                        break;
                    case 3:
                        addressBook.removeContact();
                        break;


                }
                Console.WriteLine("Do you Want to Continue press [ y/n ] ");
                y = Console.ReadLine();

            }
            while (yes == y);



        }
       
        
    }
   
}
