namespace Labo_Agence_Voyage.Domain.Entities
{
    public class Destination
    {
        public Guid Id { get; private set; }
        public string Pays { get; private set; }
        public string Nom { get; private set; }
        public string? Description { get; private set; }
        public List<Activiter> Activites { get; private set; }
        public List<Reservation> Reservations { get; private set; }

        public Destination(Guid id, string pays, string nom, string? description)
        {
            this.Id = id;
            this.Pays = pays;
            this.Nom = nom;
            this.Description = description;
            this.Activites = new List<Activiter>();
            this.Reservations = new List<Reservation>();
        }

        public Destination(string pays, string nom, string? description)
            : this(Guid.NewGuid(), pays, nom, description)
        {}

        public void AjouterActiviter(Guid activiterId, string activiterNom, string description, decimal prix)
            => this.Activites.Add(new Activiter(activiterId, activiterNom, description, prix, this));

        public bool RetirerActiviter(Activiter activiter) => this.Activites.Remove(activiter);
    }
}
