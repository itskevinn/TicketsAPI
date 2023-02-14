using Application.Security.Http.Dto;
using AutoMapper;
using Domain.Entity;
using Domain.Entity.Base;
using Microsoft.AspNetCore.Http;

namespace Application.Base;

public class BaseService<TEntity> where TEntity : IAuditableEntity
{
    protected const string AnErrorHappenedMessage = "Ocurrió un error";
    private readonly IHttpContextAccessor? _contextAccessor;
    private readonly IMapper _mapper;

    protected BaseService(IHttpContextAccessor context, IMapper mapper)
    {
        _contextAccessor = context;
        _mapper = mapper;
    }

    protected BaseService(IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <summary>
    /// Use this method to set the user that is authenticated to the audit attributes of the specified entity
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="updating">Determines if the entity is being updated in order to set the LastModifiedBy attribute as well <seealso cref="AuditableEntity{TKey}"/>></param>
    protected void SetCurrentUserToEntity(TEntity entity, bool updating = false)
    {
        var value = (UserDto)_contextAccessor?.HttpContext?.Items["User"]!;
        entity.GetType().GetProperty("GeneratedBy")?.SetValue(entity, value.Username, null);
        switch (updating)
        {
            case false:
                entity.GetType().GetProperty("CreatedOn")?.SetValue(entity, DateTime.Now, null);
                entity.GetType().GetProperty("CreatedBy")?.SetValue(entity, value.Username, null);
                break;
            case true:
                entity.GetType().GetProperty("LastModifiedBy")?.SetValue(entity, value.Username, null);
                break;
        }
    }

    protected User GetCurrentUser()
    {
        var currentUserDto = (UserDto)_contextAccessor?.HttpContext?.Items["User"]!;
        var currentUser = _mapper.Map<User>(currentUserDto);
        return currentUser;
    }
}