namespace MethodOverloading
{
    public class ClassMazstar
    {
        public static int NumberOfCalls = 0;
        public int Num = 0;

        public double Subtraction(double a, double b)
        {
            double sub = a - b;
            return sub;
        }

        public void AddToNumberOfCalls()
        {
            NumberOfCalls+=1;
        }

        public void AddToNum()
        {
            Num++;
        }
        public int GetNumberOfCalls()
        {
            return NumberOfCalls;
        }
        public int GetNum()
        {
            return Num;
        }
    }
}