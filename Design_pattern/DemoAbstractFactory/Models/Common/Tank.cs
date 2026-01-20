namespace DemoAbstractFactory.Models.Common
{
    public class Tank : ITank
    {
        public void TirerObus()
        {
            Console.WriteLine("Boum!");
        }
    }
}
