using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LotDetail
{
    public string LotCode { get; set; } = null!;

    public string? LotDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
