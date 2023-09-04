using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierGradeScheme
{
    public string ClassId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public string ClassCode { get; set; } = null!;

    public string? ClassCodeDescripion { get; set; }

    public decimal? GradeUpperLimit { get; set; }

    public string? AuditStamp { get; set; }
}
