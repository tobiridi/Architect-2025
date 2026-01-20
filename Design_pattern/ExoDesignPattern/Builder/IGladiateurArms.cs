namespace ExoDesignPattern.Builder
{
    public interface IGladiateurArms
    {
        IGladiateurIsDead SetDead();
        IGladiateurCreateDate CreateAt(DateTime creation);
    }
}
