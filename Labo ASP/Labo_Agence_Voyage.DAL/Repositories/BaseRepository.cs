using Labo_Agence_Voyage.DAL.Database;

namespace Labo_Agence_Voyage.DAL.Repositories
{
    //Utilise les repositories défini dans la couche "Domain" afin de connaitre les actions qui sont possible de faire pour faire persister les données (ici dans une base de données)
    //La couche "DAL" s'occupe de comment on implémente les actions défini dans la couche "Domain" pour que les données soit réellement sauver (ici dans une base de données)
    public abstract class BaseRepository
    {
        protected readonly AgenceVoyageDbContext _context;

        protected BaseRepository(AgenceVoyageDbContext context)
        {
            this._context = context;
        }
    }
}
