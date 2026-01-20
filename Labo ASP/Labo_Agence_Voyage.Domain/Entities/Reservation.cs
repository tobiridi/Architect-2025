namespace Labo_Agence_Voyage.Domain.Entities
{
    public class Reservation
    {
        public Guid Id { get; private set; }
        public string NomClient { get; private set; }
        public DateTime DateReservation { get; private set; }
        public Destination Destination { get; private set; }

        //constructeur pour EF
        private Reservation(Guid id, string nomClient, DateTime dateReservation)
        {
            this.Id = id;
            this.NomClient = nomClient;
            this.DateReservation = dateReservation;
        }

        public Reservation(Guid id, string nomClient, DateTime dateReservation, Destination destination) 
            : this(id, nomClient, dateReservation)
        {
            this.Destination = destination;
            this.Destination.Reservations.Add(this);
        }

        public Reservation(string nomClient, DateTime dateReservation, Destination destination)
            : this(Guid.NewGuid(), nomClient, dateReservation, destination)
        {}
    }
}
