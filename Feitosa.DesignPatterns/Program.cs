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
            Observer();
        }

        public static void Strategy()
        {
            ITax iss = new ISS();
            ITax icms = new ICMS();

            var budget = new Budget(500d);

            var calculator = new TaxCalculator();

            calculator.Calculate(budget, iss);
        }
        public static void ChainOfResponsability()
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

        public static void Decorator()
        {
            var iss = new ISS(new ICMS(new IKCV()));
            var budget = new Budget(500);
            double tax = iss.Calculate(budget);
            Console.WriteLine(tax);
        }

        public static void State()
        {
            var budget = new Budget(500d);
            Console.WriteLine(budget.Value);
            budget.ApplyExtraDiscount();
            Console.WriteLine(budget.Value);
            budget.Approve();
            budget.ApplyExtraDiscount();
            Console.WriteLine(budget.Value);
            budget.Finish();

            //budget.ApplyExtraDiscount();
        }
        public static void Builder() 
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

        public static void Observer()
        {
            InvoiceBuilder creator = new InvoiceBuilder();
            creator.ToCompany("Feitosa Inc.")
                .SetDocument("11.123.123/0001-11")
                .InCurrentDate()
                .SetObservation("Any observation")
                .AddItem(new InvoiceItem("I1", 100));

            creator.AddEvent(new EmailSender());
            creator.AddEvent(new InvoiceRepository());
            creator.AddEvent(new MessageSender());

            var invoice = creator.Build();
        }
    }
}
