using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of your rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the breadth of your rectangle: ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            Area area = new Area();
            Area.ReturnArea(length, breadth);
        }
    }
    class Area
    {
        public static int ReturnArea(int length, int breadth)
        {
            int area = length * breadth;
            Console.WriteLine($"The area of the rectangle is {area}");
            return area;
        }
    }
}
