using System;

namespace SomOfIntegars._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First Number: ");
            int fnum = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Your Second Number: ");
            int snum = Convert.ToInt32(Console.ReadLine());
            int total = fnum + snum;
            Print(fnum, snum, total);
        }
        public static void Print(int fnum, int snum, int total)
        {
            if (fnum == snum)
            {
                Console.WriteLine(total*3);
            }
            else
            {
                Console.WriteLine(total);
            }

        }
    }
}
