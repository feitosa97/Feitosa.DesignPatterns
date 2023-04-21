using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public class DiscountCalculator
    {
        public DiscountCalculator() { }
        public double Calculate(Budget budget)
        {
            var d1 = new DiscountByItemsQuantity();
            var d2 = new DiscountByValue();
            var d3 = new DiscountGeneral();

            d1.NextDiscount = d2;
            d2.NextDiscount = d3;

            return d1.Calculate(budget);
        }

    }

    public interface IDiscount
    {
        double Calculate(Budget budget);
        IDiscount NextDiscount { get; set; }
    }
    public class DiscountByItemsQuantity : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double Calculate(Budget budget) 
        {
            if (budget.Items.Count >= 5)
                return budget.Value * 0.1d;
            return NextDiscount.Calculate(budget);
        }
    }

    public class DiscountByValue : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        public double Calculate(Budget budget)
        {
            if (budget.Value >= 500)
                return budget.Value * 0.07d;
            return NextDiscount.Calculate(budget);
        }
    }

    public class DiscountGeneral : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.03d;
        }
    }
}
