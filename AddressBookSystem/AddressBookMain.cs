using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookMain
    {

        static void Main(string[] args)
        {
            Console.WriteLine("----------------------Welcome to Address Book----------------------");
            Console.WriteLine("1. Add Contact\n");
            Console.WriteLine("Enter a Option");
            int option = Convert.ToInt32(Console.ReadLine());
            
            switch (option )
            {
                case 1:
                    ContactDetails contact = new ContactDetails();
                    contact.setDetails();
                    Console.WriteLine("---------------------------------------------------------------");
                    contact.getDetails();
                    break;

            }
            
        }
    }
  
}
