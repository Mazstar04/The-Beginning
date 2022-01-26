using System;

namespace MultiplicationTable._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number of your choice: ");
            int numOfChoice = Convert.ToInt32(Console.ReadLine());
            if(numOfChoice <= 0)
            {
                Console.WriteLine("Invalid Number!!");
            }
            else
            {
                Multiply(numOfChoice);
            }
        }
        public static void Multiply(int numOfChoice)
        {
            
            for(int i = 1; i <=12; i++)
            {
                Console.WriteLine($"{numOfChoice} x {i} = {numOfChoice*i}");
            }
        }
    }
}
