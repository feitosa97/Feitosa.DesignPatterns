using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Bridge
{
    interface IMessage
    {
        ISender Sender { get; set; }
        void Send();
        string Format();
    }
}
