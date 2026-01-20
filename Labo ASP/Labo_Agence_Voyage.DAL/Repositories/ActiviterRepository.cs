using Labo_Agence_Voyage.DAL.Database;
using Labo_Agence_Voyage.Domain.Entities;
using Labo_Agence_Voyage.Domain.Repositories;

namespace Labo_Agence_Voyage.DAL.Repositories
{
    public class ActiviterRepository : BaseRepository, IActiviterRepository
    {
        public ActiviterRepository(AgenceVoyageDbContext context) : base(context)
        {}

        public bool Creer(Activiter activiter)
        {
            this._context.Activites.Add(activiter);
            return this._context.SaveChanges() > 0 ;
        }

        public IEnumerable<Activiter> RecupToutParDestination(Guid destinationId)
        {
            return this._context.Activites.Where(a => a.Destination.Id == destinationId)
                    .AsEnumerable();
        }
    }
}
