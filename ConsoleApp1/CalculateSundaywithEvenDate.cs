using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CalculateSundaywithEvenDate
    {
        public static void FindDate()
        {
            Console.Write("Enter a First Date  (dd,mm,yyyy Formats) : ");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter a Second Date (dd,mm,yyyy Formats) : ");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());

            int count = CountSundaysWithEvenDate(startDate, endDate);

            Console.WriteLine($"Number of instances where Sunday falls on an even date: {count}");
        }
        static int CountSundaysWithEvenDate(DateTime startDate, DateTime endDate)
        {
            int count = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday && date.Day % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
