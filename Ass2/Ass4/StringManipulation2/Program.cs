using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first word: ");
            string firstUserInput = Console.ReadLine();
            firstUserInput = firstUserInput.ToLower();

            Console.Write("Enter your second word: ");
            string secondUserInput = Console.ReadLine();
            secondUserInput = secondUserInput.ToLower();
            string lowestString = firstUserInput.Length < secondUserInput.Length ? firstUserInput : secondUserInput;

                if(firstUserInput.IndexOf(secondUserInput) != -1)
                {
                    Console.WriteLine("The second input is a substring of the first");
                }
                else
                {
                    Console.WriteLine("The second input is not a substring of the first");
                }
            
           

        }
    }
}
