using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public abstract class TemplateTaxCalculate : ITax
    {
        public TemplateTaxCalculate(ITax anotherTax) : base(anotherTax) { }
        public TemplateTaxCalculate() : base() { }
        public override double Calculate(Budget budget)
        {
            if(ShouldUseMaxTax(budget))
            {
                return MaxTax(budget) + AnotherTaxCaculate(budget);
            }
            return MinTax(budget) + AnotherTaxCaculate(budget);
        }
        public abstract double MinTax(Budget budget);
        public abstract double MaxTax(Budget budget);
        public abstract bool ShouldUseMaxTax(Budget budget);
    }
}
