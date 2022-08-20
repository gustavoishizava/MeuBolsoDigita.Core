using MeuBolsoDigital.Core.Interfaces.Entities;

namespace MeuBolsoDigital.Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : IAggregateRoot
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}