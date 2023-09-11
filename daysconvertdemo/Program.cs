using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysconvertdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;

            int months = remainingDays / 30;
            remainingDays %= 30;

            int weeks = remainingDays / 7;
            remainingDays %= 7;

            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Months: {months}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {remainingDays}");
            Console.ReadLine();

        }
    }
}
