using ExoDesignPattern.Models;

namespace FQ25L066_CorrectionGladiateur.Patterns.Observer;

public interface ILifeStateChanged
{
    event Action<Gladiateur>? IsDeadHandler; 
}