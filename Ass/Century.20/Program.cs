using System;

namespace Century._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any year of your choice: ");
            int yearOfChoice = Convert.ToInt32(Console.ReadLine());

            int century =yearOfChoice/100 + 1;
            Console.WriteLine($"{century} century");
        }
    }
}
