using System;

namespace MultipleOf3And7._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any positive number of your choice: ");
            int pNum = Convert.ToInt32(Console.ReadLine());

            if (pNum % 5 > 0 && pNum % 7 > 0)
            {
                Console.WriteLine("It is neither a multiple of 5 nor 7");
            }
            else
            {
                if (pNum % 5 == 0 && pNum % 7 > 0)
                {
                    Console.WriteLine("It is a multiple of 5 but not of 7");
                }
                else if (pNum%5 > 0 && pNum%7 ==0)
                {
                    Console.WriteLine("It is a multiple  of 7 but not of 5");
                }
                else 
                {
                    Console.WriteLine("it is multiple of both 5 and 7");
                }
            }
        }
    }
}
