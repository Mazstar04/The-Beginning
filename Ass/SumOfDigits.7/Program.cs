using System;

namespace SumOfDigits._7
{
    class Program
    {
        public static int sum = 0;
        public static void Main(string[] args)
        {
            Console.Write("Enter any number of your choice: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int lengthOfNum = getLength(num);


            for(int i=0; i <lengthOfNum; i++)
            {
                if (getLength(num) > 1)
                {
                    sumNum(num);
                    num = divNum(num);
                }
                else
                {
                    sumNum(num);
                }
            }
            Console.WriteLine(sum);
        }
        public static int divNum(int num)
        {
            return num/10; 
        }

        public static void sumNum(int num)
        {
            sum += num%10;
        }

        public static int getLength(int num)
        {
            string m = num.ToString();
            return m.Length;

        }
    }
}
