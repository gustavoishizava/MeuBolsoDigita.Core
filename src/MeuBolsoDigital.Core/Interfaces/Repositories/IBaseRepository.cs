using MeuBolsoDigital.Core.Interfaces.Entities;

namespace MeuBolsoDigital.Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : IAggregateRoot
    {
        Task<TEntity> GetByIdAsync(Guid id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}