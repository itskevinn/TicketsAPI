﻿using Application.Base;
using Application.Security.Http.Dto;
using Application.Security.Http.Request;
using Infrastructure.Core.Interface;

namespace Application.Security.Service;

public interface IAuthService : IScopedService
{
    Task<Response<AuthenticateDto>> Authenticate(AuthenticateRequest authenticateRequest);
    Task<UserDto> GetOnlyUserById(Guid id);
}