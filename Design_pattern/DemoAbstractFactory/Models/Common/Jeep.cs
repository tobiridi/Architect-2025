namespace DemoAbstractFactory.Models.Common
{
    public class Jeep : IJeep
    {
        public void Eclairer()
        {
            if (new Random().Next(1, 3) == 1)
                Console.WriteLine("R.A.S");
            else
                Console.WriteLine("Ennemi en vue!");
        }
    }
}
