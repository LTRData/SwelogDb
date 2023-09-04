using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemStatus2
{
    public string ItemStatus21 { get; set; } = null!;

    public string? ItemStatusDesc { get; set; }

    public int? ItemStatusDescTxtid { get; set; }

    public string? ItemStatusDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
