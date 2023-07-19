using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Contracts.Interfaces.Repositories;
using Contracts.Models;

namespace MSSQLProvider.Implementations.Repositories;

public class UserRepository : IUserRepository
{
    public UserRepository(Context context) =>
        this.context = context;
    private readonly Context context;
    
    public Task<User> GetByAsync(Expression<Func<User, bool>> predicate)
    {
        throw new NotImplementedException();
    }
}