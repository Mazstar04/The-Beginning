using System;

namespace Toyyib
{
    public class AdmissionDetails
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string DateOfBirth { get; set; }
        string StateOfOrigin { get; set; }
        string NIN { get; set; }
        string E_Mail { get; set; }
        string Address { get; set; }
        string Gender { get; set; }
        string InstitutionOfChoice { get; set; }
        string Course { get; set; }


        public AdmissionDetails(string firstName, string lastName, string middleName, string dob, string statefOrigin, string nin, string email, string address, string gender, string institutionOfChoice, string course)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dob;
            StateOfOrigin = statefOrigin;
            NIN = nin;
            E_Mail = email;
            Address = address;
            Gender = gender;
            InstitutionOfChoice = institutionOfChoice;
            Course = course;
        }

        public static char GetRandomLetter()
        {
            Random random = new Random();
            int firstRandom = random.Next(0, 26);
            char firstRandomLetter = (char)('A' + firstRandom);
            return firstRandomLetter;
        }
        public static void GetRegistrationNumber()
        {
            Random random = new Random();
            string randomNum = random.Next(000000, 1000000).ToString();
            Console.WriteLine($"Your Registration Number is: {GetRandomLetter()}{GetRandomLetter()}{randomNum}{GetRandomLetter()}");
        }
    }

}
