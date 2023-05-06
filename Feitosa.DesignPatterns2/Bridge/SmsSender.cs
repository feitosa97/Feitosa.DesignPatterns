using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Bridge
{
    class SmsSender : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Sending message by sms");
            Console.WriteLine(message.Format());
        }
    }
}
