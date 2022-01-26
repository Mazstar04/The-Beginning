using System;

namespace ass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age: ");

            int age = Convert.ToInt32(Console.ReadLine());
        
            if (age <= 0 || age > 100)
            {
                Console.WriteLine("Invalid Age");

            }
            else if (age < 21)
            {
                Console.WriteLine("You need parental consent!");
            }
            else if (age > 59)
            {
                Console.WriteLine("Due to the Covid-19 rule, you cannot participate in this event");
            }
            else
            {
                Console.WriteLine("You are Legible for the registration!");
            } 

        }
    }
}
