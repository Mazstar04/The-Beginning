using System;

namespace IfAndElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colours = {"red", "orange", "green", "blue", "yellow"};
            string[] colourBreakerGuesses = new string[4];
            string[] colourMakerGuesses = new string[4];

            int count = 0;
            while (count < colours.Length)
            {
                Console.WriteLine($"Enter {count} for {colours[count]}");
                count++;
            }

            int entries = 0;
            while (entries < 4)
            {
                Random random = new Random();
                int index = random.Next(0, colours.Length);
                string colour = colours[index];
                colourMakerGuesses.SetValue(colour, entries);
                entries++;
            }

            bool win = false;
            int play = 0;
            while (!win && play <= 12)
            {
                for (int userInput = 0; userInput < 4; userInput++)
                {
                    Console.Write($"Enter your colour at position {userInput}: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    string user_colour = colours[choice];
                    colourBreakerGuesses.SetValue(user_colour, userInput);
                }
                break;
            }

            
        }
        public static bool IsInTheSameOrder(string [] colourBreakerGuesses, string [] colourMakerGuesses)
        {
            for (int i = 0; i < colourBreakerGuesses.Length; i++)
            {
                if (colourBreakerGuesses[i] != colourMakerGuesses[i])
                {
                    return false;
                }
            }
            return true;
        }


    }
}
