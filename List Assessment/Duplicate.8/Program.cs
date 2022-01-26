using System;
using System.Collections.Generic;

namespace Duplicate._9
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> Numbers = new List<int> ();
            Console.Write("Enter the numbers and seperate them with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(' ');
            for (int i=0; i<userInput.Length; i++)
            {
                int userNum = Convert.ToInt32(userInput[i]);
            }
        }
    }
}
