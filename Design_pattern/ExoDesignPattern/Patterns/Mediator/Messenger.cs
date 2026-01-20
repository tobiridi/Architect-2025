
namespace FQ25L066_CorrectionGladiateur.Patterns.Mediator;
public class Messenger<TMessage>
{
    public static Messenger<TMessage> Instance = new Messenger<TMessage>();

    private Messenger()
    {

    }

    private Action<TMessage>? _broadcast;

    public void Register(Action<TMessage> action)
    {
        _broadcast += action;
    }

    public void Unregister(Action<TMessage> action)
    {
        _broadcast -= action;
    }

    public void Send(TMessage message)
    {
        Action<TMessage>? broadcast = _broadcast;
        broadcast?.Invoke(message);
    }
}