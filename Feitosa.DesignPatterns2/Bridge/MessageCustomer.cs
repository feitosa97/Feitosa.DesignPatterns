using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Bridge
{
    class MessageCustomer : IMessage
    {
        public string customerName;

        public ISender Sender { get; set; }

        public void Send()
        {
            this.Sender.Send(this);

        }

        public string Format()
        {
            return string.Format("Sending message to customer {0}", customerName);
        }

        public MessageCustomer(string customerName)
        {
            this.customerName = customerName;
        }
    }
}
