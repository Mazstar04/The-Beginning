using System;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Score: ");

            int score = Convert.ToInt32(Console.ReadLine());

            if (score < 40)
            {
                Console.WriteLine("Your Grade is 'F'");
                Console.WriteLine("You failed this Corse, Advise to Withdraw");
            }
            else if (score < 50)
             {
                Console.WriteLine("Your Grade is 'D'");
                Console.WriteLine("You Passed this Corse, try harder next time");
            }
             else if (score < 60)
             {
                Console.WriteLine("Your Grade is 'C'");
                Console.WriteLine("Good!, You can do Better");
            }
             else if (score < 70)
             {
                Console.WriteLine("Your Grade is 'B'");
                Console.WriteLine("Very Good!!");
            }
             else if (score < 100)
             {
                Console.WriteLine("Your Grade is 'A'");
                Console.WriteLine("Excellent!!!, You crushed it!");
            }
             else 
             {
                Console.WriteLine("Invalid Score!!!");
            }
        }
    }
}
