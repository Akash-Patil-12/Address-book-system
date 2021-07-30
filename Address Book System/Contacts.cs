﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_System
{
    class Contacts
    {
        //variables
        String firstName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }
        /// <summary>
        /// Check contact available if it presents than edit in its data
        /// </summary>
        /// <param name="contactsUniqueList"></param>
        public void CheckContactAvaible(Dictionary<string, List<Contacts>> contactsUniqueList)
        {
            List<Contacts> listContacts = new List<Contacts>();
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter first name to check record");
            firstName = Console.ReadLine();
            if (contactsUniqueList.ContainsKey(firstName))
            {
                Console.WriteLine("Enter First Name");
                contacts.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                contacts.LastName = Console.ReadLine();
                Console.WriteLine("Enter address");
                contacts.Address = Console.ReadLine();
                Console.WriteLine("Enter city");
                contacts.City = Console.ReadLine();
                Console.WriteLine("Enter state");
                contacts.State = Console.ReadLine();
                Console.WriteLine("Enter zip code");
                contacts.Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter phone number");
                contacts.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter email");
                contacts.Email = Console.ReadLine();
                Console.WriteLine("Record Updated successfully...");
                listContacts.Add(contacts);
                contactsUniqueList.Remove(firstName);
                contactsUniqueList.Add(contacts.FirstName, listContacts);
            }
            else
            {
                Console.WriteLine("Record not found..");
            }
        }
        /// <summary>
        /// Delete specific record from contacts
        /// </summary>
        /// <param name="contactsUniqueList"></param>
        public void DeleteContacts(Dictionary<string, List<Contacts>> contactsUniqueList)
        {
            Console.WriteLine("Enter first name");
            firstName = Console.ReadLine();
            if (contactsUniqueList.ContainsKey(firstName))
            {
                contactsUniqueList.Remove(firstName);
                Console.WriteLine("Record deleted successfully...");
            }
            else
            Console.WriteLine("Record not found");
        }
        /// <summary>
        /// Add multiple person record 
        /// </summary>
        /// <param name="contactsUniqueList"></param>
        public void AddMultiplePerson(Dictionary<string, List<Contacts>> contactsUniqueList)
        {
            Console.WriteLine("How many person do you want to add");
            int personCount = Convert.ToInt32(Console.ReadLine());
            for (int count = 0; count < personCount; count++)
            {
                List<Contacts> listContacts = new List<Contacts>();
                Contacts contacts = new Contacts();
                Console.WriteLine("Fill record of person :" + (count + 1));
                Console.WriteLine("Enter First Name");
                contacts.FirstName = Console.ReadLine();
                if (contactsUniqueList.ContainsKey(contacts.FirstName))
                {
                    Console.WriteLine("This name is already present try with other name...");
                    count = (count-1);
                }
                else
                {
                    Console.WriteLine("Enter Last Name");
                    contacts.LastName = Console.ReadLine();
                    Console.WriteLine("Enter address");
                    contacts.Address = Console.ReadLine();
                    Console.WriteLine("Enter city");
                    contacts.City = Console.ReadLine();
                    Console.WriteLine("Enter state");
                    contacts.State = Console.ReadLine();
                    Console.WriteLine("Enter zip code");
                    contacts.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter phone number");
                    contacts.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter email");
                    contacts.Email = Console.ReadLine();
                    Console.WriteLine("Person added successully...");
                    listContacts.Add(contacts);
                    contactsUniqueList.Add(contacts.FirstName, listContacts);
                }
            }
        }
        /// <summary>
        /// Show all record of contacts
        /// </summary>
        /// <param name="contactsUniqueList"></param>
        public void ShowAllRecords(Dictionary<string, List<Contacts>> contactsUniqueList)
        {
            int count = 1;
            if ((contactsUniqueList.Count) > 0)
            {
                foreach (KeyValuePair < string,List<Contacts>> contacts1 in contactsUniqueList)
                {
                    foreach (Contacts contacts in contacts1.Value)
                    {
                        Console.WriteLine("...Contact Record :" + count + "...");
                        Console.WriteLine("Record of :"+contacts1.Key);
                        Console.WriteLine("First name :" + contacts.FirstName);
                        Console.WriteLine("Last name :" + contacts.LastName);
                        Console.WriteLine("Address :" + contacts.Address);
                        Console.WriteLine("City :" + contacts.City);
                        Console.WriteLine("State :" + contacts.State);
                        Console.WriteLine("Zip :" + contacts.Zip);
                        Console.WriteLine("Phone Number :" + contacts.PhoneNumber);
                        Console.WriteLine("Email :" + contacts.Email);
                        Console.WriteLine();
                        count++;
                    }
                }
            }
            else
                Console.WriteLine("Contacts record is empty");
        }
    }
}
