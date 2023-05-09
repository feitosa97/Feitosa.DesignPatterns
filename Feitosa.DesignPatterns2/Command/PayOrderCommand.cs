using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Command
{
    class PayOrderCommand : ICommand
    {
        private Order order;

        public PayOrderCommand(Order order)
        {
            this.order = order;
        }
        public void Execute() 
        {
            Console.WriteLine($"Paying customer order {order.Customer}");
            order.Pay();
        }
    }
}
