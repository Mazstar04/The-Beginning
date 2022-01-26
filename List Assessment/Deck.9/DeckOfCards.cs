using System;
using System.Collections.Generic;

namespace Deck
{
    public class DeckOfCards
    {
        public static void SummationOfCards()
        {
            List<string> DeckOfCards = new List<string> { "Ace", "King", "Queen", "Jack" };

            int Add = 0;

            for (int i = 1; i < 5; i++)
            {
                Random random = new Random();
                int index = random.Next(0, 3);
                Console.Write("Press any key to pick a card");
                Console.ReadKey();

                if (DeckOfCards[index] == "Ace")
                {
                    Console.WriteLine($"{i}. The card you choose is Ace and is equal to 1");
                    Add++;
                }
                else if (DeckOfCards[index] == "King")
                {
                    Console.WriteLine($"{i}. The card you choose is King and is equal to 13");
                    Add += 13;
                }
                else if (DeckOfCards[index] == "Queen")
                {
                    Console.WriteLine($"{i}. The card you choose is Queen and is equal to 12");
                    Add += 12;
                }
                else if (DeckOfCards[index] == "Jack")
                {
                    Console.WriteLine($"{i}. The card you choose is Jack and is equal to 11");
                    Add += 11;
                }
                else
                {
                    Console.WriteLine("Error!!");
                }
            }
            Console.WriteLine($"The sum of all the cards = {Add}");
        }
    }
}