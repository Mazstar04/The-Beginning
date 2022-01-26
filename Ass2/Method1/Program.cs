using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 3-digit number: ");
            string userInput = Console.ReadLine();

            Console.WriteLine($"{userInput[2]}{userInput[1]}{userInput[0]}");
            Console.WriteLine(Palindrome(userInput));
        }
        public static bool Palindrome(string userInput)
        {
            if (userInput[0] == userInput[2])
            {
                return true;
            }
            return false;
        }
    }
}
