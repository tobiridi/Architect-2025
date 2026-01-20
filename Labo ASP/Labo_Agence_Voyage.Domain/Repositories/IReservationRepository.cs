using Labo_Agence_Voyage.Domain.Entities;

namespace Labo_Agence_Voyage.Domain.Repositories
{
    public interface IReservationRepository
    {
        public IEnumerable<Reservation> RecupTout();
        public Reservation? RecupParId(Guid reservationId);
        public bool Creer(Reservation reservation);
        public bool Supprimer(Guid reservationId);
    }
}
