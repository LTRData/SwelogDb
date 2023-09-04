using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbItemPegging
{
    public string OrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public decimal? QuantityPegged { get; set; }

    public decimal? QuantityIssued { get; set; }

    public string? AuditStamp { get; set; }
}
