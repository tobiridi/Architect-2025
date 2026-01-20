using FQ25L066_CorrectionGladiateur.Patterns.Mediator;

namespace ExoDesignPattern.Models;

public class Logging
{
    public Logging()
    {
        Messenger<string>.Instance.Register(OnNewMessage);
    }

    private void OnNewMessage(string message)
    {
        Console.WriteLine(message);
    }
}