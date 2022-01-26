using System;
using System.Collections.Generic;

namespace SearchForNumber
{
    public class Search
    {
        public static void searchElement()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Enter the numbers and seperate them with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(' ');
            Console.Write("Enter number you want to search for: ");
            int userSearch = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            if (Numbers.Contains(userSearch))
            {
                Console.WriteLine($"{userSearch} is present in the List of Numbers");
            }
            else
            {
                Console.WriteLine($"{userSearch} is not present in the List of Numbers");
            }
        }
    }
}