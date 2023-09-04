using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeValidity
{
    public int EmploymentNumber { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? AuditStamp { get; set; }
}
