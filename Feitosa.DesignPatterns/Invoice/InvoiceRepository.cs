using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Invoice
{
    public class InvoiceRepository: IInvoiceEvent
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("Fake saving...");
        }
    }
}
