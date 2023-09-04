using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StoreCategory
{
    public string StoreCategory1 { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }
}
