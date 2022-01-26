using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            int [] students = new int[x];
            x = 60;
            Console.WriteLine("x is " + x);
            Console.WriteLine("The number of student is " + students.Length);
        }

        // The Output is: x is 60
        // The number of student is 30
    }
}
