using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgProductStructureHdr
{
    public string ParentPart { get; set; } = null!;

    public decimal? QuantityOfParent { get; set; }

    public string? ParentUnitMeasure { get; set; }

    public string? ConfigurationCode { get; set; }

    public DateTime? StructureValidFrom { get; set; }

    public DateTime? StructureValidUntil { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<MfgProductStructureDtl> MfgProductStructureDtls { get; } = new List<MfgProductStructureDtl>();
}
