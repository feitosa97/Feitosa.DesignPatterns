using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public abstract class ITax
    {
        public ITax AnotherTax { get; set; }
        public abstract double Calculate(Budget budget);

        public ITax(ITax anotherTax)
        {
            AnotherTax = anotherTax;
        }

        public ITax()
        {
            AnotherTax = null;
        }
        public double AnotherTaxCaculate(Budget budget)
        {
            if(AnotherTax == null) return 0;
            return AnotherTax.Calculate(budget);
        }
    }
}
