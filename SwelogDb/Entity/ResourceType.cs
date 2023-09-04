using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceType
{
    public string ResourceType1 { get; set; } = null!;

    public string? ResourceTypeDesc { get; set; }

    public int? ResourceTypeTxtid { get; set; }

    public string? ResourceTypeFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ResourceTbl> ResourceTbls { get; } = new List<ResourceTbl>();
}
