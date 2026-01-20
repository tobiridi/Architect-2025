using Labo_Agence_Voyage.Domain.Entities;

namespace Labo_Agence_Voyage.BLL.Interfaces
{
    //on reprend la même mécanique que pour les couches "DAL" et "Domain", où le "Domain" définit les repositories et la "DAL" implémente concrètement les repositories afin de faire persister les données
    //ici dans la couche "BLL" on défini ce que pourront faire les applications concrète (ASP MVC, programme console, ...) avec nos entités défini dans la couche "Domain"
    //on parle aussi de use-cases, délimite les interactions que pourront faire les applications concrète
    //la couche "BLL" contient des interfaces qui seront utiliser par les autres couches + l'implémentation de ses interfaces, aussi appelé service
    //la couche "BLL" permet de centraliser la logique de vérification, validation et de transmission des données vers d'autres couches "DAL", etc... en fonction de l'architecture logiciel.
    //on fait cette séparation pour une meilleur maintenabilité et indépendance des couches
    public interface IReservationService
    {
        public List<Reservation> RecupTout();
        public Reservation Creer(Reservation reservation);
        public bool Annuler(Guid reservationId);
    }
}
