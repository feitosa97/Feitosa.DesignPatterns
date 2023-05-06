namespace Feitosa.DesignPatterns2.Expression
{
    internal class Sum: IExpression
    {
        private IExpression Left;
        private IExpression Right;

        public Sum(IExpression left, IExpression right)
        {
            this.Left = left;
            this.Right = right;
        }

        public int Calculate()
        {
            return Left.Calculate() + Right.Calculate();
        }
    }
}