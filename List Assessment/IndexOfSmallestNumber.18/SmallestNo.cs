using System;
using System.Collections.Generic;

namespace IndexOfSmallestNumber
{
    public class SmallestNo
    {
        public static void IndexOfSmallestNumber()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Input the numbers and seperate them with space: ");
            string userInput = Console.ReadLine();
            string[] userOption = userInput.Split(' ');
            int index = 0;
            int smallestNumber = 0;

            for (int i = 0; i < userOption.Length; i++)
            {
                int userNumbers = Convert.ToInt32(userOption[i]);
                Numbers.Add(userNumbers);
            }
            int small = Numbers[0];

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] <= small)
                {
                    index = i;
                    smallestNumber = Numbers[i];
                }
            }
            Console.WriteLine($"The index of the smallest number = {index}");
            Console.WriteLine($"The smallest number = {smallestNumber}");
        }
    }
}