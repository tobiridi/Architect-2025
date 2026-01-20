using Labo_Agence_Voyage.DAL.Database;
using Labo_Agence_Voyage.Domain.Entities;
using Labo_Agence_Voyage.Domain.Repositories;

namespace Labo_Agence_Voyage.DAL.Repositories
{
    public class DestinationRepository : BaseRepository, IDestinationRepository
    {
        public DestinationRepository(AgenceVoyageDbContext context) : base(context)
        { }

        public bool Creer(Destination entity)
        {
            this._context.Destinations.Add(entity);
            return this._context.SaveChanges() > 0;
        }

        public Destination? RecupParId(Guid id)
        {
            return this._context.Destinations.SingleOrDefault(dest => dest.Id == id);
        }

        public IEnumerable<Destination> RecupTout()
        {
            return this._context.Destinations.AsEnumerable();
        }

        public bool Supprimer(Guid id)
        {
            Destination? removeDest = this._context.Destinations.SingleOrDefault(d => d.Id == id);
            if (removeDest is null)
                return false;

            this._context.Destinations.Remove(removeDest);
            return this._context.SaveChanges() > 0;
        }
    }
}
