using System;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(); //creating an instance of the random class
            int randomDigit = random.Next(100, 1000); //generating a random 3 digits


            Console.Write("Enter three numbers: ");
            string userInput = Console.ReadLine(); // getting user input

            if (userInput.Length != 3) //validating to make sure user entered 3 numbers 
            {
                Console.WriteLine("Enter three digits");
            }
            else
            {
                int userDigit = 0;

                bool isNumbers = int.TryParse(userInput, out userDigit); 
                //parsing user input into string and validating to make sure its a number only.  

                if (!isNumbers) // checking if it is a valid number
                {
                    Console.WriteLine("Enter Numbers only");
                }
                else
                {
                    if (userDigit == randomDigit) 
                    //checking if the user digit is the same as the gnerated random digits
                    {
                        Console.WriteLine("You guessed the digits correctly and you have won $10,000!!!"); //displaying the message to the user if the number is guessed correctly
                    }
                    else
                    {

                        string randomDigitString = randomDigit.ToString();
                        string userDigitString = userDigit.ToString();

                        int correctDigit = 0;

                        for (var i = 0; i < 3; i++) // looping through the three digits
                        {
                            if (randomDigitString.IndexOf(userDigitString[i]) != -1) correctDigit++; //getting the count of correct digits
                        }

                        if (correctDigit > 0) Console.WriteLine($"You got {correctDigit} numbers correctly. You have won ${correctDigit * 1000}!!!"); 
                        // displaying the user prize based on the number of correct digits: $1000 per correct digit
                        
                        else Console.WriteLine("You guessed wrong!!!"); 
                        // displaying the message to the user if none of the digit is correct

                    }
                }
            }


        }
    }
}
