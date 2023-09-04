using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeAuthority
{
    public int EmploymentNumber { get; set; }

    public string OperationId { get; set; } = null!;

    public int? AuthorityLevel { get; set; }

    public string? AuditStamp { get; set; }
}
