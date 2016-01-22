using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioral.ChainofResponsibility
{
    internal abstract class GameHandlerBase

    {
        private readonly IEnumerable<string> _commandList;

        protected GameHandlerBase Successor;

        protected GameHandlerBase(IEnumerable<string> commandList)
        {
            _commandList = commandList;
        }

        public void SetSuccessor(GameHandlerBase successor)
        {
            Successor = successor;
        }

        public void Execute(string command)
        {
            if (_commandList.Any(x => x.Contains(command)))
            {
                HandleRequest(command);
            }
            else
            {
                Successor.Execute(command);
            }
        }

        protected abstract void HandleRequest(string command);
    }
}