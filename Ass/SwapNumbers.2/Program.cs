using System;

namespace SwapNumbers._2
{
    class Program
    {
        static void Main(string[] args)
        {
           int x =4;
           int y= 5;
           int z = x;
            x = y;
            y = z;
            Console.WriteLine($"x equal to {x}");
            Console.WriteLine($"y equal to {y}");
        }
        
    }
}
