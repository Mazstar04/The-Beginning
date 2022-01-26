using System;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Mazeedah is cool";
            string[] words = sentence.Split(" ");
            string word = "";
            int check = 0;
            foreach (String world in words)
            {
                if (world.Length > check)
                {
                    word = world;
                    check = world.Length;


                }
            }
            Console.WriteLine(word);
        }
    }
}
