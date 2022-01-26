using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 1; x <= 12; x++) //initialization, condition, iteration
            {
                Console.WriteLine($"3 x {x} = {3 * x}");
            }
        }
    }
}
