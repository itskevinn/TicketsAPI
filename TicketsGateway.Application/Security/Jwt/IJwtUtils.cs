namespace TicketsGateway.Application.Security.Jwt;

public interface IJwtUtils<in T>
{
	string GenerateJwtToken(T userDto);
	Guid ValidateJwtToken(string token);
}