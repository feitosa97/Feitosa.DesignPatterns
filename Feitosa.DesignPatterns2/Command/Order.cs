using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Command
{
    class Order
    {
        public string Customer { get; private set; }
        public double Value { get; private set; }
        public DateTime EndDate { get; private set; }
        public Status Status { get; private set; }
        public Order(string customer, double value) 
        { 
            Customer = customer;
            Value = value;
            Status = Status.Draft;
        }

        public void Pay()
        {
            this.Status = Status.Paid;
        }

        public void Finish() 
        {
            Status = Status.Delivered;
            EndDate = DateTime.Now;
        }
    }
}
