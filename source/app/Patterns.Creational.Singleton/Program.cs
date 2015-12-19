using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine( ConfigurationReader.Instance.Read(ConfigKey.Hello));
            Console.WriteLine( ConfigurationReader.Instance.Read(ConfigKey.Singleton));
            Console.ReadKey();

        }
    }
}
