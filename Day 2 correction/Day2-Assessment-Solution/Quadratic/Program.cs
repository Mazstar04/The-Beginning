using System;

namespace Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Math.Pow(2, 3));
            QuadraticEquation quad = new QuadraticEquation(2, 3, 4);

            double[] roots = quad.GetRoots();

            if (roots.Length == 0)
            {
                Console.WriteLine("This equation has no root");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine($"The discriminant of the equation is 0 and the roots is {roots[0]}");
            }
            else
            {
                Console.WriteLine($"Root 1 of the equation {roots[0]}");
                Console.WriteLine($"Root 2 of the equation {roots[1]}");
            }
        }
    }
}
