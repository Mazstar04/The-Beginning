using System;

namespace StringManipilation
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {

                userInput = userInput.Replace(userInput[i], Vowel(userInput[i]));

            }

            Console.WriteLine(userInput);
        }
        public static char Vowel(char v)
        {
            if(v == 'a')
            {
                return 'e'; 
            }
            else if (v == 'e')
            {
                return 'i';
            }
            else if (v == 'i')
            {
                return 'o';
            }
            else if (v == 'o')
            {
                return 'u';
            }
            else if (v == 'u')
            {
                return 'a';
            }
            else
            {
                return v;
            }
        }
        
    }
}
