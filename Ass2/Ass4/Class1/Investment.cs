using System;
namespace Class
{
    public class Investment
    {
        public static double Principal ;
        public static double Interest;
        public static double NumberOfYears;

        public Investment(double principal, double interest, double numberOfYears)
        {
            Principal = principal;
            Interest = interest;
            NumberOfYears = numberOfYears;
        }
        public static double Value()
        {
            double value = Principal*(1 + Interest)*NumberOfYears;
            Console.WriteLine($"The Value of your investment at the end of {NumberOfYears} years is {value}");
            return value;
        }
    }
}