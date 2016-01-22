using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.ChainofResponsibility
{
    internal class StopHandler : GameHandlerBase
    {
        public StopHandler(): base(new List<string> {"stop", "end"}) {}

        protected override void HandleRequest(string command)
        {
            Console.WriteLine("End of the Game!");
        }
    }
}