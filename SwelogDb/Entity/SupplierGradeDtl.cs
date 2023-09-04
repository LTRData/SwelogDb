using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierGradeDtl
{
    public string GradeId { get; set; } = null!;

    public string ClassCode { get; set; } = null!;

    public string? ClassDesc { get; set; }

    public decimal? ClassPercent { get; set; }

    public string? AuditStamp { get; set; }

    public virtual SupplierGradeHdr Grade { get; set; } = null!;
}
