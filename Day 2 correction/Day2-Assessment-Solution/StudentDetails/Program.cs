using System;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", 2, "08021345689", "Abeokuta Ogun State");
            Student student2 = new Student("Sam", 1,"07021345768", "Lekki, Lagos State");
            // created different instance of the student class and passsed different values through the constructor
            

            Console.WriteLine($"Name of the first student: {student1.Name}");
            Console.WriteLine($"Roll Number of the first student: {student1.RollNumber}");
            Console.WriteLine($"Phone Number of the first student: {student1.PhoneNumber}");
            Console.WriteLine($"Address of the first student: {student1.Address}");

            // displaying the first student details to the user
            
            Console.WriteLine(); // just putting a space in between 
            
            Console.WriteLine($"Name of the second student: {student2.Name}");
            Console.WriteLine($"Roll Number of the second student: {student2.RollNumber}");
            Console.WriteLine($"Phone Number of the second student: {student2.PhoneNumber}");
            Console.WriteLine($"Address of the second student: {student2.Address}");
            // displaying the second student details to user
        }
    }
}
