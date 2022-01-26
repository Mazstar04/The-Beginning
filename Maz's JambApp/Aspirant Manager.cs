using System;
using System.Collections.Generic;
using System.IO;

namespace JambApp
{
    public static class Aspirant_Manager
    {
        public static List<Aspirant> aspirants = new List<Aspirant>();
        public static void CollectUserDetails()
        {
            Registration registration = new Registration();

            bool continueReg = true;

            while (continueReg)
            {
                Aspirant aspirant = registration.Register();

                aspirants.Add(aspirant);

                Console.WriteLine($"Your Registration Number is: {aspirant.RegistrationNumber}");

                Console.Write("Do you want to continue(y/n): ");
                string answer = Console.ReadLine().ToLower().Trim();

                if (answer == "n")
                {
                    RefreshFile();
                    BackToMenu();
                }
                else
                {
                    CollectUserDetails();
                }
                if (MainMenu.UserOption == 0)
                {
                    return;
                }
            }
        }
        public static void BackToMenu()
        {
            Console.WriteLine("Press any key to go back to Menu: ");
            Console.ReadKey();
            Console.WriteLine(" ");
            MainMenu.Menu();
        }
        public static void ShowUpdateMenu()
        {
            Console.WriteLine("0. Back to Main Menu");
            Console.WriteLine("1. Update First Name");
            Console.WriteLine("2. Update Last Name");
            Console.WriteLine("3. Update Date Of Birth");
        }
        public static void UpdateAspirant()
        {
            Console.Write("Enter your Registration Number: ");
            string regNumber = Console.ReadLine().Trim();

            Aspirant aspirant = GetAspirantByRegNumber(regNumber);
            if (aspirant == null)
            {
                Console.WriteLine("There is no user with the Registration Number You Inputed");
                BackToMenu();
            }
            else
            {
                ShowUpdateMenu();
                Console.Write("Enter Option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 0)
                {
                    MainMenu.Menu();
                }
                else if (option == 1)
                {
                    Console.Write("Update First Name: ");
                    string updatedFirstName = Console.ReadLine();
                    aspirant.FirstName = updatedFirstName;
                    RefreshFile();
                    Console.WriteLine("Update Successful!!");
                    BackToMenu();
                }
                else if (option == 2)
                {
                    Console.Write("Update Last Name: ");
                    string updatedLastName = Console.ReadLine();
                    aspirant.LastName = updatedLastName;
                    RefreshFile();
                    Console.WriteLine("Update Successful!!");
                    BackToMenu();
                }
                else if (option == 3)
                {
                    Console.Write("Update Date Of Birth: ");
                    DateTime updatedDob = Convert.ToDateTime(Console.ReadLine());
                    aspirant.DateOfBirth = updatedDob;
                    RefreshFile();
                    Console.WriteLine("Update Successful!!");
                    BackToMenu();
                }
                else
                {
                    Console.WriteLine("Invalid Option!!");
                    BackToMenu();
                }
            }
        }
        public static void DeleteAspirant()
        {
            Console.Write("Enter your Registration Number: ");
            string regNumber = Console.ReadLine().Trim();

            Aspirant aspirant = GetAspirantByRegNumber(regNumber);

            if (aspirant == null)
            {
                Console.WriteLine("There is no user with the Registration Number You Inputed");
                BackToMenu();
            }
            else
            {
                Console.WriteLine($"Are you want to delete the details of {aspirant.FirstName} {aspirant.LastName}?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("Option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    aspirants.Remove(aspirant);
                    RefreshFile();
                    Console.WriteLine("Aspirant Information has been deleted Successfully!!");
                    BackToMenu();
                }
                else if (option == 2)
                {
                    BackToMenu();
                }
                else
                {
                    Console.WriteLine("Invalid Option!!");
                    MainMenu.Menu();
                }
            }
        }
        public static void ShowAspirantInfo()
        {
            Console.Write("Enter your Registration Number: ");
            string regNumber = Console.ReadLine().Trim();

            Aspirant aspirant = GetAspirantByRegNumber(regNumber);
            if (aspirant == null)
            {
                Console.WriteLine("There is no user with the Registration Number You Inputed");
                MainMenu.Menu();
            }
            else
            {
                Console.WriteLine($"First Name: {aspirant.FirstName}");
                Console.WriteLine($"Last Name: {aspirant.LastName}");
                Console.WriteLine($"Date Of Birth: {aspirant.DateOfBirth}");
                Console.WriteLine($"Registration Number: {aspirant.RegistrationNumber}");
                BackToMenu();
            }
        }
        public static Aspirant GetAspirantByRegNumber(string regNumber)
        {
            foreach (var aspirant in aspirants)
            {
                if (aspirant.RegistrationNumber == regNumber)
                {
                    return aspirant;
                }
            }
            return null;
        }
        public static void RefreshList()
        {
            aspirants = new List<Aspirant>();

            string[] aspirantsInFile = File.ReadAllLines("files//Aspirants.txt");
            foreach (var aspirant in aspirantsInFile)
            {
                aspirants.Add(Aspirant.StringToAspirant(aspirant));
            }
        }
        public static void RefreshFile()
        {
            File.Delete("files//Aspirants.txt");
            foreach (var aspirant in aspirants)
            {
                string aspirantString = Aspirant.AspirantToString(aspirant);
                File.AppendAllText("files\\Aspirants.txt", $"{aspirantString} \n");
            }
        }
        public static List<Aspirant> SortByInstitution(string option)
        {
            List<Aspirant> aspirant = new List<Aspirant>();
            foreach (var aspirante in aspirants)
            {
                if (aspirante.Institution == option)
                {
                    aspirant.Add(aspirante);
                }
            }
            return aspirant;
        }
        public static void PrintSortByInstitution()
        {
            Console.Write("Enter the Institution: ");
            string option = Console.ReadLine().ToUpper().Trim();
            List<Aspirant> aspirantCollect = SortByInstitution(option);
            if (aspirantCollect.Count == 0)
            {
                Console.WriteLine("No Aspirants has choosen this Institution");
            }
            foreach (var aspirant in aspirantCollect)
            {
                Console.WriteLine($"Name: {aspirant.FirstName} {aspirant.LastName}\nCourse: {aspirant.Course}\nInstitution: {aspirant.Institution}\n");
            }
        }
    }
}