using System;
using System.Threading;
using Feitosa.DesignPatterns.Tax;

namespace Feitosa.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var budget = new Budget(500d);

            Console.WriteLine(budget.Value);
            budget.ApplyExtraDiscount();

            Console.WriteLine(budget.Value);
            budget.Approve();
            budget.ApplyExtraDiscount();
            Console.WriteLine(budget.Value);

            budget.Finish();

            budget.ApplyExtraDiscount();
        }
    }
}
