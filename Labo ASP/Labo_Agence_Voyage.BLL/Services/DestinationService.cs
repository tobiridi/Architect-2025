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
    public class DestinationService : IDestinationService
    {
        private readonly IDestinationRepository _repo;

        public DestinationService(IDestinationRepository repo)
        {
            this._repo = repo;
        }

        public Destination Creer(Destination destination)
        {
            //verifie que les champs ne sont pas vide
            if (string.IsNullOrWhiteSpace(destination.Pays))
                throw new InvalidOperationException("le pays ne peut pas être vide.");
            if (string.IsNullOrWhiteSpace(destination.Nom))
                throw new InvalidOperationException("le nom ne peut pas être vide.");

            bool success = this._repo.Creer(destination);
            if (success)
                return destination;
            else
                throw new InvalidOperationException("La destination n'a pas pu être créée.");
        }

        public Destination? RecupParId(Guid id) => this._repo.RecupParId(id);

        public List<Destination> RecupTout()
        {
            IEnumerable<Destination> dest = this._repo.RecupTout();
            if (!dest.Any())
                return new List<Destination>(0);

            return dest.ToList();
        }
    }
}
