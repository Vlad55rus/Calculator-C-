using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Ten_in_power_of_x : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}
