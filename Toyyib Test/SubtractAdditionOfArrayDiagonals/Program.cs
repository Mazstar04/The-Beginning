using System;

namespace SubtractAdditionOfArrayDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a = {
            {10, 20, 30, 6, 4},
            {40, 40, 60, 8, 7},
            {60, 80, 90, 4, 3},
            {6, 8, 9, 4, 3},
            {9, 4, 6, 8, 7}};

            if (a.GetLength(0) != a.GetLength(1))
            {
                Console.WriteLine("The Matrix Provided is not a Square Matrix!!");
            }
            else
            {
                int firstDiagonalSum = 0;
                int secondDiagonalSum = 0;
                int j = a.GetLength(0) - 1;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    firstDiagonalSum += a[i, i];
                    secondDiagonalSum += a[i, j];
                    j--;
                }


                if (firstDiagonalSum > secondDiagonalSum)
                {
                    Console.WriteLine($"The Difference of the matrix Diagonals = {firstDiagonalSum - secondDiagonalSum}");
                }
                else
                {

                    Console.WriteLine($"The Difference of the matrix Diagonals = {secondDiagonalSum - firstDiagonalSum}");

                }
            }

        }

        //public static int NoOfRows(int[,] array)
        //{
        //    int noOfRows = 0;
        //    foreach (var item in array)
        //    {
        //        if (array[0, noOfRows] != null)
        //        {
        //            noOfRows += 1;
        //        }
        //    }
        //    return noOfRows;
        //}

        //public static int Test(int[,] matrix)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            if (i == 0)
        //            {
        //                sum += matrix[i, j];
        //            }
        //            else
        //            {
        //                bool isHaunted = false;
        //                for (int z = i; z <= 0; z--)
        //                {
        //                    if (matrix[z, j] == 0)
        //                    {
        //                        isHaunted = true;
        //                        break;
        //                    }
        //                }

        //                if (isHaunted == false)
        //                {
        //                    sum += matrix[i, j];
        //                }
        //            }
        //        }
        //    }
        //    return sum;
        //}
    }
}


