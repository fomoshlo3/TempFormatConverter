using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempFormatConverter.models
{
    public class Kelvin
    {
       
            public decimal Input { get; set; }
            public decimal Output { get; set; }

            public Kelvin(string input)
            {
                decimal kelvin;
                if (decimal.TryParse(input, out kelvin))
                {
                    Input = kelvin;
                }
            }
        /// <summary>
        /// Calculates the celsius expression out of a value given in kelvin scale.
        /// </summary>
        /// <returns></returns>
        public decimal ToCelsius()
        {
            decimal celsius = Input - 273.15m; //TODO: Formel einfügen und mit double casten und so weiter und so nervig
            return Output = celsius;
        }
    }
}
