using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public class ICPP : TemplateTaxCalculate
    {
        public override double MaxTax(Budget budget) => budget.Value * 0.07d;
        public override double MinTax(Budget budget) => budget.Value * 0.05d;
        public override bool ShouldUseMaxTax(Budget budget) => budget.Value >= 500d;
    }
}
