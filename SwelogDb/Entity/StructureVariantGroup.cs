using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StructureVariantGroup
{
    public string GroupCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }

    public string? TopItem { get; set; }

    public string? ParentItem { get; set; }

    public int? Mandatory { get; set; }

    public string? ParentItemPosition { get; set; }

    public string? ProdpropGroup { get; set; }

    public virtual ICollection<StructureVariantItem> StructureVariantItems { get; } = new List<StructureVariantItem>();
}
