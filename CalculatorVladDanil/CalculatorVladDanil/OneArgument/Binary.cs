using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorVladDanil.OneArgument
{
    public class Binary: IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Convert.ToString(firstArgument, 2);
        }
    }
}

