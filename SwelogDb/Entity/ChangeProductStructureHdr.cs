using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeProductStructureHdr
{
    public string ParentPart { get; set; } = null!;

    public decimal? QuantityOfParent { get; set; }

    public string? ParentUnitMeasure { get; set; }

    public string? ConfigurationCode { get; set; }

    public DateTime? StructureValidFrom { get; set; }

    public DateTime? StructureValidUntil { get; set; }

    public string? AuditStamp { get; set; }

    public string? OperationList { get; set; }

    public virtual ICollection<ChangeProductStructureDtl> ChangeProductStructureDtls { get; } = new List<ChangeProductStructureDtl>();

    public virtual ChangeItem ParentPartNavigation { get; set; } = null!;

    public virtual UnitOfMeasure? ParentUnitMeasureNavigation { get; set; }
}
