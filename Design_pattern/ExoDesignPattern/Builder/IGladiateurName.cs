using ExoDesignPattern.Models;

namespace ExoDesignPattern.Builder
{
    public interface IGladiateurName
    {
        IGladiateurLevel WithLevel(int level);
    }
}
