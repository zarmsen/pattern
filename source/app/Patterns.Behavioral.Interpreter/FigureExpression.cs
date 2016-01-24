using System.Collections.Generic;

namespace Patterns.Behavioral.Interpreter
{
    internal class FigureExpression : IExpression
    {
        private readonly Dictionary<int, string> _values = new Dictionary<int, string>();

        private readonly int _value;

        public FigureExpression(int value)
        {
            _value = value;
            _values.Add(0, "Zero");
            _values.Add(1, "One");
            _values.Add(2, "Two");
            _values.Add(3, "Three");
            _values.Add(4, "Four");
            _values.Add(5, "Five");
            _values.Add(6, "Six");
            _values.Add(7, "Seven");
            _values.Add(8, "Eight");
            _values.Add(9, "Nine");
        }

        public string Interpret(Context context)
        {
            return _values[_value];
        }
    }
}