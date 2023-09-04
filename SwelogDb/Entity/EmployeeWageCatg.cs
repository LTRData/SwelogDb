using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeWageCatg
{
    public int EmploymentNumber { get; set; }

    public string WageCatg { get; set; } = null!;

    public DateTime WageCatgValidFrom { get; set; }

    public string? AuditStamp { get; set; }
}
