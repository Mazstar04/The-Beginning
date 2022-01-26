using System;
using System.Collections.Generic;

namespace Occurence
{
    public class Occurence
    {
        public static void NoOfOccurence()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Input the numbers and seperate them with space: ");
            string userInput = Console.ReadLine();
            string[] userOption = userInput.Split(' ');
            int[] occurence = new int[10];

            for (int i = 0; i < userOption.Length; i++)
            {
                int userNumbers = Convert.ToInt32(userOption[i]);
                Numbers.Add(userNumbers);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < Numbers.Count; x++)
                {
                    if (Numbers[x] == i)
                    {
                        occurence[i]++;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} occured {occurence[i]} times");
            }
        }
    }
}