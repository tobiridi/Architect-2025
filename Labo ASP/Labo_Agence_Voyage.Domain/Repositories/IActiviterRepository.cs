using Labo_Agence_Voyage.Domain.Entities;

namespace Labo_Agence_Voyage.Domain.Repositories
{
    public interface IActiviterRepository
    {
        public IEnumerable<Activiter> RecupToutParDestination(Guid destinationId);
        public bool Creer(Activiter activiter);
    }
}
