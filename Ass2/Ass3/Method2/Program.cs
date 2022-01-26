using System;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int firstRandom = random.Next(1, 7);

            Random random2 = new Random();
            int secondRandom = random.Next(1,7);
            Console.WriteLine("Press any key to roll dice: ");
            Console.ReadKey();
            Console.WriteLine($"The number on the first dice is {firstRandom}, while that of the second dice is {secondRandom}");
            int sumOfTwoDice =firstRandom + secondRandom;
            CheckSumOfTwoDice(sumOfTwoDice);
        }
        public static void CheckSumOfTwoDice(int sumOfTwoDice)
        {
            if (sumOfTwoDice == 2|| sumOfTwoDice == 3|| sumOfTwoDice==12)
            {
                Console.WriteLine($"The addition of your values is {sumOfTwoDice}, Sorry! you lost this round");
            }
            else if(sumOfTwoDice == 7 || sumOfTwoDice == 11)
            {
                Console.WriteLine($"The addition of your values is {sumOfTwoDice}, Wow!, you won this round");
            }
            else
            {
                Console.WriteLine($"The addition of your values is {sumOfTwoDice}, You have established a point. Countinue to roll the dice until either a 7 or the same point value is rolled. if seven is rolled you lose, otherwise you win.");
            }
        }
    }
}
