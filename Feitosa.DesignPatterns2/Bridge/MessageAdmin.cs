using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Bridge
{
    class MessageAdmin : IMessage
    {
        public string adminName;

        public ISender Sender { get; set ; }

        public void Send()
        {
            this.Sender.Send(this);

        }

        public string Format()
        {
            return string.Format("Sending message to admin {0}", adminName);
        }

        public MessageAdmin(string customerName)
        {
            this.adminName = customerName;
        }
    }
}
