using System;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i = 1; i < 13; i++)
            // {
            //      Console.WriteLine($"My {i} Times Table");
            //     for(int j = 0; j < 13; j++)
            //     {
            //         Console.WriteLine($"{i} x {j} = {j*i}");
            //     }
                
            // }

            // Console.Write("Enter Word : ");
            // string userInput = Console.ReadLine().ToUpper();
            // string reverse = "";
            // for(int i= userInput.Length-1; i>=0; i--)
            // {
            //     reverse+= userInput[i];
                
            // }
            // Console.WriteLine(reverse);
            
            Console.Write("Enter Number : ");
            string userInput = Console.ReadLine().Trim();
            int sum = 0;
            for(int i =0; i< userInput.Length; i ++)
            {
                sum += Convert.ToInt32(userInput[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
