using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolReactivationType
{
    public string ToolReactivateType { get; set; } = null!;

    public string? ReactivationDesc { get; set; }

    public int? ReactivationDescTxtid { get; set; }

    public string? ReactivationDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? SparePartList { get; set; }
}
