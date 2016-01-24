using System.Collections.Generic;

namespace Patterns.Behavioral.Interpreter
{
    internal class OperandExpression : IExpression
    {
        private readonly char _value;

        private readonly Dictionary<char, string> _values = new Dictionary<char, string>();

        public OperandExpression(char value)
        {
            _value = value;
            _values.Add('-', "Zero");
            _values.Add('+', "Plus");
        }

        public string Interpret(Context context)
        {
            if (_values.ContainsKey(_value))
            {
                return _values[_value];
            }

            return "Not available";
        }
    }
}