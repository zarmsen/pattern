using System;
using System.Collections.Generic;

using Patterns.Core.Vehicle;

namespace Patterns.Creational.Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var equipments = new List<Equipment> { new Equipment("Window"), new Equipment("Engine") };

            var builder = new InstallationBuilder(equipments);
        
            builder.ApplyInstallation(new MaybachInstallation());
            builder.Build();
            
            Console.ReadKey();

            builder.ApplyInstallation(new VwCInstallation());
            builder.Build();
            
            Console.ReadKey();
        }
    }
}