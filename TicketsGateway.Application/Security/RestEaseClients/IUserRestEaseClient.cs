using RestEase;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;

namespace TicketsGateway.Application.RestEaseClients;

public interface IUserRestEaseClient
{
    [Get("api/v1/User/FindById/{id}")]
    public Task<Base.Response<UserDto>> GetById([Path] Guid id, [Header("Authorization")] string authorization);

    [Get("api/v1/User/FindAll")]
    public Task<Base.Response<IEnumerable<UserDto>>> GetAll([Header("Authorization")] string authorization);

    [Post("api/v1/User/Create")]
    public Task<Base.Response<UserDto>> Save(UserRequest userRequest, [Header("Authorization")] string authorization);
}