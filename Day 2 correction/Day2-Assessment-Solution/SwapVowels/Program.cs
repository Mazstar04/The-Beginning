using System;

namespace SwapVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Swap swap = new Swap();

            Console.Write("Enter any word or sentence to encode: ");
            string userInput = Console.ReadLine();
            
            char [] userInputArray = userInput.ToCharArray();

            for (int i = 0; i < userInputArray.Length; i++)
            { 
                userInputArray[i] = swap.SwapVowel( userInputArray[i]);
            }

            Console.WriteLine($"The Encoded sentence is: {new string(userInputArray)}");
        }
    }
}
