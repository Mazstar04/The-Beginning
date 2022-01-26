using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            Console.Write("Even numbers from 0 to 100 are: ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    j += i;
                }
                
            } 
            Console.WriteLine($"The sum of all even numbers btw 0 & 100 is {j}");

        }
    }
}
 
