using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierGradeHdr
{
    public string GradeId { get; set; } = null!;

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<SupplierGradeDtl> SupplierGradeDtls { get; } = new List<SupplierGradeDtl>();
}
