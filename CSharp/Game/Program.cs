

using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int luckyNumber = random.Next(1, 6);

// "1"

            Console.Write("Enter any number btw 1 and 5: ");

            string userinput = Console.ReadLine();

            int chosenNumber =  Convert.ToInt32(userinput);

            // int chosenNumber = Convert.ToInt32(Console.ReadLine());

            if (chosenNumber > 5 || chosenNumber < 1)
            {
                Console.WriteLine("Invalid Number!!");

            }
            else
            {

                if (chosenNumber == luckyNumber)
                {
                    Console.WriteLine("Hurray!!, You won this round");
                }
                else
                {
                    string gl;

                    int difference = chosenNumber - luckyNumber;
                    gl = difference > 0 ? "greater" : "less";

                    Console.WriteLine("Ouch!, You Lose");
                    Console.WriteLine($"The number you chose is {Math.Abs(difference)} {gl} than the lucky number");
                    //Math.abs
                }

                Console.WriteLine("The Lucky Number was " + luckyNumber);
                Console.WriteLine("You choose " + chosenNumber);
            }


        }
    }
}
