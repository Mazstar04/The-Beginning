using System;
using System.Collections.Generic;

namespace EvenAndOddIndexes
{
    public class Indexes
    {
        public static void EvenAndOddIndexes()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Input ten numbers and seperate them wuth space: ");
            string userInput = Console.ReadLine();
            string[] userOption = userInput.Split(' ');
            int SumAtOddIndexes = 0;
            int SumAtEvenIndexes = 0;

            for (int i = 0; i < userOption.Length; i++)
            {
                int userNumbers = Convert.ToInt32(userOption[i]);
                Numbers.Add(userNumbers);
            }

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    SumAtEvenIndexes += Numbers[i];
                }
                else
                {
                    SumAtOddIndexes += Numbers[i];
                }
            }

            Console.WriteLine($"The Addition of Numbers @ Even Indexes = {SumAtEvenIndexes}");
            Console.WriteLine($"The Addition of Numbers @ Odd Indexes = {SumAtOddIndexes}");
        }
    }
}