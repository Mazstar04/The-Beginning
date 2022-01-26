using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your First number: ");

            int fnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Second number: ");

            int snum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the operation you want to perform Here: ");

            string operation = Console.ReadLine();

                     operation = operation.Trim();

            switch (operation)
            {
                case "add":
                case "+":
                    int sum = Add(fnum, snum);
                    Console.WriteLine($"{fnum} + {snum} = {sum}");
                    break;
                case "subtract":
                case "-":
                    int subtract = Subtract(fnum, snum);
                    Console.WriteLine($"{fnum} - {snum} = {subtract}");
                    break;
                case "multiply":
                case "*":
                    int mul = Multiply(fnum, snum);
                    Console.WriteLine($"{fnum} * {snum} = {mul}");
                    break;
                case "division":
                case "/":
                    double div = Divide(fnum, snum);
                    Console.WriteLine($"{fnum} / {snum} = {div}");
                    break;
                default:
                    Console.WriteLine("Invalid Operation!");
                    break;
            }
        }

        public static int Add(int fNum,int sNum)
        {
            int sum = fNum + sNum;
            return sum;
        }
        public static int Subtract(int fNum,int sNum)
        {
            int subtract = fNum - sNum;
            return subtract;
        }
        public static int Multiply(int fNum,int sNum)
        {
            int mul = fNum*sNum;
            return mul;
        }
        public static double Divide(int fNum,int sNum)
        {
            double div = Convert.ToDouble(fNum) / Convert.ToDouble(sNum);
            return div;
        }

        
    }
}
