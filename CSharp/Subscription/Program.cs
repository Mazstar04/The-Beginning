using System;

namespace Subscription
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int daysRemaining = random.Next(12);

            int discount = 0;

            if (daysRemaining == 0)
            {
                Console.WriteLine("Your Subscription has Expired!");
            }
            else if (daysRemaining == 1)
            {
                discount += 20;
                Console.WriteLine("Your Subscription will expire within a day");
                Console.WriteLine("Renew now and save " + discount + "% discount");
            }
            
            else if (daysRemaining <= 5 )
            {
                discount += 10;
                Console.WriteLine("Your Subscription will expire in " + daysRemaining + " days");
                Console.WriteLine("Renew now and save " + discount + "% discount");
            }
            else if (daysRemaining <= 10)
            {
                Console.WriteLine("Your Subscription Will soon Expire!");
            }
        }
    }
}
