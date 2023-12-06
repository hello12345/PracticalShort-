using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\nEnter 1 For ReverseNumber");
                Console.WriteLine("Enter 2 For SophieGermain");
                Console.WriteLine("Enter 3 For CalculateSundaywithEvenDate");
                Console.WriteLine("Enter 4 For Exit");
                Console.WriteLine("Enter Your Input :");
                int UserInput = Convert.ToInt32(Console.ReadLine());
                switch (UserInput)
                {
                    case 1:
                        ReverseNumber.makenumberReverse();
                        break;
                    case 2:
                        SophieGermain.FindSophieGermain();
                        break;
                    case 3:
                        CalculateSundaywithEvenDate.FindDate();
                        break;
                    case 4:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("wrong Input");
                        break;
                }
            }

        }

    }
}
