using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
                int odd = 0;

                // Loop to find odd sum
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        odd += array[i];
                    }
                }

                Console.WriteLine($"Sum of of numbers @ odd index position is {odd}");
        }
    }
}
