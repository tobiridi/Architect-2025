using Labo_Agence_Voyage.Domain.Entities;

namespace Labo_Agence_Voyage.Domain.Repositories
{
    public interface IDestinationRepository : IRepository<Guid, Destination>
    {
        public IEnumerable<Destination> RecupTout();
    }
}
