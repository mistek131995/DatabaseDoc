using Contracts.Interfaces.Repositories;

namespace Contracts.Database.Interfaces;

public interface IUnitOfWork
{
    public IUserRepository UserRepository { get; }
}