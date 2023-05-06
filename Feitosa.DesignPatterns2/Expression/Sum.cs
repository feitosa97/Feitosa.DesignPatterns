using Feitosa.DesignPatterns2.Visitor;

namespace Feitosa.DesignPatterns2.Expression
{
    public class Sum: IExpression
    {
        public IExpression Left { get; private set; }
        public IExpression Right { get; private set; }

        public Sum(IExpression left, IExpression right)
        {
            this.Left = left;
            this.Right = right;
        }

        public int Calculate()
        {
            return Left.Calculate() + Right.Calculate();
        }

        public void Accept(PrinterVisitor printer)
        {
            printer.PrintSum(this);
        }
    }
}