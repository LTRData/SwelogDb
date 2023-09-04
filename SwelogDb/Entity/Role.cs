using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Role
{
    public string RoleId { get; set; } = null!;

    public string? RoleDescription { get; set; }

    public string? AuditStamp { get; set; }
}
