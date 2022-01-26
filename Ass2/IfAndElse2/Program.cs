using System;

namespace IfAndElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number btw 0 and 6 to know the present day of the week: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            string [] days = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            Console.WriteLine($"Today is {days[userInput]}");

            Console.Write("What day of the week will we be in: ");
            int future = Convert.ToInt32(Console.ReadLine());

            if(userInput<0 || userInput>6)
            {
                Console.WriteLine("Invalid Number!!");
            }
            else if(true)
            {
                Console.WriteLine($"The day of the week you predicted is {days[(userInput+future)%7]}");
            }

        }
    }
}
