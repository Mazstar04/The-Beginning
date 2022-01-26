using System;

namespace AscendingArray._21
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the Length of the array: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            InputLength(arrayLength, array);
            Ascending(arrayLength, array);
            Print(arrayLength, array);
        }
        public static void InputLength(int arrayLength, int[] array)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Write the number you want @ index {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Ascending(int arrayLength, int[] array)
        {
            int small = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength- i-1; j++)
                {
                    if (array[j+1] < array[j])
                    {
                        small = array[j];
                        array[j] = array[j+1];
                        array[j+1] = small;  
                    }    
                }
            }
        }
        public static void Print(int arrayLength, int[] array)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
