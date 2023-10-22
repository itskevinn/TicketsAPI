using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Domain.Exceptions;
using Infrastructure.Core.Helpers;
using Infrastructure.Security.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Infrastructure.Security.Jwt;

/// <summary>
/// Middleware for handling request for controllers with Authorize notation
/// </summary>
public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly AppSettings _appSettings;

    public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
    {
        _next = next;
        _appSettings = appSettings.Value;
    }

    public async Task Invoke(HttpContext context)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        if (token != null)
            AttachUserToContext(context, token);

        await _next(context);
    }

    private void AttachUserToContext(HttpContext context, string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            }, out var validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            Guid.TryParse(jwtToken.Claims.First(x => x.Type.ToLower() == "id").Value, out var userId);
            var userRolesJson = jwtToken.Claims.First(x => x.Type.ToLower() == "roles").Value;
            if (userId == Guid.Empty) throw new InvalidOperationException("id must be in the claims");
            if (userRolesJson == null) throw new InvalidOperationException("roles must be in the claims");
            var userRoles = JsonConvert.DeserializeObject<IEnumerable<RoleDto>>(userRolesJson);
            var userDto = new UserDto(userId, userRoles);
            context.Items["User"] = userDto;
        }
        catch (Exception e)
        {
            throw new AppException(e.Message);
        }
    }
}