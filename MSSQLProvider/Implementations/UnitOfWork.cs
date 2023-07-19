using Contracts.Database.Interfaces;
using Contracts.Interfaces.Repositories;
using MSSQLProvider.Implementations.Repositories;

namespace MSSQLProvider.Implementations;

public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(Context context) =>
        this.context = context;
        
    private readonly Context context;
    private IUserRepository userRepository;

    public IUserRepository UserRepository =>
        userRepository ??= new UserRepository(context);
}