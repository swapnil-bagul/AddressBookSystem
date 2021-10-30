using System;
using System.Collections.Generic;
using System.Collections;


namespace AddressBookSystem
{
    public class AddressBookClass
    {

        // create LinkedList object
        private LinkedList<ContactList> addressBook = new LinkedList<ContactList>(); 
        
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string email;

        // to get contact details of person
        public void GetContactDetails()   
        {
            ContactList contactList = new ContactList(firstName, lastName, address, city, state, zipCode, phoneNumber, email);

            Console.Write("Enter the First Name : ");
            contactList.firstName = Console.ReadLine();

            Console.Write("Enter the Last Name: ");
            contactList.lastName = Console.ReadLine();

            Console.Write("Enter the Adresss: ");
            contactList.address= Console.ReadLine();

            Console.Write("Enter the city: ");
            contactList.city= Console.ReadLine();

            Console.Write("Enter the State: ");
            contactList.state = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            contactList.zipCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Phone Number: ");
            contactList.phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the Email: ");
            contactList.email = Console.ReadLine();

            this.addressBook.AddLast(contactList);

            Console.WriteLine("------------------------------------------");

        }
        // Display contact details
        public void ContactDetails()  
        {

            if (addressBook.Count == 0)
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else  
            {
                //used foreach loop it executes each element present in the list  
                foreach (ContactList contactList  in this.addressBook)
                {
                    Console.WriteLine($"FirstName= {contactList.firstName} \n LastName= {contactList.lastName} \n Address= {contactList.address} \n state= {contactList.state} \n ZipCode= {contactList.zipCode}\n Phone= {contactList.phoneNumber} \n Email= {contactList.email}");

                }
            }

        }


        // Edit contact details
        public void editContact()  

        {

            if (addressBook.Count == 0)   
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else 
            {
                Console.WriteLine("enter the name which want to edit contact:");
                string name = Console.ReadLine();

                foreach (ContactList contactList in this.addressBook)
                {

                    if (contactList.firstName == name)
                    {
                        Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");
                        Console.WriteLine("\nthe {0} is present you can edit the details...", contactList.firstName);
                        Console.WriteLine("enter the details");

                        Console.WriteLine("Enter the First Name");
                        contactList.firstName = Console.ReadLine();

                        Console.WriteLine("Enter the Last Name");
                        contactList.lastName = Console.ReadLine();

                        Console.WriteLine("Enter the Adresss");
                        contactList.address = Console.ReadLine();

                        Console.WriteLine("Enter the city");
                        contactList.city = Console.ReadLine();

                        Console.WriteLine("Enter the State");
                        contactList.state = Console.ReadLine();

                        Console.WriteLine("Enter the Zip Code");
                        contactList.zipCode = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the Phone Number");
                        contactList.phoneNumber = Convert.ToInt64(Console.ReadLine());

                        Console.WriteLine("Enter the Email");
                        contactList.email = Console.ReadLine();

                        Console.WriteLine("updeted Contact detalis");
                        Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");

                    }
                    else
                    {

                        Console.WriteLine("the {0} is not present in ContactList", contactList.firstName);

                    }

                }
            }
        }

        // create instance method to Remove Contact 
        public void removeContact()     
        {
            if (addressBook.Count == 0) 
            {
                Console.WriteLine("AddressBook is Empty");
            }
            else 
            {
                Console.WriteLine("enter the name you want to remove");
                string name = Console.ReadLine();

                foreach (ContactList contactList in this.addressBook)
                {

                    if (contactList.firstName == name)
                    {
                        addressBook.Remove(contactList);

                    }
                    else
                    {
                        Console.WriteLine("the {0} is not present", contactList.firstName);

                    }
                }

            }

        }


    }
}
