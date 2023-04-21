using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public class IKCV : TemplateTaxCalculate
    {
        public override double MaxTax(Budget budget) => budget.Value * 0.1d;
        public override double MinTax(Budget budget) => budget.Value * 0.06d;
        public override bool ShouldUseMaxTax(Budget budget) => budget.Value >= 500d && ItemBiggetThan100(budget);
        private bool ItemBiggetThan100(Budget budget) => budget.Items.Any(i => i.Value > 100);
    }
}
