using System;

namespace Patterns.Creational.Multiton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DbConnectionPool.Instance[2].Open();
            DbConnectionPool.Instance[5].Open();
            DbConnectionPool.Instance[8].Open();

            Console.WriteLine("Press Enter to open all instances again.");
            Console.ReadKey();

            DbConnectionPool.Instance.OpenAll();

            Console.ReadKey();
        }
    }
}