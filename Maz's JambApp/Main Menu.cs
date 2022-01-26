using System;
using System.Collections.Generic;
using System.IO;

namespace JambApp
{
    public class MainMenu
    {
        public static int UserOption;
        public static void Menu()
        {
            Console.WriteLine("You are Welcome..... Choose the option you desire");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Register Aspirant");
            Console.WriteLine("2. List all Aspirants");
            Console.WriteLine("3. Input Reg.No of aspirant to print their Information");
            Console.WriteLine("4. Update Aspirant Information");
            Console.WriteLine("5. Delete Aspirant Information");
            Console.WriteLine("6. Find Applicants by School Name");

            Console.Write("Option: ");
            int userOption = Convert.ToInt32(Console.ReadLine().Trim());
            UserOption = userOption;

            if (userOption == 0)
            {
                UserOption = 0;
            }
            else if (userOption == 1)
            {
                Aspirant_Manager.RefreshList();
                Aspirant_Manager.CollectUserDetails();
            }
            else if (userOption == 2)
            {
                Aspirant_Manager.RefreshList();
                for (int i = 0; i < Aspirant_Manager.aspirants.Count; i++)
                {
                    Console.WriteLine($"First Name: {Aspirant_Manager.aspirants[i].FirstName}, Surname: {Aspirant_Manager.aspirants[i].LastName}, Date Of Birth: {Aspirant_Manager.aspirants[i].DateOfBirth} Registration Number: {Aspirant_Manager.aspirants[i].RegistrationNumber}");
                }
                Aspirant_Manager.BackToMenu();
            }
            else if (userOption == 3)
            {
                Aspirant_Manager.RefreshList();
                Aspirant_Manager.ShowAspirantInfo();
            }
            else if (userOption == 4)
            {
                Aspirant_Manager.RefreshList();
                Aspirant_Manager.UpdateAspirant();
            }
            else if (userOption == 5)
            {
                Aspirant_Manager.RefreshList();
                Aspirant_Manager.DeleteAspirant();
            }
            else if (userOption == 6)
            {
                Aspirant_Manager.RefreshList();
                Aspirant_Manager.PrintSortByInstitution();
                Aspirant_Manager.BackToMenu();
                
            }
            else
            {
                Console.WriteLine("Invalid Option!");
                Aspirant_Manager.BackToMenu();
            }
        }
    }
}