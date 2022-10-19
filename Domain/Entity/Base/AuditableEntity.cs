﻿namespace Domain.Entity.Base;

public class AuditableEntity<TKey> : BaseEntity<TKey>, IAuditableEntity
{
    public string CreatedBy { get; set; } = default!;
    public DateTime CreatedOn { get; set; } = default!;
    public string LastModifiedBy { get; set; } = default!;
    public DateTime LastModifiedOn { get; set; } = default!;
}