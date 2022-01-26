using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first word: ");
            string firstUserInput = Console.ReadLine();
            firstUserInput = firstUserInput.ToLower();

            Console.Write("Enter your second word: ");
            string secondUserInput = Console.ReadLine();
            secondUserInput = secondUserInput.ToLower();

            int breakIndex = 0;

            string lowestString = firstUserInput.Length < secondUserInput.Length ? firstUserInput : secondUserInput;

            for (int i = 0; i < lowestString.Length; i++)
            {
                if (firstUserInput[i] != secondUserInput[i])
                {
                    breakIndex += i;
                    break;
                }
            }

            Console.WriteLine(secondUserInput.Substring(0, breakIndex));
        }
    }
}
