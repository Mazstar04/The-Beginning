using System;
namespace Toyyib
{
    public class GetAspirantInformation
    {
        public AdmissionDetails GetInfo()
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Middle name: ");
            string middleName = Console.ReadLine();

            Console.Write("Date Of Birth (YYYY/mm/dd): ");
            string dob = Console.ReadLine();

            Console.Write("State Of Origin: ");
            string statefOrigin = Console.ReadLine();

            Console.Write("National Identification Number(NIN): ");
            string nin = Console.ReadLine();

            Console.Write("E-mail Address: ");
            string email = Console.ReadLine();

            Console.Write("Address of Residence: ");
            string address = Console.ReadLine();

            Console.Write("Gender (Male/Female ): ");
            string gender = Console.ReadLine();

            Console.Write("Institution of Choice: ");
            string institutionOfChoice = Console.ReadLine();

            Console.Write("Course: ");
            string course = Console.ReadLine();

            AdmissionDetails admissionDetails = new AdmissionDetails(firstName, lastName, middleName, dob, statefOrigin, nin, email, address, gender, institutionOfChoice, course);

            return admissionDetails;
        }
    }
}