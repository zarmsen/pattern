using System.Collections.Generic;

using Patterns.Core.Vehicle;

namespace Patterns.Creational.Builder
{
    internal class InstallationBuilder
    {
        private readonly IEnumerable<Equipment> _equipments;

        private CarConfiguratorBase _configuration;

        public InstallationBuilder(IEnumerable<Equipment> equipments)
        {
            _equipments = equipments;
        }

        public void ApplyInstallation(CarConfiguratorBase configuration)
        {
            _configuration = configuration;
            foreach (var equipment in _equipments)
            {
                _configuration.AddEquipment(equipment);
            }
        }

        public void Build()
        {
            _configuration.Build();
        }
    }
}