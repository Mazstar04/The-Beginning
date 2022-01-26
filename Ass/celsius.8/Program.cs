using System;

namespace celsius._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to convert is ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Kelvin(celsius);
            Farhenhiet(celsius);

           
        }
         public static double Kelvin(double celsius)
         {
             double kelvin = celsius + 273;
             Console.WriteLine($"The number you entered when converted to Kelvin will give {kelvin}");
             return kelvin;
         }
         public static double Farhenhiet(double celsius)
         {
             double farhenheit = (celsius*9)/5+32;
             Console.WriteLine($"The number you entered when converted to Farhenheit will give {farhenheit}");
             return farhenheit;
         }
    }
}
