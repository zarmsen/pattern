using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.Interpreter
{
    internal class StringExpression : IExpression
    {
        public string Interpret(Context context)
        {
            var list = new List<string>();

            foreach (var value in context.Values)
            {
                var isDigit = Char.IsDigit(value);
                if (isDigit)
                {
                    var figureExpression = new FigureExpression(value);
                    list.Add(figureExpression.Interpret(context));

                }
                else
                {
                    var operandExpression = new OperandExpression(value);
                    list.Add(operandExpression.Interpret(context));
                }
            }

            context.Output = string.Join(" ", list);

            return context.Output;
        }
    }
}