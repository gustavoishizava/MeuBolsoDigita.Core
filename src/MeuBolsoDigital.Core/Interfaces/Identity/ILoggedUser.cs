namespace MeuBolsoDigital.Core.Interfaces.Identity
{
    public interface ILoggedUser
    {
        Guid UserId { get; }
        string Email { get; }
        bool IsAuthenticated { get; }
    }
}