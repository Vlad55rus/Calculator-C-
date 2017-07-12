using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorVladDanil.OneArgument
{
    public class Square_of_x : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return firstArgument*firstArgument;
        }
    }
}
