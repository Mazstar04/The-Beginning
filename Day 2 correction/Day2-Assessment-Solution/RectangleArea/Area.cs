namespace RectangleArea
{
    public class Area //Creating a new class: Area
    {

        private double Length;
        private double Breadth;
        //private fields Lengths and Breadth

        public Area(double length, double breadth) //the constructor of the class
        {
            Length = length;
            Breadth = breadth;
            //setting the value of the fields through then constructor arguments
        }

        public double ReturnArea() // declaring a public method in the class
        {
            return Length * Breadth;
            //returns the area by returning the product of the length and breadth
        }
    }
}