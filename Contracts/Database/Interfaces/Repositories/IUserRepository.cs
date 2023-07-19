using System.Linq.Expressions;
using Contracts.Models;

namespace Contracts.Interfaces.Repositories;

public interface IUserRepository
{
    public Task<User> GetByAsync(Expression<Func<User, bool>> predicate);
}