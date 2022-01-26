using System;

namespace Multiplication_Table
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter any number of your choice : ");
            int numOfChoice = Convert.ToInt32(Console.ReadLine());

            if (numOfChoice<=0)
            {
                Console.WriteLine("Your number must be greater than 0");
            }
            else
            {
            WithWhile(numOfChoice);
            WithFor(numOfChoice);
            WithDoWhile(numOfChoice);
            }
        }

        public static void WithWhile(int numOfChoice)
        {
            int i = 0;

            while (i < 13)
            {
                i++;
                Console.WriteLine($"{numOfChoice} x {i} = {numOfChoice * i}");
            }

        }
        public static void WithFor(int numOfChoice)
        {

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{numOfChoice} x {i} = {numOfChoice * i}");
            }

        }
        public static void WithDoWhile(int numOfChoice)
        {

            int i = 1;
            do
            {
                Console.WriteLine($"{numOfChoice} x {i} = {numOfChoice * i}");
                i++;
            }
            while (i < 13);

        }
    }

}
