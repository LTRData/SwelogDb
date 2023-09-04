using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemType3
{
    public string ItemType31 { get; set; } = null!;

    public string? ItemType3Desc { get; set; }

    public int? ItemType3DescTxtid { get; set; }

    public string? ItemType3DescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
