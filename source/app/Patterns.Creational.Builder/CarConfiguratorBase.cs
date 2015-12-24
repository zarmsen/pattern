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

        public abstract void Build();

        public abstract void AddEquipment(Equipment equipment);
    }
}