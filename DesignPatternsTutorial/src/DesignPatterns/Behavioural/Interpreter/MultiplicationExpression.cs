namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Interpreter
{
    public class MultiplicationExpression : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public MultiplicationExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret(Context context)
        {
            return _leftExpression.Interpret(context) * _rightExpression.Interpret(context);
        }
    }
}