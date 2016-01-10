using System;

namespace Patterns.Structural.Proxy
{
    internal class MailLogProxy : IMail
    {
        private readonly Mail _mail;

        public MailLogProxy()
        {
            _mail = new Mail();
        }
        public void Send()
        {
            _mail.Send();
            Console.WriteLine("Log mail");
        }
    }
}