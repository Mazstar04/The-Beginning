using System;

namespace Reverse._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any sentence of your choice: ");
            string sentence = Console.ReadLine();
            int lenghtOfSentence = sentence.Length;
            string result = "";
            
            for(int i= lenghtOfSentence-1; i>=0 ; i--)
            {
                result += sentence[i];
            }
            Console.WriteLine(result);
            
        }
    }
}
