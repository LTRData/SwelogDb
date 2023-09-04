using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProdpropSetItemMemb
{
    public string ProductPropertySet { get; set; } = null!;

    public string ItemNo { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
