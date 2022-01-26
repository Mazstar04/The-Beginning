using System;
using System.Collections.Generic;

namespace JambApp
{
    public class Aspirant
    {
        public Aspirant(string firstName, string middleName, string address, string nIN, string state, string institution)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.Address = address;
            this.NIN = nIN;
            this.State = state;
            this.Institution = institution;

        }
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
            RegistrationNumber = registrationNumber.Trim();
            Institution = institution;
            Course = course;
        }
        public static string AspirantToString(Aspirant aspirant)
        {

            string[] DateAndTime = aspirant.DateOfBirth.ToString().Split(' ');
            string dateOnly = DateAndTime[0];
            string aspirantString = $"{aspirant.FirstName}-{aspirant.LastName}-{aspirant.MiddleName}-{dateOnly}-{aspirant.Address}-{aspirant.Email}-{aspirant.NIN}-{aspirant.Gender}-{aspirant.State}-{aspirant.RegistrationNumber}-{aspirant.Institution}-{aspirant.Course}";
            return aspirantString;
        }
        public static Aspirant StringToAspirant(string aspirantString)
        {
            string [] aspirantDetails = aspirantString.Split('-');

            string firstName = aspirantDetails[0];
            string lastName = aspirantDetails[1];
            string middleName = aspirantDetails[2];
            DateTime dateOfBirth = Convert.ToDateTime(aspirantDetails[3]);
            string address = aspirantDetails[4];
            string email = aspirantDetails[5];
            string nin = aspirantDetails[6];
            string gender = aspirantDetails[7];
            string state = aspirantDetails[8];
            string registrationNumber = aspirantDetails[9];
            string institution = aspirantDetails[10];
            string course = aspirantDetails[11];
           
            Aspirant aspirant = new Aspirant(firstName, lastName, dateOfBirth, address, email, nin, gender, state, registrationNumber, institution, course, middleName);
            
            return aspirant;
        }
    }
}