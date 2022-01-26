using System;
using MySql.Data.MySqlClient;

namespace ContactRecord
{
    public class Menu
    {
        static string connectionString = "server=localhost;user=root;database=contactmanagement;port=3306;password=419300";
        static MySqlConnection conn = new MySqlConnection(connectionString);
        ContactRepository contactRepo = new ContactRepository(conn);
        private void ContactMenu()
        {
            Console.WriteLine("0. Back");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. List all Contacts");
            Console.WriteLine("3. Find Contact Information");
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Search Contact");
        }
        private void AddContactInfo()
        {
            Console.Write("Contact Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Contact Name: ");
            string name = Console.ReadLine().ToLower().Trim();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine().Trim();

            Console.Write("E-mail Address: ");
            string eMail = Console.ReadLine().ToLower().Trim();

            Console.Write("Office Address: ");
            string officeAddress = Console.ReadLine();

            contactRepo.AddContactInfo(id, name, phoneNumber, eMail, officeAddress);
        }
        private void UpdateContact()
        {
            Console.Write("Enter E-Mail of contact you want to update: ");
            string eMail = Console.ReadLine().Trim().Trim();

            Console.Write("Update Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Update Name: ");
            string name = Console.ReadLine().ToLower();

            Console.Write("Update Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Update Office Address: ");
            string officeAddress = Console.ReadLine();

            contactRepo.UpdateContactInfo(id, name, phoneNumber, eMail, officeAddress);
        }
        private void DeleteContact()
        {
            Console.Write("Enter Name of Contact you want to Delete: ");
            string name = Console.ReadLine().ToLower().Trim();
            contactRepo.DeleteContact(name);
        }
        public void MainMenu()
        {
            ContactMenu();
            Console.Write("Option: ");
            string option = Console.ReadLine().Trim();

            switch (option)
            {
                case "0":
                    break;
                case "1":
                    AddContactInfo();
                    MainMenu();
                    break;
                case "2":
                    contactRepo.ListAllContacts();
                    MainMenu();
                    break;
                case "3":
                    Console.Write("Enter E-mail of the Student you want to Find: ");
                    string eMail = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine("");
                    contactRepo.FindContact(eMail);
                    MainMenu();
                    break;
                case "4":
                    UpdateContact();
                    MainMenu();
                    break;
                case "5":
                    DeleteContact();
                    MainMenu();
                    break;
                case "6":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }
}