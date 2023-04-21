using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns
{
    public class TaxCalculator
    {
        public void Calculate(Budget budget, ITax tax)
        {
            double taxValue = tax.Calculate(budget);
            Console.WriteLine(taxValue);


        }
    }
}
