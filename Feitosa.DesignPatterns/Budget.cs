using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns
{
    public class Budget
    {
        public double Value { get; internal set; }  

        public Budget(double value)
        {
            Value = value;
        }
    }
}
