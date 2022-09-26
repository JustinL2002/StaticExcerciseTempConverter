using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExcercise
{
    internal static class TempConverter
    {
        public static double FarenheitToCelcius(double farenheit)
        {
            double celcius = (farenheit - 32) / 1.8;
            Console.WriteLine(celcius);
            return celcius;
        }
        public static double CelciusToFarenheit(double celcius)
        {           
            double farenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine(farenheit);
            return farenheit;
        }
    }
}
