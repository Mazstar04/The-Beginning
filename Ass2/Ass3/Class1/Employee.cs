using System;

namespace Class
{
    public class Employee
    {
        public static void GetInfo()
        {
            Console.Write("Enter your salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of hours you work per day: ");
            int noOfHoursPerDay = Convert.ToInt32(Console.ReadLine());
            AddSal(salary);
            AddWork(noOfHoursPerDay, salary);

        }
        public static void AddSal(int salary)
        {
            if(salary<500)
            {   
                salary+=10;
                Console.WriteLine($"You have been rewarded with additional $10, your new salary is {salary}");
            }
            else
            {
                Console.WriteLine($"Your salary remains {salary}");
            }

        }
        public static void AddWork(int noOfHoursPerDay, int salary)
        {
            if(noOfHoursPerDay > 6 && salary<500)
            {
                Console.WriteLine($"You have been rewarded with additional $5, your new salary is {salary + 5 + 10}");
            }
            else if (noOfHoursPerDay>6 && salary>=500)
            {
                Console.WriteLine($"You have been rewarded with additional $5, your new salary is {salary + 5}");
            }
            else if(noOfHoursPerDay<6 && salary < 500)
            {
                Console.WriteLine("");
            }
            
            else
            {
                Console.WriteLine($"Your salary remains {salary}");
            }
        }
    }
}