using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeTimeCatg
{
    public int EmploymentNumber { get; set; }

    public string TimeCatg { get; set; } = null!;

    public DateTime TimeCatgValidFrom { get; set; }

    public string? AuditStamp { get; set; }
}
