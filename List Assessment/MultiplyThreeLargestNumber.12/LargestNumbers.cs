using System;
using System.Collections.Generic;

namespace MultiplyThreeLargestNumber
{
    public class LargestNumbers
    {
        public static void Multiplication()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Enter the numbers and seperate them with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(' ');

            int temp;

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            for (int j = 0; j <= userInput.Length - 2; j++)
            {
                for (int i = 0; i <= userInput.Length - 2; i++)
                {
                    if (Numbers[i] < Numbers[i + 1])
                    {
                        temp = Numbers[i + 1];
                        Numbers[i + 1] = Numbers[i];
                        Numbers[i] = temp;
                    }
                }
            }
            Console.WriteLine($"The three Largest Numbers are: {Numbers[0]}, {Numbers[1]}, {Numbers[2]}");
            Console.WriteLine($"Their product is: {Numbers[0] * Numbers[1] * Numbers[2]}");
        }
    }
}