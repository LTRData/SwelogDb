using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemType1
{
    public string ItemType11 { get; set; } = null!;

    public string? ItemType1Desc { get; set; }

    public int? ItemType1DescTxtid { get; set; }

    public string? ItemType1DescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
