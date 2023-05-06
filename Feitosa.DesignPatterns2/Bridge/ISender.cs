using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Bridge
{
    interface ISender
    {
        public void Send(IMessage message);
    }
}
