using System;

using Patterns.Core.Game;

namespace Patterns.Behavioral.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            var collection = new GameCollection
            {
                [0] = new King("Arthur", new Position(1, 1)),
                [1] = new Farmer("Klaus", new Position(1, 1)),
                [2] = new Soldier("Hans", new Position(1, 1))
            };

            Console.WriteLine("Collection: {0}", collection.Count);
            var iterator = collection.CreateIterator();
            
           
            Console.WriteLine("{0}", iterator.Next());
            Console.WriteLine("{0}", iterator.Next());
            Console.WriteLine("{0}", iterator.First());
            Console.WriteLine("{0}", iterator.CurrentItem);

            Console.ReadKey();
        }
    }
}
