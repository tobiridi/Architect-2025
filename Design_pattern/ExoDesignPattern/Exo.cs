using ExoDesignPattern.Models;

namespace ExoDesignPattern
{
    public class Exo
    {
        public static void Execute()
        {
            Gladiateur glad1 = Gladiateur.Builder.Create()
                .WithName("gladiateur 1")
                .WithLevel(15)
                .SetDead()
                .Build();

            Console.WriteLine(glad1);

            Gladiateur glad2 = Gladiateur.Builder.Create()
                .WithName("gladiateur 2")
                .WithLevel(3)
                .WithUsername("glad 2")
                .WithArms(4)
                .CreateAt(DateTime.Now)
                .Build();

            Console.WriteLine(glad2);
        }
    }
}
