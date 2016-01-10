using System;

namespace Patterns.Structural.Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = new MailLogProxy();
            proxy.Send();

            var dynamicProxy = new LogProxy<IMail>(new Mail());
            var mail = dynamicProxy.GetTransparentProxy() as IMail;

            if (mail != null)
            {
                mail.Send();
            }

            Console.ReadKey();
        }
    }
}