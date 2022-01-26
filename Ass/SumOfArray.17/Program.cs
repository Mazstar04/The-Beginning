using System;

namespace SumOfArray._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 54, 23, 31, 45 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);

        }
    }
}
