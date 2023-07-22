using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Interface;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;

namespace TicketsGateway.Application.Security.Services;

public interface IUserService : ITransientService
{
    /// <summary>
    /// Method that searches for a user by id
    /// </summary>
    /// <param name="id">Id of the user to search for</param>
    /// <param name="token">Auth token</param>
    /// <returns cref="UserDto">dto of the user found in database <see cref="Response{T}"/> <see cref="UserDto"/></returns>
    public Task<Response<UserDto>> GetById(Guid id, string token);

    /// <summary>
    /// Method that retrieves all users registered in the database
    /// </summary>
    /// <returns>An enumerable of the users found in database <see cref="Response{T}"/> <see cref="IEnumerable{T}"/> <see cref="UserDto"/></returns>
    public Task<Response<IEnumerable<UserDto>>> GetAll(string token);

    /// <summary>
    /// Method used to validate and call db to save the user
    /// </summary>
    /// <param cref="UserRequest" name="userRequest">User request sent from client</param>
    /// <param name="token">Auth token</param>
    /// <returns> Saved user <see cref="Response{T}"/> <see cref="UserDto"/></returns>
    public Task<Response<UserDto>> Save(UserRequest userRequest, string token);
}