namespace TempFormatConverter.models
{
    public class Fahrenheit
    {
       
            public decimal Input { get; set; }
            public decimal Output { get; set; }

            public Fahrenheit(string input)
            {
                decimal fahrenheit;
                if (decimal.TryParse(input, out fahrenheit))
                {
                    Input = fahrenheit;
                }
            }
        /// <summary>
        /// Calculates the celsius expression out of a value given in fahrenheit scale.
        /// </summary>
        /// <returns></returns>
        public decimal ToCelsius()
        {
            decimal celsius = (Input - 32m) * 5m / 9m;
            return Output = celsius;
        }
    }
}