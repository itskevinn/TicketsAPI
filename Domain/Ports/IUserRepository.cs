using Domain.Entity;

namespace Domain.Ports;

public interface IUserRepository: IGenericRepository<User>
{
    bool ExistsByUsername(string username);
}