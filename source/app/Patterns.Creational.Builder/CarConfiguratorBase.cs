using System;

using Patterns.Core.Vehicle;

namespace Patterns.Creational.Builder
{
    internal abstract class CarConfiguratorBase
    {
        private Car _car;

        protected CarConfiguratorBase(string manufacturerName)
        {
            _car = new Car(manufacturerName);
        }

        public void Build()
        {
            foreach (var equipment in _car.Equipments)
            {
                Console.WriteLine(equipment.Name + " "+ Installation());
            }
        }

        public void AddEquipment(Equipment equipment)
        {
            _car.Equipments.Add(equipment);
        }

        protected abstract string Installation();
    }
}