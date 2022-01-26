using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Sqrt sqrt = new Sqrt(); //Creating an instance of the Sqrt class

            Console.Write("Enter the number you want to square root: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            //Getting user input and converting it to double

            if (userNumber < 0)
            {
                Console.WriteLine("Number must be >= 0");
                return;
                //checking if its a positive number, displaying appropriate methos if its not and breaking out of the method
            }
            if (userNumber == 0 || userNumber == 1)
            {
                Console.WriteLine($"Square root of {userNumber} is {userNumber}");
                return;
                //The square root of 1 and 0 is themself
            }
            else
            {
                double squareRoot = sqrt.Squareroot(userNumber); 
                //passing the user input to the squareroot method of the Sqrt class to compute the square root of the number
                
                Console.WriteLine($"The approximate square root of {userNumber} is {squareRoot}");
                //Displaying th square root of the number to the user
            }


        }
    }
}
