using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemAdditionalDatum
{
    public string ItemNumber { get; set; } = null!;

    public int CodeNumber { get; set; }

    public string? CodeValue { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CodeTable CodeNumberNavigation { get; set; } = null!;
}
