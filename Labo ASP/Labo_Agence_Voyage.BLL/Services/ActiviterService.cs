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
    public class ActiviterService : IActiviterService
    {
        private readonly IActiviterRepository _repo;

        public ActiviterService(IActiviterRepository repository)
        {
            this._repo = repository;
        }

        public Activiter Creer(Activiter activiter)
        {
            //verifie que les champs ne sont pas vide
            if (string.IsNullOrWhiteSpace(activiter.Description))
                throw new InvalidOperationException("la description ne peut pas être vide.");
            if (string.IsNullOrWhiteSpace(activiter.Nom))
                throw new InvalidOperationException("le nom ne peut pas être vide.");

            //verifie que le prix est positif et plus que 0
            if(activiter.Prix is not > 0)
                throw new InvalidOperationException("le prix doit être suppérieur à 0.");

            bool success = this._repo.Creer(activiter);
            if (success)
                return activiter;
            else
                throw new InvalidOperationException("L'activité n'a pas pu être créée.");
        }
    }
}
