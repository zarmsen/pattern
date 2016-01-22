namespace Patterns.Behavioral.ChainofResponsibility
{
    internal class Game
    {

        public void Execute(string command)
        {
            var handler = Setup();
            handler.Execute(command);
        }

        private static GameHandlerBase Setup()
        {
            var runHandler = new RunHandler();
            runHandler.SetSuccessor(new StopHandler());

            return runHandler;
        }
    }
}