using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Expression
{
    public class Number: IExpression
    {
        public Number(int number)
        {
            this.number = number;    
        }

        public int number { get; private set; }

        public int Calculate()
        {
            return this.number;
        }
    }
}
