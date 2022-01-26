using System;
using System.Collections.Generic;

namespace OddEvenPrime
{
    public class Classification
    {
        public static void OddEvenPrime()
        {
            List<int> OddNumbers = new List<int>();
            List<int> EvenNumbers = new List<int>();
            List<int> PrimeNumbers = new List<int>();
            Console.Write("Enter the numbers and seperate them with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(' ');
            // int me = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                int userNum = Convert.ToInt32(userInput[i]);
                if (userNum % 2 == 1)
                {
                    OddNumbers.Add(userNum);
                }
                else 
                {
                    EvenNumbers.Add(userNum);
                }
                
                // if()
                // {
                //     int count = 0, n = 0, j = 1;
                //     while (n < 10000000)
                //     {
                //         j = 1;
                //         count = 0;
                //         while (j <= i)
                //         {
                //             if (i % j == 0)
                //                 count++;
                //             j++;
                //         }
                //         if (count == 2)
                //         {
                //             PrimeNumbers.Add(i);
                //             n++;
                //         }
                //     }
                // }
            }

            Console.WriteLine("List Of Odd Numbers: ");
            foreach (var item in OddNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List Of Even Numbers: ");
            foreach (var item in EvenNumbers)
            {
                Console.WriteLine(item);
            }

            // Console.WriteLine("List Of Prime Numbers: ");
            // foreach (var item in PrimeNumbers)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}