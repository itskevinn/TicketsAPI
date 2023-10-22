namespace Infrastructure.Security.Models;

public class UserDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Username { get; set; } = default!;
    public IEnumerable<RoleDto> Roles { get; set; } = default!;

    public UserDto(Guid id, IEnumerable<RoleDto> roles)
    {
        Id = id;
        Roles = roles;
    }
}