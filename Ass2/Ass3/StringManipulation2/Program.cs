using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter any word: ");
           string userInput = Console.ReadLine();

            while (userInput.Length > 0)
            {
                Console.Write(userInput[0] + " : ");
                int count = 0;
                for (int j = 0; j < userInput.Length; j++)
                {
                    if (userInput[0] == userInput[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                userInput = userInput.Replace(userInput[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
