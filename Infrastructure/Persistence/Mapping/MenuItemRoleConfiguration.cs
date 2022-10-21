using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mapping;

public class MenuItemRoleConfiguration : IEntityTypeConfiguration<MenuItemRole>
{
    public Guid MenuItemId { get; set; }
    public MenuItem MenuItem { get; set; } = default!;
    public Guid RoleId { get; set; }
    public Role Role { get; set; } = default!;

    public void Configure(EntityTypeBuilder<MenuItemRole> builder)
    {
        builder.HasKey(mr => new { mr.RoleId, mr.MenuItemId });
        builder.HasOne(mr => mr.Role)
            .WithMany(r => r.RoleMenuItems)
            .HasForeignKey(mr => mr.RoleId);
        builder.HasOne(mr => mr.MenuItem)
            .WithMany(r => r.MenuItemRoles)
            .HasForeignKey(mr => mr.MenuItemId);
        builder.Property("CreatedBy").IsRequired(false);
    }
}