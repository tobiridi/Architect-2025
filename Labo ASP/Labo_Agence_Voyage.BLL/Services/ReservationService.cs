using Labo_Agence_Voyage.BLL.Interfaces;
using Labo_Agence_Voyage.Domain.Entities;
using Labo_Agence_Voyage.Domain.Repositories;

namespace Labo_Agence_Voyage.BLL.Services
{
    //La couche "BLL" sert d'intermédiaire entre (ce que l'on veut manipuler et rendre accessible dans notre application) ET (la couche de persistance des données "DAL")
    //c'est dans cette couche que l'on regroupe les cas d'utilisations de notre application avec les vérifications, transformations, etc... pour avoir des données cohèrente à faire persister.
    //utilise les repositories de la couche "DAL" pour réellement faire persister les données
    //vue que la couche "DAL" est une implémentation de ce qui a été défini dans la couche "Domain" alors on réutilise les même interfaces
    //ça permet de définir à un seul endroit "Domain" ce que l'on peut faire afin de faire persister les données, ça réduit les erreurs car la couche "BLL" et "DAL" dépendent des mêmes interfaces
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _repo;

        public ReservationService(IReservationRepository repo)
        {
            this._repo = repo;
        }

        public bool Annuler(Guid reservationId) => this._repo.Supprimer(reservationId);

        public Reservation Creer(Reservation reservation)
        {
            if (string.IsNullOrWhiteSpace(reservation.NomClient))
                throw new InvalidOperationException("le nom du client ne peut pas être vide.");

            DateTime now = DateTime.UtcNow;
            if (reservation.DateReservation < now)
                throw new InvalidOperationException($"la date de reservation ne peut pas être antérieur à {now:F}.");

            bool success = this._repo.Creer(reservation);
            if (success)
                return reservation;
            else
                throw new InvalidOperationException("La reservation n'a pas pu être créée.");
        }

        public List<Reservation> RecupTout()
        {
            IEnumerable<Reservation> res = this._repo.RecupTout();
            if (!res.Any())
                return new List<Reservation>(0);

            return res.ToList();
        }
    }
}
