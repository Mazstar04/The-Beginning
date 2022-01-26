using System;

namespace IfAndElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string lotteryNumber = "456";

            Console.Write("Enter a three-digit number: ");

            string userInput = Console.ReadLine();

            MatchExactly(userInput, lotteryNumber);

            
        }
        public static void MatchExactly(string userInput, string lotteryNumber)
        {
            bool matchIAnyOrder = AllNumbersMatch(userInput, lotteryNumber);

            if (userInput[0] == lotteryNumber[0]
                        && userInput[1] == lotteryNumber[1]
                        && userInput[2] == lotteryNumber[2])
            {
                Console.WriteLine("All your numbers match exactly!!, You win $10,000");
            }
            else if (userInput[0] == lotteryNumber[0]
                       || userInput[1] == lotteryNumber[1]
                       || userInput[2] == lotteryNumber[2])
            {
                Console.WriteLine("One of your number matched the lottery number, You win $1,000");

            }
            else if(matchIAnyOrder)
            {
                Console.WriteLine("All your numbers match, You win $3,000");
            }
            else
            {
                Console.WriteLine("You lost this round, Try again next time");
            }

        }

        public static bool AllNumbersMatch(string userInput, string lotteryNumber)
        {
            bool result = false;

            for (int i = 0; i < 3; i++)
            {
                if (userInput[i] == lotteryNumber[i])
                {
                    result = true;
                }
            }

            return result;
        }

    }
}

