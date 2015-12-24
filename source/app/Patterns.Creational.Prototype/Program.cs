using System;
using System.Collections.Generic;

using Patterns.Core.Vehicle;

namespace Patterns.Creational.Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            var car = new CarProtoType(new Car("Vw"));
            car.Add(new Equipment("Engine"));
            
            var copyOfCar = car.DeepCopy();
           
            copyOfCar.Add(new Equipment("Engine 2"));


            Console.WriteLine(copyOfCar.Car.Manufacturer);

            foreach (var variable in copyOfCar.Car.Equipments)
            {
                Console.WriteLine(variable.Name);
            }

            Console.ReadKey();
        }
    }
}