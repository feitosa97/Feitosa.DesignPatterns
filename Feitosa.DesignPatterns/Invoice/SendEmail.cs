using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Invoice
{
    public class EmailSender: IInvoiceEvent 
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("Fake email sending...");
        }
    }
}
