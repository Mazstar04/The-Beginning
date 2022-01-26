using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOperation stringOperation = new StringOperation(); //creating an instance of the StringOperation Class

            Console.Write("Enter any digits: ");
            string userInput = Console.ReadLine(); // Collecting the user input

            string reversedString = stringOperation.Reverse(userInput);
            // Passing the input to the reverse method of the stringoperation class to reverse it

            bool isPalindrome = stringOperation.IsPalindrome(userInput, reversedString);
            //Passing the input and the revered input to the IsPalindrome method of the stringoperation class to determine if it is a palindrome or not


            if (isPalindrome)
            {

                Console.WriteLine("The entered digit is a palindrome");
            }
            else
            {
                Console.WriteLine("The entered digit is not a palindrome");
            }
            //Displaying the output to the user based of if the input is a palindrome or not

        }


        
    }
}
