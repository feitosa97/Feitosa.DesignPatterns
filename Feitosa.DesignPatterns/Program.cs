using System;

namespace Feitosa.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITax iss = new ISS();
            ITax icms = new ICMS();

            var budget = new Budget(500d);

            var calculator = new TaxCalculator();

            calculator.Calculate(budget, iss);
        }
    }
}
