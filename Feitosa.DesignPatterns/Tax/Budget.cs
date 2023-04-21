using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public class Budget
    {
        public double Value { get; internal set; }
        public IList<Item> Items { get; internal set; }

        public Budget(double value)
        {
            Value = value;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        { 
            Items.Add(item); 
        }    
    }
}
