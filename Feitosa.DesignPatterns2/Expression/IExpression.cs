using Feitosa.DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Expression
{
    public interface IExpression
    {
        int Calculate();
        void Accept(PrinterVisitor print);
    }
}
