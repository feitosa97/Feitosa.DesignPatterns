using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Invoice
{
    public interface IInvoiceEvent
    {
        void Execute(Invoice invoice);
    }
}
