using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;

namespace Infrastructure.Persistence.Repositories;

public class UserRoleRepository: GenericRepository<UserRole>, IUserRoleRepository
{
    public UserRoleRepository(TicketsContext context) : base(context)
    {
    }
}