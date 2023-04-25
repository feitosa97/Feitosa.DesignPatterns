using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Invoice
{
    public class InvoiceBuilder
    {
        public string Name { private set; get; }
        public string DocumentNumber { private set; get; }
        public double TotalValue { private set; get; }
        public double Taxes { private set; get; }
        public DateTime IssueDate { private set; get; }
        public string Observation { private set; get; }
        public IList<InvoiceItem> AllItems = new List<InvoiceItem>();
        public InvoiceBuilder ToCompany(string name)
        {
            Name = name;
            return this;
        }

        public InvoiceBuilder SetDocument(string documentNumber)
        {
            DocumentNumber = documentNumber;
            return this;
        }
        public InvoiceBuilder InCurrentDate()
        {
            IssueDate = DateTime.Now;
            return this;
        }

        public InvoiceBuilder AddItem(InvoiceItem item) 
        { 
            AllItems.Add(item);
            TotalValue += item.Value;
            Taxes += item.Value * 0.05;
            return this;
        }

        public InvoiceBuilder SetObservation(string observation)
        {
            Observation = observation.Trim();
            return this;
        }

        public void AddEvent(IInvoiceEvent @event)
        {
            Events.Add(@event);
        }

        public IList<IInvoiceEvent> Events = new List<IInvoiceEvent>();
        public Invoice Build()
        {
            var invoice = new Invoice(Name, DocumentNumber, IssueDate, TotalValue, Taxes, AllItems, Observation);

            foreach(var e in Events)
                e.Execute(invoice);

            return invoice;
        }

        
        
    }
}
