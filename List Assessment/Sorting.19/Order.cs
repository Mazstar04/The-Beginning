using System;
using System.Collections.Generic;

namespace Sorting
{
    public class Order
    {
        public static void AscendingDescending()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Input ten numbers and seperate them wuth space: ");
            string userInput = Console.ReadLine();
            string[] userOption = userInput.Split(' ');

            for (int i = 0; i < userOption.Length; i++)
            {
                int userNumbers = Convert.ToInt32(userOption[i]);
                Numbers.Add(userNumbers);
            }


            if (Numbers[0] > Numbers[1] && Numbers[1] < Numbers[2] || Numbers[0] < Numbers[1] && Numbers[1] > Numbers[2])
            {
                Console.WriteLine("The List is arraged in no particular Order");
            }
            else if (Numbers[0] > Numbers[1])
            {
                Console.WriteLine("The List is arraged in descending Order");
            }
            else if (Numbers[0] < Numbers[1])
            {
                Console.WriteLine("The List is arraged in ascending Order");
            }
        }
    }
}