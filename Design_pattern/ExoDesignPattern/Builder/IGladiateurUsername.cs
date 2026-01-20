namespace ExoDesignPattern.Builder
{
    public interface IGladiateurUsername
    {
        IGladiateurArms WithArms(int arms);
        IGladiateurIsDead SetDead();
    }
}
