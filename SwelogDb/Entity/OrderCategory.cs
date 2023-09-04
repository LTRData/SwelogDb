using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderCategory
{
    public string OrderCategory1 { get; set; } = null!;

    public string? OrderCategoryDescription { get; set; }

    public string? AuditStamp { get; set; }
}
