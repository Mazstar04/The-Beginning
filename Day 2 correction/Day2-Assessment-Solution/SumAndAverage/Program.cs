using System;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[][] array = { new int[] { 2, 4, 6, 3, 4, 7 }, new int[] { 5, 2, 9, 4, 6, 0 } };
            //creating a new 2D array

            Console.WriteLine("Seperate each item of an array by a comma ','");

            Console.Write("Enter the first array: ");
            string[] firstArray = Console.ReadLine().Split(',');

            Console.Write("Enter the second array with the same length as the first: ");
            string[] secondArray = Console.ReadLine().Split(',');
            //Collecting user inputs and converting them to array of strings


            if (firstArray.Length != secondArray.Length)
            //making sure the arrays are if equal length
            {
                Console.WriteLine("The arrays are not of the same length");
                return;
            }

            int[] firstArrayInt = new int[firstArray.Length];
            int[] secondArrayInt = new int[secondArray.Length];
            //creating an integer array for the user inputs with their sizes


            try
            {
                //the try and catch block is used here to handle an exception. The user entering anything apart from digits is handled here

                // You can read more on try-catch here: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch

                for (int i = 0; i < firstArray.Length; i++)
                {
                    firstArrayInt[i] = int.Parse(firstArray[i]);
                    secondArrayInt[i] = int.Parse(secondArray[i]);
                    //parsing each element of the string array and storing them in the int array
                }
            }
            catch (FormatException)
            {
                //this catch block handles the error format exception thrown in the catch block
                Console.WriteLine("Please enter digits only");
                return;
                //this return statement helps to break out of the program safely 
            }

            int[][] array = { firstArrayInt, secondArrayInt };
            //Creates a 2D array of the firstuser input and the second user input

            int numberOfValues = 0;

            int totalSum = 0;
            //intializing some variables 

            for (int i = 0; i < array[0].Length; i++)
            //lopping through the index of the first array

            {
                int sumOfCorrespondingElement = array[0][i] + array[1][i];
                //sums the corresponding element in both array

                if (sumOfCorrespondingElement % 2 != 0)
                // checks if the sum is an odd number
                {
                    totalSum += sumOfCorrespondingElement;
                    //adds the sum of the corresponding elements to the total sum if it is odd

                    numberOfValues++; //increases number of  values by 1
                }
            }

            Console.WriteLine($"The sum of the values added to odd number is : {totalSum}");
            // displaying the sum to the user
            Console.WriteLine($"The average of the values added to odd number is : {totalSum / numberOfValues}");
            //dividing the sum by the number of values and displaying the quotient to the user as the average


        }
    }
}
