using System;

namespace QuadraticEquation._23
{
    class Program
    {
        static void Main(string[] args)
        {`
            Quadratic quadratic = new Quadratic();
            quadratic.SolveQuadratic(32, 45, 12);
        }
    }
    class Quadratic
    {
        public void SolveQuadratic(double a, double b, double c)

        {

            double sqrtpart = b * b - 4 * a * c;

            double x, x1, x2, img;

            if (sqrtpart > 0)

            {

                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);

                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);

                Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);

            }

            else if (sqrtpart < 0)

            {

                sqrtpart = -sqrtpart;

                x = -b / (2 * a);

                img = System.Math.Sqrt(sqrtpart) / (2 * a);

                Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);

            }

            else

            {

                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);

                Console.WriteLine("One Real Solution: {0,8:f4}", x);

            }

        }
    }
}
