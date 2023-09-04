using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemInspControlText
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? ControlTextCode { get; set; }

    public int? LotNumber { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<ItemInspControlTextDtl> ItemInspControlTextDtls { get; } = new List<ItemInspControlTextDtl>();
}
