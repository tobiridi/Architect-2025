using ExoDesignPattern.Models;

namespace ExoDesignPattern.Builder
{
    public interface IGladiateurIsDead
    {
        IGladiateurUsername WithUsername(string username);
        Gladiateur Build();
    }
}
