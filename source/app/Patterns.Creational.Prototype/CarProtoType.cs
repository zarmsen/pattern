using System;
using System.Collections.Generic;

using Patterns.Core.Vehicle;

namespace Patterns.Creational.Prototype
{
    [Serializable]
    public class CarProtoType : Prototype<CarProtoType>
    {
        public CarProtoType(Car car)

        {
            Car = car;
        }

        public void Add(Equipment equipment)
        {
            Car.Equipments.Add(equipment);
        }
        
        public Car Car { get; set; }
    }
}