namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Interpreter
{
    public class Interpreter
    {
        private Context _context;

        public Interpreter(Context context)
        {
            this._context = context;
        }

        public int Interpret(string expression)
        {
            IExpression exp = BuildExpressionTree(expression);
            return exp.Interpret(_context);
        }

        // 1 + 2 * 3
        private IExpression BuildExpressionTree(string input)
        {
            input = "1+2*3";
            return new AdditionExpression(
                new MultiplicationExpression(
                    new NumberExpression("2"),
                    new NumberExpression(3)
                ),
                new NumberExpression("1")
            );
        }
    }
}