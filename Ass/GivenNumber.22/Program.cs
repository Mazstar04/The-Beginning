using System;

namespace GivenNumber._22
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 3, 5, 6, 7, 87 };
            for (int i = 0; i < array.Length; i++)
            {
                if (givenNum(array[i]))
                {
                    Console.WriteLine("Seven is present in the array of numbers");
                    break;
                }
                else
                {
                    if(array.Length-1 == i)
                    Console.WriteLine("Seven is absent in the array of numbers");

                }

            }
        }

        public static Boolean givenNum(int num)
        {
            if (num == 7)
            {
                return true;
            }
            return false;
        }

    }
}




