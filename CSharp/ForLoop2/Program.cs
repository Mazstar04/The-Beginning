using System;

namespace ForLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            int i = 1;
            while (i <= 100)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    
                    if (i % 4 == 0)
                    {
                         i++;
                        break; 
                    }

                    Console.WriteLine(i);
                }


                i++;
            }
        }
    }
}
