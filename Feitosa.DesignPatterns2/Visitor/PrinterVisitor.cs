using Feitosa.DesignPatterns2.Expression;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Visitor
{
    public class PrinterVisitor
    {
        public void PrintSum(Sum sum)
        {
            Console.Write("(");
            sum.Left.Accept(this);
            Console.Write("+");
            sum.Right.Accept(this);
            Console.Write(")");
        }

        public void PrintSubstract(Substract substract)
        {
            Console.Write("(");
            substract.Left.Accept(this);
            Console.Write("+");
            substract.Right.Accept(this);
            Console.Write(")");
        }

        public void PrintNumber(Number number) 
        {
            Console.Write(number.Value);

        }
    }
}
