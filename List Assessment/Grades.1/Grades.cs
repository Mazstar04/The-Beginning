using System;
using System.Collections.Generic;

namespace Grades
{
    public class Grades
    {
        public static void Scores()
        {
            List<int> Scores = new List<int>();
            
            Console.Write("Enter the scores you want to grade and Seperate them with space: ");
            string userInput = Console.ReadLine();
            string[] scoresInputed = userInput.Split(' ');

            for (int i = 0; i < scoresInputed.Length; i++)
            {
                int score = Convert.ToInt32(scoresInputed[i]);
                Scores.Add(score);
            }

            foreach (var score in Scores)
            {
                if (score <= 30 && score > 0)
                {
                    Console.WriteLine($"Score: {score}, Grade: F");
                }
                else if (score <= 40 && score > 0)
                {
                    Console.WriteLine($"Score: {score}, Grade: D");
                }
                else if (score <= 60 && score > 0)
                {
                    Console.WriteLine($"Score: {score}, Grade: C");
                }
                else if (score <= 70 && score > 0)
                {
                    Console.WriteLine($"Score: {score}, Grade: B");
                }
                else if (score <= 100 && score > 0)
                {
                    Console.WriteLine($"Score: {score}, Grade: A");
                }
                else
                {
                    Console.WriteLine($"{score} is an Invalid Score!!");
                }
            }
        }
    }
}