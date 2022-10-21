using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Domain.Entity.Base;

namespace Domain.Entity;

public class User : AuditableEntity<Guid>
{
    public string Name { get; set; } = default!;
    public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
    public IEnumerable<UserRole> UserRoles { get; set; } = default!;
    [NotMapped] [JsonIgnore] public IEnumerable<Role> Roles { get; set; } = default!;
}