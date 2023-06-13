using TicketsGateway.Application.Base;
using TicketsGateway.Application.RestEaseClients;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;

namespace TicketsGateway.Application.Security.Services.Implementation;

public class UserService : BaseService, IUserService
{
    private readonly IUserRestEaseClient _userRestEaseClient;

    public UserService()
    {
        _userRestEaseClient = RestEase.RestClient.For<IUserRestEaseClient>();
    }

    public async Task<Response<UserDto>> GetById(Guid id)
    {
        
        return await _userRestEaseClient.GetById(id);
    }

    public Task<Response<IEnumerable<UserDto>>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Response<UserDto>> Save(UserRequest userRequest)
    {
        throw new NotImplementedException();
    }
}