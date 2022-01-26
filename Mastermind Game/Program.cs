using System;
using System.Collections.Generic;

namespace Mastermind_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "yellow", "green", "red", "blue", "orange", "purple" };
            string[] computersGuess = PickRandomColours(colors);

        }
        public static string[] PickRandomColours(string[] colors)
        {
            Random random = new Random();

            List<string> randomColors = new List<string>();
            int randomIndex = random.Next(0, colors.Length);
            string randomIndexColors = colors[randomIndex];


             if (randomColors.Count < 4)
            {
                    if (randomColors.IndexOf(randomIndexColors) == -1)
                    {
                        randomColors.Add(randomIndexColors);
                    }
            
            }

            foreach (var item in randomColors)
            {
                Console.WriteLine(item);
            }

            return randomColors.ToArray();

        }
    }
}
