namespace Patterns.Behavioral.Interpreter
{
    internal interface IExpression
    {
        string Interpret(Context context);
    }
}