using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int firstArray = 3;
            int secondArray = 3;
            int sum = 0;
            for (int i = 0; i < firstArray; i++)
            {
                for (int j = 0; j < secondArray; j++)
                {
                    sum += array[i, j];
                }
                 Console.WriteLine($"Sum of row: {sum}");
            }
        
        }
    }
}
