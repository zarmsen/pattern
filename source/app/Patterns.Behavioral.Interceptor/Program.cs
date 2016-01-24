using System;

namespace Patterns.Behavioral.Interceptor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dispatcher = new SearchDispatcher<GameContext>();
            dispatcher.Register(new LoggingInterceptor());

            var framework = new GameFramework(dispatcher);
            framework.Get("Hans");
            framework.Get("Farmer Hans");

            Console.ReadKey();
        }
    }
}