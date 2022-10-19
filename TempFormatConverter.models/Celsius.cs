using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempFormatConverter.models
{
    public class Celsius
    {
        public decimal Input { get; set; }
        public decimal Output { get; set; }

        public Celsius(string input)
        {
            decimal celsius;
            if (decimal.TryParse(input, out celsius))
            {
                Input = celsius;
            }
        }

        /// <summary>
        /// Calculates the fahrenheit expression out of a value given in celsius scale.
        /// </summary>
        /// <returns>decimal Fahrenheit</returns>
        public decimal ToFahrenheit()
        {
            decimal fahrenheit = Input * (9m / 5m) + 32m;
            return Output = fahrenheit;
        }

        /// <summary>
        /// Calculates the kelvin expression out of a value given in celsius scale.
        /// </summary>
        /// <returns></returns>
        public decimal ToKelvin()
        {
            decimal kelvin = Input + 273.15m;
            return Output = kelvin;
        }
    }
}
