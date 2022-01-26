using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Current time: ");

            int tym = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Full Name");
            string name = Console.ReadLine();

            if (tym < 12)

            {
                Console.WriteLine("Good Morning, " + name);
            }

            else if (tym < 15)
            {
                Console.WriteLine("Good Aftrenoon, " + name);
            }

            else
            {
                Console.WriteLine("Good Evening, " + name);
            }

            // string fname = "Bola";

            // string hobby = "swimmer";

            // Console.WriteLine("This is {0} the {1}", hobby, fname);


        }
    }
}


