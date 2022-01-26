using System;

namespace Palindrome
{
    public class StringOperation
    {
        public string Reverse(string digits)
        {
            char[] digitsArray = digits.ToCharArray();
            //Converting the input to an array of character

            Array.Reverse(digitsArray); 
            //using the array reverse method to reverse the array

            return new string(digitsArray); 
            // joining the reversed array to form a new string and returring it 
        }

        public bool IsPalindrome(string originalString, string reversedString)
        {
            return originalString.Equals(reversedString);
            // returing true or false based on the result of checking if the reversed string is the same as the original user input
        }
    }
}