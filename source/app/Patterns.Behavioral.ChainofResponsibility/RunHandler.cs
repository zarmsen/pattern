using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.ChainofResponsibility
{
    internal class RunHandler : GameHandlerBase
    {
        public RunHandler(): base(new List<string> {"run", "go"}) {}

        protected override void HandleRequest(string command)
        {
            Console.WriteLine("Player is running, because he is pushing command '{0}'.", command);
        }
    }
}