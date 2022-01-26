using System;

namespace Work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Grade: ");

            char grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
            case 'a':
            case 'A':
                Console.WriteLine("Distiction!");
                break;
            case 'b':
            case 'B':
                Console.WriteLine("Excellent!");
                break;
            case 'c':
            case 'C':
                Console.WriteLine("Good");
                break;
            case 'd':
            case 'D':
                Console.WriteLine("Fair");
                break;
            case 'e':
            case 'E':
                Console.WriteLine("Pass");
                break;
            case 'f':
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid Grade!");
                break;
            }
        }
    }
}
