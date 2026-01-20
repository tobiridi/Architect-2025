namespace ExoDesignPattern.Builder
{
    public interface IGladiateurLevel
    {
        IGladiateurIsDead SetDead();
        IGladiateurUsername WithUsername(string username);
    }
}
