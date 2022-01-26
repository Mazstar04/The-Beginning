namespace FirstTenPrimeNumbers
{
    public class PrimeNumbers
    {
        public static void FirstTenPrimeNumbers()
        {
            List<int> PrimeNumbers = new List<int>();

            int count = 0, n = 0, i = 1, j = 1;
            while (n < 10)
            {
                j = 1;
                count = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                        count++;
                    j++;
                }
                if (count == 2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    PrimeNumbers.Add(i);
                    n++;
                }
                i++;
            }
        }
    }
}