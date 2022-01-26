using System;
using System.Collections.Generic;

namespace Reverse_Order
{
    public class Reverse
    {
        public static void ReverseNumbers()
        {
            List<string> Numbers = new List<string>();

            Console.Write("Enter the Numbers you want to be Reversed and Seperate them with space: ");
            string userInput = Console.ReadLine();
            string[] numbersInputed = userInput.Split(' ');
            
            for (int i = numbersInputed.Length-1; i >= 0; i--)
            {
                string num = numbersInputed[i];
                Numbers.Add(numbersInputed[i]);             
            }
           
           foreach(var number in Numbers)
           {
               Console.WriteLine(number);
           }
        }
    }
}