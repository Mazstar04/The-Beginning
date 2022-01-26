using System;

namespace Class
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your principal: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your interest: ");
            double interest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            double numberOfYears = Convert.ToDouble(Console.ReadLine());
            
            Investment investment = new Investment(principal, interest, numberOfYears);

            Investment.Value();
           
            
        }
    }
}
