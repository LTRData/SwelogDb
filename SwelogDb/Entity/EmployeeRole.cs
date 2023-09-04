using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeRole
{
    public int EmploymentNumber { get; set; }

    public string RoleId { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
