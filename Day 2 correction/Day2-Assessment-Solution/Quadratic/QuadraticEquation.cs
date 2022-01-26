using System;
namespace Quadratic
{
    public class QuadraticEquation
    {
        private double A;
        private double B;
        private double C;

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetDiscriminant()
        {
            double discriminant = Math.Pow(B, 2) - (4 * A * C);

            return discriminant;
        }

        public double GetA()
        {
            return A;
        }

        public double GetB()
        {
            return B;
        }
        public double GetC()
        {
            return C;
        }

        public double[] GetRoots()
        {
            // double discriminant = GetDiscriminant();
            double discriminant = -1;

            if (discriminant < 0)
            {
                double[] result = new double[0];
                return result;
            }

            else if (discriminant == 0)
            {
                double[] result = new double[1];
                double root1 = GetRoot1();
                result[0] = root1;
                return result;
            }
            else
            {
                double[] result = new double[2];
                double root1 = GetRoot1();
                double root2 = GetRoot2();
                result[0] = root1;
                result[1] = root2;
                return result;
            }

        }
        public double GetRoot1()
        {
            double discriminant = GetDiscriminant();
            double root = ((-1 * B) + Math.Sqrt(discriminant)) / (2 * A);
            return root;
        }
        public double GetRoot2()
        {
            double discriminant = GetDiscriminant();
            double root = ((-1 * B) - Math.Sqrt(discriminant)) / (2 * A);
            return root;
        }


    }
}