using System;

namespace StringManipulation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any word of your choice: ");
            string userInput = Console.ReadLine();
            string res = ReverseString(userInput);
            IsPalindrome(userInput, res);
        }
        public static string ReverseString(string userInput)
        {
            char[] result = new char[userInput.Length];
            
            for (int i = 0, j = userInput.Length - 1; i < userInput.Length; i++, j--)
            {
                result[i] = userInput[j];
            }
            return new string(result);
        }
        public static void IsPalindrome(string userInput, string reversedInput)
        {
            if (userInput == reversedInput)
            {
                Console.WriteLine("The word you input is palindrome");
            }
            else
            {
                Console.WriteLine("The word you input is not palindrome");
            }

        }
    }
}
