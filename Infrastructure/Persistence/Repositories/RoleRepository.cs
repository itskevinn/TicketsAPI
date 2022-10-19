using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Base;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories;

public class RoleRepository: GenericRepository<Role>, IRoleRepository
{
    public RoleRepository(TicketsContext context) : base(context)
    {
    }
}