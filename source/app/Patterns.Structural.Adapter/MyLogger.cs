namespace Patterns.Structural.Adapter
{
    public class MyLogger : Log4NetLogger, ILoggerAdapter
    {
        public void Error(string message)
        {
            Log("Error", message);
        }
    }
}