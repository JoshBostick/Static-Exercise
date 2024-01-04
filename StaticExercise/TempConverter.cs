using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double far)
        {
            return (far - 32) / 1.8;
        }
        public static double CelsiustoFahrenheit(double cel)
        {
            return (cel * 9) / 5 + 32;
        }
    }
}
