using System;

namespace MultiplyArray._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = {16, 4, 12, 54, 10};
            int[] secondArray = {3, 38, 6, 14, 2};
            Multiply(firstArray, secondArray);
        }
        public static void Multiply(int[] firstArray, int[] secondArray)
        {
            for(int i = 0; i<firstArray.Length; i++)
            {
                Console.WriteLine(firstArray[i]*secondArray[i]);
            }
            
        }
    }
}
