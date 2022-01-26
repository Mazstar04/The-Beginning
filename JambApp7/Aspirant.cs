using System;
using System.Collections.Generic;
using System.Linq;

namespace JambApp7
{
    public class Aspirant
    {
        public string FirstName;
        public string LastName;
        public string RegNo;
        public int YearOfBirth;
        public string Gender;
        public string Institution;
        public string Course;
        public bool IsAdmitted;

        List<Aspirant> Aspirants = new List<Aspirant>();

        public Aspirant(string firstName, string lastName, int yearOfBirth, string gender, string institution, string course, string regNo)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            Gender = gender;
            Institution = institution;
            Course = course;
            IsAdmitted = false;
            RegNo = regNo;
        }

        public Aspirant()
        {
        }

        public void MainMenu()
        {
            Console.WriteLine("Joint Administration Matriculation Board");
            Console.WriteLine("1. Register Aspirants");
            Console.WriteLine("2. Check Admission Status");
            Console.WriteLine("3. Update Details");
            Console.WriteLine("4. Admit Students");
            Console.WriteLine("0. Exit");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    Register();
                    break;
                case 2:
                    Console.Clear();
                    CheckAdmissionStatus();
                    break;
                case 3:
                    Console.Clear();
                    UpdateDetails();
                    break;
                case 4:
                    Console.Clear();
                    SubMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            };
        }

        private void SubMenu()
        {
            Console.WriteLine("Admit Students");
            Console.WriteLine("1. By Registration Number");
            Console.WriteLine("2. By Prefered Course");
            Console.WriteLine("3. By Instituion");
            Console.WriteLine("4. Back to Main Menu");
            Console.WriteLine("0. Exit");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    AdmitStudentsByRegNumber();
                    break;
                case 2:
                    Console.Clear();
                    AdmitStudentsByCourse();
                    break;
                case 3:
                    Console.Clear();
                    AdmitStudentsByInstitution();
                    break;
                case 4:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            };
        }

        private string GenerateRegNo()
        {
            Random random = new Random();
            int digit = random.Next(1000, 9999);
            char firstLetter = (char)random.Next(65, 92);
            char secondLetter = (char)random.Next(65, 92);
            return $"JB{digit}{firstLetter}{secondLetter}";
        }

        private bool CheckAge(int year)
        {
            bool difference = DateTime.Now.Year - year >= 18;
            return difference;
        }

        private void Register()
        {
            Console.Write("First Name: ");
            string fName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lName = Console.ReadLine();

            Console.Write("Year of Birth(eg. 2021): ");
            int yob = int.Parse(Console.ReadLine());
            bool checkYob = CheckAge(yob);
            if (!checkYob)
            {
                Console.WriteLine("You are Underage!!");
                MainMenu();
            }

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Choice of Institute: ");
            string institution = Console.ReadLine().ToUpper();

            Console.Write("Preferred Course: ");
            string course = Console.ReadLine().ToUpper();

            string regNo = GenerateRegNo();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congrats {lName} {fName} you have been Sucessfully Registered. Your Reg No. is {regNo}");
            Aspirant aspirant = new(fName, lName, yob, gender, institution, course, regNo);
            Aspirants.Add(aspirant);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            MainMenu();
        }

        private void CheckAdmissionStatus()
        {
            Console.Write("Enter Registration Number of Student: ");
            string regNo = Console.ReadLine().ToUpper().Trim();

            foreach (var aspirant in Aspirants)
            {
                if (aspirant.RegNo == regNo)
                {
                    Console.WriteLine($"Welcome {aspirant.LastName} {aspirant.FirstName}");
                    if (aspirant.IsAdmitted == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You are yet to be Admitted");
                        Console.WriteLine("Make sure to check your CAPS regularly for Future Updates!");



                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congratulations!!");
                        Console.WriteLine($"You have been Admitted into {aspirant.Institution} to offer {aspirant.Course}");

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    MainMenu();
                }

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"There is no Student with Registration Number - {regNo}");
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu();
        }

        private void AdmitStudentsByRegNumber()
        {
            Console.Write("Enter Registration Number of Student: ");
            string regNo = Console.ReadLine().ToUpper().Trim();

            foreach (var aspirant in Aspirants)
            {
                if (aspirant.RegNo == regNo)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    aspirant.IsAdmitted = true;
                    Console.WriteLine($"You have Sucessfully admitted {aspirant.LastName} {aspirant.FirstName}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    MainMenu();
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"There is no Student with Registration Number - {regNo}");
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu();

        }

        private void AdmitStudentsByCourse()
        {
            Console.Write("Enter Course: ");
            string course = Console.ReadLine().ToUpper().Trim();

            foreach (var aspirant in Aspirants)
            {
                if (aspirant.Course == course)
                {
                    aspirant.IsAdmitted = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You have Sucessfully admitted {aspirant.LastName} {aspirant.FirstName}");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            MainMenu();

        }

        private void AdmitStudentsByInstitution()
        {
            Console.Write("Enter Institution Name: ");
            string institution = Console.ReadLine().ToUpper().Trim();

            foreach (var aspirant in Aspirants)
            {
                if (aspirant.Institution == institution)
                {
                    aspirant.IsAdmitted = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You have Sucessfully admitted {aspirant.LastName} {aspirant.FirstName}");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            MainMenu();

        }

        private void UpdateDetails()
        {
            Console.Write("Enter Student Registration Number: ");
            string regNo = Console.ReadLine().ToUpper().Trim();

            foreach (var aspirant in Aspirants)
            {
                if (aspirant.RegNo == regNo)
                {
                    if (aspirant.IsAdmitted)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The Aspirant {aspirant.LastName} {aspirant.FirstName} has already been offered Admission");
                        Console.WriteLine("You Cannot Edit the Details of this Student!!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Update First Name: ");
                        aspirant.FirstName = Console.ReadLine();

                        Console.Write("Update Last Name: ");
                        aspirant.LastName = Console.ReadLine();

                        Console.Write("Update Year of Birth(eg. 2021): ");
                        int yob = int.Parse(Console.ReadLine());
                        bool checkYob = CheckAge(yob);
                        if (!checkYob)
                        {
                            Console.WriteLine("You are Underage!!");
                            MainMenu();
                        }
                        aspirant.YearOfBirth = yob;

                        Console.Write("Update Gender: ");
                        aspirant.Gender = Console.ReadLine();

                        Console.Write("Update Choice of Institute: ");
                        aspirant.Institution = Console.ReadLine().ToUpper();

                        Console.Write("Update Preferred Course: ");
                        aspirant.Course = Console.ReadLine().ToUpper();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You have Sucessfully Updated The Detail of Aspirant with RegNo - {aspirant.RegNo}");
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    MainMenu();

                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"There is no Student with Registration Number - {regNo}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            MainMenu();

        }
    }

}