using System;

namespace FirstAndLastEqual._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = {17, 37, 41, 2, 3, 17};
            if(array[0] == array[array.Length-1])
            {
                Console.WriteLine("The first and last element of the array are equal");
            }
            else 
            {
                Console.WriteLine("The first and last element of the array are not equal");
            }
        }
    }
}
