using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductStructureHdr
{
    public string ParentPart { get; set; } = null!;

    public decimal? QuantityOfParent { get; set; }

    public string? ParentUnitMeasure { get; set; }

    public string? ConfigurationCode { get; set; }

    public DateTime? StructureValidFrom { get; set; }

    public DateTime? StructureValidUntil { get; set; }

    public string? AuditStamp { get; set; }

    public string? OperationList { get; set; }

    public string? ParentPartDescription { get; set; }

    public string? RefType { get; set; }

    public string? Reference { get; set; }

    public string? ReferenceSub { get; set; }

    public bool? ApprovedWithoutComponent { get; set; }

    public virtual UnitOfMeasure? ParentUnitMeasureNavigation { get; set; }

    public virtual ICollection<ProductStructureDtl> ProductStructureDtls { get; } = new List<ProductStructureDtl>();
}
