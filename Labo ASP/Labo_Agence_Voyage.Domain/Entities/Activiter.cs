namespace Labo_Agence_Voyage.Domain.Entities
{
    public class Activiter
    {
        public Guid Id { get; private set; }
        public string Nom { get; private set; }
        public string Description { get; private set; }
        public decimal Prix { get; private set; }
        public Destination Destination { get; private set; }

        //constructeur pour EF
        private Activiter(Guid id, string nom, string description, decimal prix)
        {
            this.Id = id;
            this.Nom = nom;
            this.Description = description;
            this.Prix = prix;
        }

        public Activiter(Guid id, string nom, string description, decimal prix, Destination destination) 
            : this(id, nom, description, prix)
        {
            this.Destination = destination;
        }

        public Activiter(string nom, string description, decimal prix, Destination destination)
            : this(Guid.NewGuid(), nom, description, prix, destination)
        {}
        
    }
}
