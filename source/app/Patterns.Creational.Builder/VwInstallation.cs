namespace Patterns.Creational.Builder
{
    internal class VwCInstallation : CarConfiguratorBase
    {
        public VwCInstallation(): base("VW") {}


        protected override string Installation()
        {
            return "automation";
        }
    }
}