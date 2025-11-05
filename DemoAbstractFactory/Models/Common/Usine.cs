namespace DemoAbstractFactory.Models.Common
{
    public abstract class Usine
    {
        public abstract ITank ProduireTank();

        public abstract IJeep ProduireJeep();
    }
}
