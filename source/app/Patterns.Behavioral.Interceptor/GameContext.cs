using System;
using System.Collections.Generic;
using System.Linq;

using Patterns.Core.Game;

namespace Patterns.Behavioral.Interceptor
{
    internal class GameContext
    {
        private readonly List<PlayerBase> _players;

        public GameContext()
        {
            _players = new List<PlayerBase>
            {
                new Farmer("Hans", new Position(1, 1)),
                new King("Arthur", new Position(2, 1)),
                new Soldier("Bernd", new Position(3, 1))
            };
        }

        public PlayerBase GetPlayer(string name)
        {
            return _players.FirstOrDefault(x => string.Equals(name, x.Name, StringComparison.OrdinalIgnoreCase));
        }
    }
}