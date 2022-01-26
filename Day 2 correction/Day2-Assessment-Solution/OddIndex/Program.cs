using System;

namespace OddIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array (Seperate items by comma ','): ");
            string [] numberArray = Console.ReadLine().Split(',');
            // int[] numberArray = { 2, 4, 7, 1, 4, 7, 8, 6, 2, 5, 2, 9, 3 };

            int sum = 0;

            // Method 1
            for (int i = 0; i < numberArray.Length; i++) // looping through the index of the array 1 by 1
            {
                if (i % 2 != 0) //check if the current index is odd
                {
                    sum += int.Parse(numberArray[i]); 
                    //convert the item at the current odd index to string and adding it to sum
                }
            }

            // method 2
            int index = 1; // using this as the loop initial 

            while (index < numberArray.Length) // checking if the index varable is still less than the length of the array
            {
                sum += int.Parse(numberArray[index]);
               //convert the item at the current odd index to string and adding it to sum

                index += 2;
                //increasing the index variable by 2 to make sure only odd values are produced
            }

            Console.WriteLine($"The sum of the element of the array at odd index is:  {sum}");
            //displaying the output to the user 

        }
    }
}
