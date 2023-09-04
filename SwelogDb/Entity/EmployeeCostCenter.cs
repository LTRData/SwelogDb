using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeCostCenter
{
    public int EmploymentNumber { get; set; }

    public string CostCenter { get; set; } = null!;

    public DateTime CostCenterValidFrom { get; set; }

    public string? AuditStamp { get; set; }
}
