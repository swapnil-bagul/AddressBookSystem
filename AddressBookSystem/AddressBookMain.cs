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
            ContactDetails contact = new ContactDetails();
            contact.setDetails();
            contact.getDetails();
        }
    }
   
}
