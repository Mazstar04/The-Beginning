using System;

namespace JambApp
{
    public class Aspirant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string NIN { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string RegistrationNumber { get; set; }
        public string Institution { get; set; }
        public string Course { get; set; }

        public Aspirant(string firstName, string lastName, DateTime dateOfBirth, string address, string email, string nIN, string gender, string state, string registrationNumber, string institution, string course, string middleName = "")
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            Address = address;
            Email = email;
            NIN = nIN;
            Gender = gender;
            State = state;
            RegistrationNumber = registrationNumber;
            Institution = institution;
            Course = course;
        }

        public static string AspirantToString(Aspirant aspirant)
        {
            string aspirantString = $"{aspirant.FirstName} - {aspirant.LastName} - {aspirant.DateOfBirth.ToString()} - {aspirant.Address} - {aspirant.Email} - {aspirant.NIN} - {aspirant.Gender} - {aspirant.State} - {aspirant.RegistrationNumber} - {aspirant.Institution} - {aspirant.Course} - {aspirant.MiddleName}";
            return aspirantString;
        }

        public static Aspirant Parse(string aspirantString)
        {
            string[] aspirantDetails = aspirantString.Split("-");

            string firstName = aspirantDetails[0];
            string lastName = aspirantDetails[1];
            DateTime dateOfBirth = DateTime.Parse(aspirantDetails[2]);
            string address = aspirantDetails[3];
            string email = aspirantDetails[4];
            string nin = aspirantDetails[5];
            string gender = aspirantDetails[6];
            string state = aspirantDetails[7];
            string registrationNumber = aspirantDetails[8];
            string institution = aspirantDetails[9];
            string course = aspirantDetails[10];
            string middleName = aspirantDetails[11];

            Aspirant aspirant = new Aspirant(firstName, lastName, dateOfBirth, address, email, nin, gender, state, registrationNumber, institution, course, middleName);

            return aspirant;
        }
    }
}