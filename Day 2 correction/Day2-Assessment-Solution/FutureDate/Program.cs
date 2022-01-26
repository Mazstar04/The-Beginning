using System;

namespace FutureDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" }; //An array of days of the week

            Console.WriteLine("Pick today's day of the week:");

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"{i}. {days[i]}");
                //writing out a short menu to guide the user input
            }

            int currentDay = Convert.ToInt32(Console.ReadLine());
            //collecting user input and convertingit to an integer

            if (currentDay < 0 || currentDay > days.Length - 1)
            //validating user input to make sure its a postive number and not more than the index of the array
            {
                Console.WriteLine("Pick a valid day");
            }

            else
            {

                Console.WriteLine($"You picked {days[currentDay]}"); 
                //displaying the day picked to the user

                Console.Write("Enter the number of days after today to determine: ");

                int numberOfDaysInFuture = Convert.ToInt32(Console.ReadLine());
                //geting user input for the day to determine in the future 

                string dayInFuture = days[(numberOfDaysInFuture + currentDay) % 7];
                //summing up the number of current day and the number of days in the future and factorizing it by the total number of days in the week to make it go over the days of the week over and over and getting the future day

                Console.WriteLine($"\n{numberOfDaysInFuture} days into the future is {dayInFuture}");
                //displaying the determined day to the user 

            }
        }
    }
}
