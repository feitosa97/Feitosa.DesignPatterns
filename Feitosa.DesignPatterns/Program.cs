using System;
using Feitosa.DesignPatterns.Tax;

namespace Feitosa.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new DiscountCalculator();

            var budget = new Budget(400d);
            budget.AddItem(new Item("Item1", 250d));
            budget.AddItem(new Item("Item2", 250d));
            budget.AddItem(new Item("Item3", 250d));
            budget.AddItem(new Item("Item4", 250d));
            budget.AddItem(new Item("Item5", 250d));
            budget.AddItem(new Item("Item6", 250d));

            var discount = calculator.Calculate(budget);

            Console.WriteLine(discount.ToString());
        }
    }
}
