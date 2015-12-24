using System.Collections.Generic;

namespace Patterns.Core.Vehicle
{
    public class Car
    {
        public Car(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        public string Manufacturer { get; }

        public List<Equipment> Equipments { get; } = new List<Equipment>();

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}";
        }
    }
}