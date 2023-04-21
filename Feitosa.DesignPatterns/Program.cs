using System;
using System.Threading;
using Feitosa.DesignPatterns.Tax;

namespace Feitosa.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var iss = new ISS(new ICMS( new IKCV()));

            var budget = new Budget(500);

            double tax = iss.Calculate(budget);

            Console.WriteLine(tax);
        }
    }
}
