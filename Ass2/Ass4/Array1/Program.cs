using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] list = {1, 2, 3, 4, 5, 6};
            for(int i = 1; i< list.Length; i++)
            {
                list[i] = list[i-1];
            }

            for(int i= 0; i< list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            // Output: 1
            // 1
            // 1
            // 1
            // 1
            // 1
        }
    }
}
