namespace Labo_Agence_Voyage.Domain.Repositories
{
    //défini les actions de persistance des entités, décrit les méthodes qui devront être utiliser avec de faire persister les données dans une DB, fichier, etc ...
    //une autre pratique est de mettre les définitions des repository dans la couche "DAL", comme ça la "DAL" a les interfaces + implémentation
    //dans ce cas il faut ajuster les dépendances des projets en conséquence !
    public interface IRepository<TKey,TEntity> where TKey : struct where TEntity : class
    {
        public TEntity? RecupParId(TKey id);
        public bool Creer(TEntity entity);
        public bool Supprimer(TKey id);
    }
}
