using System;

namespace MethodOverloading
{
    class Program
    {
        public double Sum(double a, int b)
        {
            double add = a + b;
            return add;
        }
        public double Sum(int a, int b)
        {
        
            
            double add = a + b;
            return add;
        }
        static void Main(string[] args)
        {
            
            ClassMazstar classMazstar = new ClassMazstar();
            ClassMazstar classMazstar2 = new ClassMazstar();
            ClassMazstar classMazstar3 = new ClassMazstar();
            
            classMazstar.AddToNum();
            classMazstar.AddToNumberOfCalls();
            classMazstar.AddToNumberOfCalls();
            classMazstar.AddToNumberOfCalls();
            classMazstar3.AddToNumberOfCalls();
            classMazstar3.AddToNumberOfCalls();
            classMazstar3.AddToNumberOfCalls();

            // Console.WriteLine(classMazstar.Num);
            // Console.WriteLine(classMazstar2.Num);
            // Console.WriteLine(classMazstar3.Num);
            // Console.WriteLine();

            ClassMazstar classMazstar4 = new ClassMazstar();
            Console.WriteLine(classMazstar4.GetNumberOfCalls());
            Console.WriteLine(classMazstar4.GetNum());

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // ClassMazstar c = new ClassMazstar();
            // Program p = new Program();
            
            // double sub = c.Subtraction(5.6, 4);
            // Random h = new Random();
            
            
            // int num = h.Next(1, 11);
            // Console.WriteLine();
            // double add1 = p.Sum(6.3, 2);
            // // Console.WriteLine($"The addition of the two decimal is {add1}");
            
            // // double add2 = Sum(1.2, 4);
            // Console.WriteLine($"The addition of the two decimal is {add2}");
        }
    }

}
