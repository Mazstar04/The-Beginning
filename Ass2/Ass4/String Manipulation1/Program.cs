using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any word of your choice: ");
            string userInput = Console.ReadLine();

            userInput = userInput.ToLower();
            char [] chars = userInput.ToCharArray();
            char exchange ;
            for(int i = 1; i<chars.Length; i++)
            {
                for(int j = 0; j<chars.Length -1 ; j++)
                {
                    if(chars[j] > chars[j + 1])
                    {
                        exchange = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = exchange;
                    }
                }
            }
            Console.WriteLine(chars);
        } 
    }
}
