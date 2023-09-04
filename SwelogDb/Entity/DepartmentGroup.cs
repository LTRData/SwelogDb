using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DepartmentGroup
{
    public string CompanyNo { get; set; } = null!;

    public string DepartmentGroupNo { get; set; } = null!;

    public string DepartmentNo { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual Department Department { get; set; } = null!;
}
