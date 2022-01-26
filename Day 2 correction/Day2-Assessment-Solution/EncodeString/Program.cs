using System;

namespace EncodeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Encode encode = new Encode(); 
            //creating an instance of the encode class
            
            Console.Write("Input any word or sentence of even length: ");
            string inputWord = Console.ReadLine(); 
            // Collect User's Input

            if (inputWord.Length == 0 || inputWord.Length % 2 != 0) 
            //checking to make sure the user input is not empty and of even length
            {
                Console.WriteLine("The word is not of even length");
            }
            else
            {
                string firstPart = inputWord.Substring(0, inputWord.Length / 2); 
                // getting the first half of the string
                
                string secondPart = inputWord.Substring(inputWord.Length / 2); 
                // getting the second half of the string

                string encoded = encode.EncodeString(firstPart, secondPart); 
                //passing both half of the string to the Encode method to get it encoded

                Console.WriteLine(encoded); 
                //displaying the encoded string to the user
            }
        }


        
    }
}
