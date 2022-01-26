using System;

namespace Division._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your First Number: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Your Second Number: ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Division of your two numbers is {fNum/sNum}");
        }
    }
}
