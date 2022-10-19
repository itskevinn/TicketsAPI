using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Base;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories;

public class UserRoleRepository: GenericRepository<UserRole>, IUserRoleRepository
{
    public UserRoleRepository(TicketsContext context) : base(context)
    {
    }
}