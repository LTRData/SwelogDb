using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeePersCatg
{
    public int EmploymentNumber { get; set; }

    public string PersonCatg { get; set; } = null!;

    public DateTime PersCatgValidFrom { get; set; }

    public string? AuditStamp { get; set; }
}
