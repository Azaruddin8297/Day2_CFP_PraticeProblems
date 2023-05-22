using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class ConvertDaysintoYears
    {
        public static void call()
        {
            Console.Write("Enter days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int months = remainingDays / 30;
            int weeks = remainingDays % 30 / 7;

            Console.WriteLine("Years: " + years);
            Console.WriteLine("Months: " + months);
            Console.WriteLine("Weeks: " + weeks);
        }
    }
}
