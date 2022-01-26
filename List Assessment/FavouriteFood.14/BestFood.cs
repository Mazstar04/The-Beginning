using System;
using System.Collections.Generic;

namespace FavouriteFood
{
    public class BestFood
    {
        public static void FavouriteFood()
        {
            List<string> FavouriteFood = new List<string>();
            Console.Write("Enter three of your favourite foods and seperate them with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(' ');

            for (int i = 0; i < userInput.Length; i++)
            {
                FavouriteFood.Add(userInput[i]);
            }

            foreach (var item in FavouriteFood)
            {
                Console.WriteLine($"I like {item} very much");
            }
        }
    }
}