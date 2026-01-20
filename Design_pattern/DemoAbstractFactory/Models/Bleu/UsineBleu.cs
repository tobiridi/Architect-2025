using DemoAbstractFactory.Models.Common;

namespace DemoAbstractFactory.Models.Bleu
{
    public class UsineBleu : Usine
    {
        public override IJeep ProduireJeep()
        {
            return new JeepBleu();
        }

        public override ITank ProduireTank()
        {
            return new TankBleu();
        }
    }
}
