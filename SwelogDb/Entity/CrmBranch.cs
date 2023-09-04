using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmBranch
{
    public string BranchCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
