using System;

namespace CubesBetween1And100
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i=0; i<=100; i++)
           {
               Console.WriteLine($"The cube of {i} is {i*i*i}");
           }
        }
    }
}
