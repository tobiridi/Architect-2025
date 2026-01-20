using DemoAbstractFactory.Models.Common;

namespace DemoAbstractFactory.Models.Rouge
{
    public class UsineRouge : Usine
    {
        public override IJeep ProduireJeep()
        {
            return new JeepRouge();
        }

        public override ITank ProduireTank()
        {
            return new TankRouge();
        }
    }
}
