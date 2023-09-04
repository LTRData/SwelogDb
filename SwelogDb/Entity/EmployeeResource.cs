using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeResource
{
    public int EmploymentNumber { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
