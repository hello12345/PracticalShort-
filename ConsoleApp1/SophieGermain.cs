using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SophieGermain
    {
        public static void FindSophieGermain()
        {

            Console.WriteLine("Enter Limit :");
            int limit=int.Parse(Console.ReadLine());
            Console.WriteLine("Sophie Germain Prime Numbers:");
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    int sophieGermainCandidate = (2 * i) + 1;
                    if (IsPrime(sophieGermainCandidate))
                    {
                        Console.WriteLine($"{i} and {sophieGermainCandidate}");
                    }
                }
            }
        }
        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
