using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeAttestArea
{
    public int EmploymentNumber { get; set; }

    public string AttestArea { get; set; } = null!;

    public DateTime AttestAreaValidFrom { get; set; }

    public string? AuditStamp { get; set; }
}
