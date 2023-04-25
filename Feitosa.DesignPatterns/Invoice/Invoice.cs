using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Invoice
{
    public class Invoice
    {
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public double GrossValue { get; set; }
        public double Tax { get; set; } 
        public IList<InvoiceItem> Items { get; set; }

        public string Observation { get; set; }
        public Invoice(string name, string documentNumber, DateTime issueDate, double grossValue, double tax, IList<InvoiceItem> items, string observation)
        {
            Name = name;
            DocumentNumber = documentNumber;
            GrossValue = grossValue;
            IssueDate = issueDate;
            Tax = tax;
            Items = items;
            Observation = observation;
            Items = items;
        }
    }
}
