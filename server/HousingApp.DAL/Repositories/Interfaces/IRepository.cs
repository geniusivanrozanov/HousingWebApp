using HousingApp.DAL.Entities.Interfaces;

namespace HousingApp.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> Get();
        Task<IEnumerable<TEntity>> Get(Func<TEntity, bool> predicate);
        Task<TEntity> Insert(TEntity entity);
        Task<IEnumerable<TEntity>> Insert(IEnumerable<TEntity> entities);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(int id);
    }
}
