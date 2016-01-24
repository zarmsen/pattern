using System;
using System.Collections.Generic;
using System.Globalization;

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
                    int figure;
                    Int32.TryParse(value.ToString(), out figure);
                    var figureExpression = new FigureExpression(figure);
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