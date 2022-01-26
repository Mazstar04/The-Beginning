using System;

namespace Operations._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First Number: ");
            double fNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Your Second Number: ");
            double sNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Operation you want to perform: ");
            string operation = Console.ReadLine();
            operation = operation.ToLower();
            operation = operation.Trim();

            switch (operation)
            {
                case "add":
                case "+":
                    Addition(fNum, sNum);
                    break;

                case "subtract":
                case "-":
                    Subtraction(fNum, sNum);
                    break;

                case "divide":
                case "/":
                    Division(fNum, sNum);
                    break;

                case "multiply":
                case "x":
                    Multiply(fNum, sNum);
                    break;

            }

        }
        public static double Addition(double fNum, double sNum)
        {
            double sum = fNum + sNum;
            Console.WriteLine(sum);
            return sum;
        }
        public static double Subtraction(double fNum, double sNum)
        {
            double sub = fNum - sNum;
            Console.WriteLine(sub);
            return sub;
        }
        public static double Division(double fNum, double sNum)
        {
            double div = fNum / sNum;
            Console.WriteLine(div);
            return div;
        }
        public static double Multiply(double fNum, double sNum)
        {
            double mul = fNum * sNum;
            Console.WriteLine(mul);
            return mul;
        }
    }
}
