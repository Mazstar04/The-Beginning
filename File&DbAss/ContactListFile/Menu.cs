using System;
using System.Collections.Generic;

namespace ContactRecord
{
    public class Menu
    {
    
        static ContactRepository contactRepo = new ContactRepository();

        private void ShowMenu()
        {
            Console.WriteLine("0. Back");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. List all Contacts");
            Console.WriteLine("3. Find Contact Information");
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Search Contact");
        }

        public void AddContactDetails()
        {
            Console.Write("Contact Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Contact Name: ");
            string name = Console.ReadLine().ToLower();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine().Trim();

            Console.Write("E-mail Address: ");
            string eMail = Console.ReadLine().ToLower();

            Console.Write("Office Address: ");
            string officeAddress = Console.ReadLine();

            contactRepo.AddContactInfo(id, name, phoneNumber, eMail, officeAddress);
        }

        public void UpdateContactDetails()
        {
            Console.Write("Enter Id of Contact you want to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Update Name: ");
            string name = Console.ReadLine().ToLower();

            Console.Write("Update Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Update E-mail: ");
            string eMail = Console.ReadLine().ToLower();

            Console.Write("Update Office Address: ");
            string officeAddress = Console.ReadLine();

            contactRepo.UpdateContact(id, name, phoneNumber, eMail, officeAddress);
            contactRepo.RefreshFile();
        }

        public void DeleteContact()
        {
            Console.Write("Enter the E-mail of Contact you want to delete: ");
            string eMail = Console.ReadLine().ToLower();

            Console.Write("Are you sure you want to delete? (y/n) ");
            string option = Console.ReadLine().ToLower();

            if(option == "y")
            {
                contactRepo.DeleteContactByEmail(eMail);
            }

            else
            {
                ShowMenu();
            }
        }
        public void ShowContactMenu()
        {
            ShowMenu();
            Console.Write("Option: ");
            string option = Console.ReadLine().Trim();

            switch (option)
            {
                case "0":
                    break;
                case "1":
                    AddContactDetails();
                    ShowContactMenu();
                    break;
                case "2":
                    contactRepo.GetContactInfo();
                    ShowContactMenu();
                    break;

                case "3":
                    contactRepo.FindContact();
                    ShowContactMenu();
                    break;

                case "4":
                    UpdateContactDetails();
                    ShowContactMenu();
                    break;

                case "5":
                    DeleteContact();
                    ShowContactMenu();
                    break;
                    // case "6":
                    // contactRepo.ListAllStudentInJss1();
                    // ShowContacttMenu();
                    // break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }
}