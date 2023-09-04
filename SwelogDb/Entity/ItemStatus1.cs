using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemStatus1
{
    public string ItemStatus11 { get; set; } = null!;

    public string? ItemStatus1Desc { get; set; }

    public int? ItemStatus1DescTxtid { get; set; }

    public string? ItemStatus1DescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ChangeItem> ChangeItems { get; } = new List<ChangeItem>();

    public virtual ICollection<ChangeOrderHdr> ChangeOrderHdrs { get; } = new List<ChangeOrderHdr>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
