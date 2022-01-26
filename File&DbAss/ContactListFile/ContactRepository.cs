using System;
using System.Collections.Generic;
using System.IO;

namespace ContactRecord
{
    public class ContactRepository
    {
        public List<ContactEntity> Contacts = new List<ContactEntity>();

        public ContactRepository()
        {
            FetchContactInfoFromFile();
        }

        public void FetchContactInfoFromFile()
        {
            try
            {
                var contactInfoLines = File.ReadAllLines("MyContactList.txt");
                foreach (var contactInfoLine in contactInfoLines)
                {
                    var contact = ContactEntity.StringToStudentEntity(contactInfoLine);
                    Contacts.Add(contact);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void GetContactInfo()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"Contact Id: {contact.Id}, Contact Name: {contact.Name}, Phone Number: {contact.PhoneNumber}, Email: {contact.Email}, Office Address: {contact.OfficeAddress} ");
            }
        }

        public List<ContactEntity> ListContactInfo()
        {
            return Contacts;
        }

        public void AddContactInfo(int id, string name, string phoneNumber, string eMail, string officeAddress)
        {
            var contactExist = FindContactByPhoneNo(phoneNumber);

            if (contactExist != null)
            {
                Console.WriteLine($"Contact with No:{phoneNumber} already exist");
            }
            else
            {
                ContactEntity contact = new ContactEntity(id, name, phoneNumber, eMail, officeAddress);

            Contacts.Add(contact);

            TextWriter writer = new StreamWriter("MyContactList.txt", true);
            writer.WriteLine(contact.ToString());
            Console.WriteLine("Contact added successfully!");
            writer.Close();}
        }
        public void RefreshFile()
        {
            TextWriter writer = new StreamWriter("MyContactList.txt");
            foreach (var contact in Contacts)
            {
                writer.WriteLine(contact);
            }
            writer.Flush();
            writer.Close();
        }
        public void DeleteContactByEmail(string eMail)
        {
            Contacts.RemoveAll(contact => contact.Email == eMail);
            RefreshFile();
            Console.WriteLine("Contact Deleted Sucessfully!!");
        }
        public ContactEntity FindContactByPhoneNo(string phoneNumber)
        {
            return Contacts.Find(s => s.PhoneNumber == phoneNumber);
        }

        public ContactEntity FindContactByName(string name)
        {
            return Contacts.Find(s => s.Name == name);
        }
        public ContactEntity FindContactById(int id)
        {
            return Contacts.Find(s => s.Id == id);
        }

        public void FindContact()
        {
            Console.Write("Enter the name of Contact you want to find: ");
            string name = Console.ReadLine().ToLower();

            var contact = FindContactByName(name);

            if (contact == null)
            {
                Console.WriteLine($"Contact: {name} does not exist! ");
            }

            else
            {
                Console.WriteLine($"Contact Id: {contact.Id}, Contact Name: {contact.Name}, Phone Number: {contact.PhoneNumber}, Email: {contact.Email}, Office Address: {contact.OfficeAddress} ");
            }
        }
        public void UpdateContact(int id, string name, string phoneNumber, string eMail, string officeAddress)
        {
            var contact = FindContactById(id);

            if (contact == null)
            {
                Console.WriteLine($"Contact with Id: {id} does not exist");
            }
            else
            {
                contact.Name = name;
                contact.PhoneNumber = phoneNumber;
                contact.Email = eMail;
                contact.OfficeAddress = officeAddress;
                Console.WriteLine("Contact Updated Sucessfully!!");
            }
        }
        // public void Search(string search)
        // {
        //     foreach(var contact in Contacts)
        //     {
        //         if(Contacts.Contains(contact))
        //     }
        // }
    }
}