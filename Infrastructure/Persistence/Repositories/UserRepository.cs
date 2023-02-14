using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(TicketsContext context) : base(context)
    {
    }

    public bool ExistsByUsername(string username)
    {
        return FindBy(u => u.Username == username) != null;
    }
}