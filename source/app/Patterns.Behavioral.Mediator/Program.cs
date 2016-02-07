using System;

namespace Patterns.Behavioral.Mediator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var chatRoom = new ChatRoom();
            var admin = new Administrator("Klaus");
            var bernd = new Participant("Bernd");
            var hans = new Participant("Hans");

            chatRoom.Register(admin);
            chatRoom.Register(bernd);
            chatRoom.Register(hans);

            bernd.Send("Hi", hans);
            admin.Send("Whats going on?", bernd);


            Console.ReadKey();
        }
    }
}