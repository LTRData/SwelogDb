using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FunctionGroup
{
    public string CompanyNo { get; set; } = null!;

    public string FunctionGroupNo { get; set; } = null!;

    public string FunctionNo { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual Function Function { get; set; } = null!;
}
