using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmType
{
    public string TypeCode { get; set; } = null!;

    public string TypeDescription { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
