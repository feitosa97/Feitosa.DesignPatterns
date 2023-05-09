using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Command
{
    class FinishOrderCommand : ICommand
    {
        private Order order;

        public FinishOrderCommand(Order order) 
        {
            this.order = order;
        }
        public void Execute()
        {
            Console.WriteLine($"Finishing customer order {order.Customer}");
            order.Finish();
        }
    }
}
