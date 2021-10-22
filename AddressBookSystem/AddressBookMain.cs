using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("--------------------Welcome to Address Book--------------------");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("Enter the Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ContactDetails addContact = new ContactDetails();
                    addContact.setDetails();
                    Console.WriteLine("---------------------------------------------------------------");
                    addContact.getDetails();
                    break;

            }
     


           
        }

    }
}
