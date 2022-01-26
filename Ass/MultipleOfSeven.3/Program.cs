using System;

namespace MultipleOfSeven._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Multiples of Seven Between 1 and 1,000 are: ");
            for(int i=7; i<=1000; i+=7)
            Console.WriteLine(i);
        }
    }
}
