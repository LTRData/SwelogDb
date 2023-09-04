using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemInspInspectionText
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? InspectionText { get; set; }

    public int? LotNumber { get; set; }

    public int? TextIndex { get; set; }

    public int? Active { get; set; }

    public virtual ICollection<ItemInspInspectionTextDtl> ItemInspInspectionTextDtls { get; } = new List<ItemInspInspectionTextDtl>();
}
