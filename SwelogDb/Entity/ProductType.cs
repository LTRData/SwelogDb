using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductType
{
    public string ProductType1 { get; set; } = null!;

    public string? ProductTypeDescription { get; set; }

    public string? AuditStamp { get; set; }
}
