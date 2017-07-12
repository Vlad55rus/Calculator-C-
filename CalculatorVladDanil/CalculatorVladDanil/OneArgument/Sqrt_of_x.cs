using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorVladDanil.OneArgument
{
    public class Sqrt_of_x : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Pow(firstArgument, 0.5);
        }
    }
}
