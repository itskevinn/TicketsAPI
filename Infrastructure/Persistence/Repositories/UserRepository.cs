using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Base;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(TicketsContext context) : base(context)
    {
    }
}