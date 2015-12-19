using System.Collections.Generic;

using Patterns.Core;

namespace Patterns.Creational.Multiton
{
    internal sealed class DbConnectionPool
    {
        private DbConnectionPool() {}

        private static readonly Dictionary<int, DbConnection> _instances = new Dictionary<int, DbConnection>();

        private static DbConnectionPool _instance;

        public static DbConnectionPool Instance
        {
            get
            {
                lock(_instance)
                {
                    return _instance ?? (_instance = new DbConnectionPool());
                }
            }
        }

        public DbConnection this[int index]
        {
            get
            {
                lock(_instances)
                {
                    DbConnection instance;
                    _instances.TryGetValue(index, out instance);

                    if (instance == null)
                    {
                        instance = new DbConnection($"Connection{index}");
                        _instances.Add(index, instance);
                    }

                    return instance;
                }
            }
        }

        public void OpenAll()
        {
            lock(_instances)
            {
                foreach (var dbConnection in _instances)
                {
                    dbConnection.Value.Open();
                }
            }
        }
    }
}