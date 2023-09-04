using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CodeTable
{
    public int CodeNumber { get; set; }

    public string? CodeDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ItemAdditionalDatum> ItemAdditionalData { get; } = new List<ItemAdditionalDatum>();
}
