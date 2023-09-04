using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemType2
{
    public string ItemType21 { get; set; } = null!;

    public string? ItemType2Desc { get; set; }

    public int? ItemType2DescTxtid { get; set; }

    public string? ItemType2DescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
