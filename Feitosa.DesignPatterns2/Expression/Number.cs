﻿using Feitosa.DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Expression
{
    public class Number: IExpression
    {
        public Number(int number)
        {
            this.Value = number;    
        }

        public int Value { get; private set; }

        public int Calculate()
        {
            return this.Value;
        }

        public void Accept(PrinterVisitor printer)
        {
            printer.PrintNumber(this);
        }
    }
}
