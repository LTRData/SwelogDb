using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderLineType
{
    public string OrderLineType1 { get; set; } = null!;

    public string? OrderLineTypeDesc { get; set; }

    public string? AuditStamp { get; set; }
}
