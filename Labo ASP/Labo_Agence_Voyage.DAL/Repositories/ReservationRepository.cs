using Labo_Agence_Voyage.DAL.Database;
using Labo_Agence_Voyage.Domain.Entities;
using Labo_Agence_Voyage.Domain.Repositories;

namespace Labo_Agence_Voyage.DAL.Repositories
{
    public class ReservationRepository : BaseRepository, IReservationRepository
    {
        public ReservationRepository(AgenceVoyageDbContext context) : base(context)
        {}

        public bool Creer(Reservation reservation)
        {
            this._context.Reservations.Add(reservation);
            return this._context.SaveChanges() > 0;
        }

        public Reservation? RecupParId(Guid reservationId)
        {
            return this._context.Reservations.SingleOrDefault(r => r.Id == reservationId);
        }

        public IEnumerable<Reservation> RecupTout()
        {
            return this._context.Reservations.AsEnumerable();
        }

        public bool Supprimer(Guid reservationId)
        {
            Reservation? removeRes = this._context.Reservations.SingleOrDefault(d => d.Id == reservationId);
            if (removeRes is null)
                return false;

            this._context.Reservations.Remove(removeRes);
            return this._context.SaveChanges() > 0;
        }
    }
}
