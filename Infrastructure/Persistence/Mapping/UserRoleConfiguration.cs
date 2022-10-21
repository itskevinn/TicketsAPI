﻿
using Domain.Entity.Base;

namespace Infrastructure.Persistence.Mapping;

public class UserRole : BaseEntity<Guid>
{
    public UserRole(Guid userId, Guid roleId)
    {
        UserId = userId;
        RoleId = roleId;
    }
    public Guid UserId { get; set; }
    public User User { get; set; } = default!;
    public Guid RoleId { get; set; }
    public Role Role { get; set; } = default!;
}