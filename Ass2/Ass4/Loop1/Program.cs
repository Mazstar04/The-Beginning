using System;

namespace Loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any word of your choice: ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            int vowel =0;
            int consonant = 0;

            for(int i= 0; i < userInput.Length; i++)
            {
                if(userInput[i]=='a'||userInput[i]=='e'||userInput[i]=='i'||userInput[i]=='o'||userInput[i]=='u')
                {
                    vowel++;
                }
                else
                {
                    consonant++;
                }
            }
            Console.WriteLine($"The number of vowels in the word you inputed is {vowel}");
            Console.WriteLine($"The number of vowels in the word you inputed is {consonant}");
        }   
    }
}
