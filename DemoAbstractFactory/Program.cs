using DemoAbstractFactory.Models.Bleu;
using DemoAbstractFactory.Models.Common;
using DemoAbstractFactory.Models.Rouge;

namespace DemoAbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Usine usineRouge = new UsineRouge();
            Usine usineBleu = new UsineBleu();
            ITank tankRouge = usineRouge.ProduireTank();
            ITank tankBleu = usineBleu.ProduireTank();

            Console.WriteLine(tankRouge);
            Console.WriteLine(tankBleu);
        }

    }

}
