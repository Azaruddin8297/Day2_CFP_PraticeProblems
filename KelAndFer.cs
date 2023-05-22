using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class KelAndFer
    {
        public static void call()
        {
            Console.Write("Enter the amount of Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double kelvin = ConvertCelsiusToKelvin(celsius);
            double fahrenheit = ConvertCelsiusToFahrenheit(celsius);

            Console.WriteLine("Kelvin = " + kelvin);
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }

        static double ConvertCelsiusToKelvin(double celsius)
        {
            double kelvin = celsius + 273.15;
            return kelvin;
        }

        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            return fahrenheit;
        }

    }
}
