using System;
using System.Collections.Generic;

namespace SwapFirstAndLast
{
    public class Swaping
    {
        public static void SwapFirstAndLast()
        {
            List<int> Numbers = new List<int> ();
            Console.Write("Enter the numbers and seperate them wuth space: ");
            string userInput = Console.ReadLine();
            string [] userOption = userInput.Split(' ');

            for(int i =0; i<userOption.Length; i++)
            {
                int userNumbers = Convert.ToInt32(userOption[i]);
                Numbers.Add(userNumbers);
            }
            int swap = Numbers[0];
            Numbers[0] = Numbers[Numbers.Count - 1];
            Numbers[Numbers.Count - 1] = swap;

            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}