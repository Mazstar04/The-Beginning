using System;

namespace OddArray._19
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 3, 5, 6, 87 };
            for (int i = 0; i < array.Length; i++)
            {
                if(isOdd(array[i]))
                {
                    Console.WriteLine("Odd number is present");
                    break;
                }else{
                    Console.WriteLine("Odd number is not present");
                    
                }

            }
            

        }

        public static Boolean isOdd(int num)
        {
            if (num % 2 != 0){
                return true;
            }
            return false;
        }
    }
}
