using System;
using System.Threading;
using Feitosa.DesignPatterns.Invoice;
using Feitosa.DesignPatterns.Tax;

namespace Feitosa.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvoiceBuilder creator = new InvoiceBuilder();
            creator.ToCompany("Feitosa Inc.")
                .SetDocument("11.123.123/0001-11")
                .InCurrentDate()
                .SetObservation("Any observation")
                .AddItem(new InvoiceItem("I1", 100))
                .AddItem(new InvoiceItem("I2", 60))
                .AddItem(new InvoiceItem("I3", 230));

            var invoice = creator.Build();

            Console.WriteLine(invoice.GrossValue);
            Console.WriteLine(invoice.Tax);
        }
    }
}
