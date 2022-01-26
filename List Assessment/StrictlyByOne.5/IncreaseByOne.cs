using System;
using System.Collections.Generic;

namespace StrictlyByOne
{
    public class IncreaseByOne
    {
        public static void StrictlyByOne()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Input the numbers and seperate them with space: ");
            string userInput = Console.ReadLine();
            string[] userOption = userInput.Split(' ');
            int biggestNumber = 0;
            int smallestNumber = 0;

            for (int i = 0; i < userOption.Length; i++)
            {
                int userNumbers = Convert.ToInt32(userOption[i]);
                Numbers.Add(userNumbers);
            }
            int small = Numbers[0];
            int biggest = Numbers[0];

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] <= small)
                {
                    smallestNumber = Numbers[i];
                }
                if (Numbers[i] >= biggest)
                {
                    biggestNumber = Numbers[i];
                }
            }

            for (int i = smallestNumber; i <= biggestNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}