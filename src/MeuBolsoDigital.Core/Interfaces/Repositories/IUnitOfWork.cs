namespace MeuBolsoDigital.Core.Interfaces.Repositories;

public interface IUnitOfWork
{
    Task<bool> CommitAsync();
}
