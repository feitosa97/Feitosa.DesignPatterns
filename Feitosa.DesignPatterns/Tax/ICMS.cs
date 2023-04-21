using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public class ICMS : ITax
    {
        public ICMS(ITax anotherTax) : base(anotherTax) { }
        public ICMS() : base() { }
        public override double Calculate(Budget budget)
        {
            return budget.Value * 0.1d + AnotherTaxCaculate(budget);
        }
    }
}
