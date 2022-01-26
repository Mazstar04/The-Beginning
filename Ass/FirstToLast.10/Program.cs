using System;

namespace FirstToLast._10
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapFirstAndLastLetter();
        }
        public static void SwapFirstAndLastLetter()
        {
            Console.Write("Enter an word of your choice: ");
            string word = Console.ReadLine();
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            char exchange = firstLetter;
            firstLetter = lastLetter;
            lastLetter = exchange;
            string otherLetters = word.Substring(1, word.Length - 2);
            Console.WriteLine($"{firstLetter}{otherLetters}{lastLetter}");
        }
    }
}
