using System;

namespace MidTermPROG2070
{
    public class Program
    {
        public static string CategorizeNumber(int number)
        {
            if (number < 0)
            {
                return "The number is negative.";
            }
            else if (number == 0)
            {
                return "The number is zero.";
            }
            else if (number > 0 && number <= 10)
            {
                return "The number is between 1 and 10.";
            }
            else if (number > 10 && number <= 20)
            {
                return "The number is between 11 and 20.";
            }
            else if (number > 20 && number <= 30)
            {
                return "The number is between 21 and 30.";
            }
            else if (number > 30 && number <= 40)
            {
                return "The number is between 31 and 40.";
            }
            else if (number > 40 && number <= 50)
            {
                return "The number is between 41 and 50.";
            }
            else if (number > 50 && number <= 60)
            {
                return "The number is between 51 and 60.";
            }
            else if (number > 60 && number <= 70)
            {
                return "The number is between 61 and 70.";
            }
            else
            {
                return "The number is greater than 70.";
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CategorizeNumber(number));
        }
    }
}