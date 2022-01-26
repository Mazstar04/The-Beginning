using System;

namespace Method
{
    class Program
    {

        public static void Main(string[] args)
        {

            GreetUser();
           
        }

        public static string CollectUserName()
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            name = CapitalizeUsername(name);
            name = "Mrs. " + name;
            return name;
        }

        public static void GreetUser()
        {
            string u = CollectUserName();
            Console.WriteLine ("Welcome " + u);
        }

        public static string CapitalizeUsername(string username)
        {
            username = username.ToLower();
            string firstLetter = username[0].ToString().ToUpper();
            string otherLetters = username.Substring(1);
            return firstLetter + otherLetters;
        }
    }


    
}
