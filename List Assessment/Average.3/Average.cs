using System;
using System.Collections.Generic;

namespace Average
{
    public class Average
    {
        public static void NumberOfAverage()
        {
            Console.Write("Enter the Scores and Seperate them with space: ");
            string userInput = Console.ReadLine();
            string[] numbersInputed = userInput.Split(' ');
            int addUserInput = 0;
            int noOfUserInput = 0;
            int greaterThanAverage = 0;
            int lessThanAverage = 0;
            int equalToAverage = 0;

            for(int i =0; i < numbersInputed.Length; i++)
            {
                int userNumbers = Convert.ToInt32(numbersInputed[i]);
                addUserInput += userNumbers;
                noOfUserInput++;
            }
            int average = addUserInput/noOfUserInput;

            for(int i =0; i < numbersInputed.Length; i++)
            {
                int userNumbers = Convert.ToInt32(numbersInputed[i]);

                if(userNumbers > average)
                {
                    greaterThanAverage++;
                }
                else if (userNumbers < average)
                {
                    lessThanAverage++;
                }
                else if(userNumbers == average)
                {
                    equalToAverage++;
                }
            }

            Console.WriteLine($"Number of scores above or equal average = {greaterThanAverage+equalToAverage}");
            Console.WriteLine($"Number of scores below average = {lessThanAverage}");
        }
    }
}