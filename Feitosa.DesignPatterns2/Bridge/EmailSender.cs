using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Bridge
{
    class EmailSender  : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Sending message by email");
            Console.WriteLine(message.Format());
        }
    }
}
