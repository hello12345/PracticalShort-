using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal  class ReverseNumber
    {
        public static void makenumberReverse()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reversedNumber = Reverse(number);

            Console.WriteLine($"Reverse of entered number: {reversedNumber}");
        }

        private static int Reverse(int num)
        {
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = (reversedNum * 10) + digit;
                num = num / 10;
            }

            return reversedNum;
        }
    }
}
