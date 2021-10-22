using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static void Main (String []args)
        {
            Console.WriteLine("--------------------Welcome to Address Book--------------------");
            ContactDetails contact = new ContactDetails();
            contact.setDetails();
            Console.WriteLine("---------------------------------------------------------------");
            contact.getDetails();
        }

    }
}
