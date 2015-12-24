namespace Patterns.Creational.Builder
{
    internal class MaybachInstallation : CarConfiguratorBase
    {
        public MaybachInstallation(): base("Maybach") {}


        protected override string Installation()
        {
            return "handwork";
        }
    }
}