using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the breadth of the rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            //Collecting the length and breadth of the rectangle from the user


            Area area = new Area(length, breadth); // Creating an instance of the area class and passing the entered inputs through the constructor 

            double rectangleArea = area.ReturnArea(); //invoking the ReturnArea method of the area class to get the area of the reactangle for this instance of the class

            Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
            //Displaying the result to the user

        }
    }
}
