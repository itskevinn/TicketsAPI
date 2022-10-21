using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Domain.Entity;
using Domain.Entity.Base;

namespace Infrastructure.Persistence.Mapping;

public class RoleConfiguration : BaseEntity<Guid>
{
    public string RoleName { get; set; } = default!;
    [NotMapped] [JsonIgnore] public IEnumerable<MenuItem> Authorities { get; set; } = default!;
    public IEnumerable<UserRole> UserRoles { get; set; } = default!;
    public IEnumerable<MenuItemRole> RoleMenuItems { get; set; } = default!;
}