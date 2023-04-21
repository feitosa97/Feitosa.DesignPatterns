using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public class Item
    {
        public string Name { get; private set; }
        public double Value { get; private set; }
        public Item(string name, double value) 
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
