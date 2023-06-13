using TicketsGateway.Application.Base;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;
using TicketsGateway.Infrastructure.Core.Interface;

namespace TicketsGateway.Application.Security.Services;


public interface IUserService : ITransientService
{
    /// <summary>
    /// Method that searches for a user by id
    /// </summary>
    /// <param name="id">Id of the user to search for</param>
    /// <returns cref="UserDto">dto of the user found in database <see cref="Response{T}"/> <see cref="UserDto"/></returns>
    public Task<Response<UserDto>> GetById(Guid id);

    /// <summary>
    /// Method that retrieves all users registered in the database
    /// </summary>
    /// <returns>An enumerable of the users found in database <see cref="Response{T}"/> <see cref="IEnumerable{T}"/> <see cref="UserDto"/></returns>
    public Task<Response<IEnumerable<UserDto>>> GetAll();

    /// <summary>
    /// Method used to validate and call db to save the user
    /// </summary>
    /// <param cref="UserRequest" name="userRequest">User request sent from client</param>
    /// <returns> Saved user <see cref="Response{T}"/> <see cref="UserDto"/></returns>
    public Task<Response<UserDto>> Save(UserRequest userRequest);
}