using System;

namespace Patterns.Behavioral.Interceptor
{
    internal class LoggingInterceptor : IInterceptor<GameContext>
    {
        public void HandleEvent(GameContext context, string search)
        {
            Console.WriteLine("User search to '{0}'!", search);
            var player = context.GetPlayer(search);
            if (player == null)
            {
                Console.WriteLine("Nobody in the framework!'{0}'!", search);
            }
            else
            {
                Console.WriteLine("Framework found player '{0}'.", player.Name);
            }
        }
    }
}