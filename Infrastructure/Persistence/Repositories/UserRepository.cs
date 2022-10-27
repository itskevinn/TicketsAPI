using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;
using Infrastructure.Persistence.UnitOfWork;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(TicketsContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

    public bool ExistsByUsername(string username)
    {
        return FindBy(u => u.Username == username) != null;
    }
}