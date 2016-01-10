namespace Patterns.Structural.Facade
{
    internal class OurSystemFacade
    {
        private readonly SubSystemOne _systemOne;

        private readonly SubSystemTwo _systemTwo;

        public OurSystemFacade()
        {
            _systemOne = new SubSystemOne();
            _systemTwo = new SubSystemTwo();
        }

        public void Read(int subSystem)
        {
            switch (subSystem)
            {
                case 1:
                {
                    _systemOne.ReadOne();
                    break;
                }case 2:
                {
                    _systemTwo.ReadTwo();
                    break;
                }
            }
        }
    }
}