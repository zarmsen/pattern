using System;

namespace Patterns.Structural.Adapter
{
    public class Log4NetLogger
    {
        public void Log(string type, string messsag)
        {
            Console.WriteLine("type:{0} message: {1}", type, messsag);
        } 
    }
}