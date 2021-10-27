using System;
using System.Collections.Generic;
using System.Collections;


namespace AddressBookSystem
{
    public class AddressBookClass
    {
<<<<<<< HEAD
        //private instance variable
        private string firstName, lastName, address, city, state, email;
        private int zip;
        private long phoneNumber;

        //Add ArrayList to add unknown data
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
=======
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

>>>>>>> UC4-RemoveContact
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
<<<<<<< HEAD
        // create instance method to edit contact
        public void editContact()
=======

        // Edit contact details
        public void editContact()  
>>>>>>> UC4-RemoveContact
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
<<<<<<< HEAD
        // create instance method to Remove Contact 
        public void removeContact()
=======

        //to remove the contact
        public void removeContact()     
>>>>>>> UC4-RemoveContact
        {
            if (addressBook.Count == 0) 
            {
<<<<<<< HEAD

                Console.WriteLine("Enter Sr. No....\n0. 1st Person\n1. 2nd Person\n2. 3rd person\n3. 4th Person");
                int srNum = Convert.ToInt32(Console.ReadLine());
                contact.RemoveRange  (0*srNum ,7*srNum ) ; //Remove Contact using Range of Ele 
                Console.WriteLine("You Have Removed Contact Details");
=======
                Console.WriteLine("AddressBook is Empty");
>>>>>>> UC4-RemoveContact

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
