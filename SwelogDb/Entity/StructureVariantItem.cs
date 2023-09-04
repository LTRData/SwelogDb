using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StructureVariantItem
{
    public string GroupCode { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }

    public int? OwnStructureProp { get; set; }

    public decimal? Number { get; set; }

    public decimal? OpTime { get; set; }

    public decimal? SetupTime { get; set; }

    public int? Operation { get; set; }

    public virtual StructureVariantGroup GroupCodeNavigation { get; set; } = null!;

    public virtual Item ItemNavigation { get; set; } = null!;
}
