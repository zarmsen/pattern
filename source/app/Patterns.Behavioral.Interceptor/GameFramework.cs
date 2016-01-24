using Patterns.Core.Game;

namespace Patterns.Behavioral.Interceptor
{
    internal class GameFramework
    {
        private readonly SearchDispatcher<GameContext> _searchDispatcher;

        private readonly GameContext _context;

        public GameFramework(SearchDispatcher<GameContext> dispatcher)
        {
            _context = new GameContext();
            _searchDispatcher = dispatcher;
        }

        public PlayerBase Get(string search)
        {
            _searchDispatcher.Dispatch(_context, search);
            return _context.GetPlayer(search);
        }


    }
}