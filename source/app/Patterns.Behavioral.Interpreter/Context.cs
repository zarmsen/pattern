using System.Collections.Generic;

namespace Patterns.Behavioral.Interpreter
{
    internal class Context

    {
        public Context(string input)
        {
            Values = input.ToCharArray();
        }

        public IEnumerable<char> Values { get; private set; }

        public string Output { get; set; }
    }
}