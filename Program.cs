using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string decimalStr = "1.84";
            try
            {
                decimal convertedDecimal = decimal.Parse(decimalStr);
                Console.WriteLine("Converted decimal: " + convertedDecimal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error!!!-----Pls give correct one.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Decimal value is too large or too small");

            }
        }
    }
}
