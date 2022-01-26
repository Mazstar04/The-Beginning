using System;

namespace CreateNewString._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any word: ");
            string word = Console.ReadLine();
            Console.WriteLine(print(word));
        }
        public static bool print(string word)
        {
            var ctr = 0;
            for(var i = 0; i< word.Length-1; i++ )
            {
                if (word[i].Equals('w')) ctr++;
                if (word.Substring(i, 2).Equals("ww") && ctr >2)
                return true;
            }
            return false;
        }
    }
}
