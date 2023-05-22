using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class Squareroot
    {
        public static void call()
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            double squareRoot = CalculateSquareRoot(number);

            Console.WriteLine("Square root: " + squareRoot);
        }
        public static double CalculateSquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number");
            }

            if (number == 0)
            {
                return 0;
            }

            double guess = number ; 

            for (int i = 0; i < 10; i++)
            {
                double newGuess = (guess + number / guess) / 2;
                guess = newGuess;
            }

            return guess;
        }
    }
}
