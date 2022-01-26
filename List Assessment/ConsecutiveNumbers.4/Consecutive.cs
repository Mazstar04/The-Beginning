using System;
using System.Collections.Generic;

namespace ConsecutiveNumbers
{
    public class Consecutive
    {
        public static void ConsecutiveNumbers()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Enter your Numbers and seperate them with space: ");
            string numbers = Console.ReadLine();
            string[] numbersInputed = numbers.Split(' ');
            for (int i = 0; i < numbersInputed.Length; i++)
            {
                int listNumbers = Convert.ToInt32(numbersInputed[i]);
                Numbers.Add(listNumbers);
            }

            if (Numbers[0] == Numbers[1] - 1 && Numbers[1] == Numbers[2] - 1 && Numbers[2] == Numbers[3] - 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}