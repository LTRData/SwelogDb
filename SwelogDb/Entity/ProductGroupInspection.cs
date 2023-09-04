using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductGroupInspection
{
    public string ProductGroupCode { get; set; } = null!;

    public int InspectionHdrId { get; set; }

    public string? AuditStamp { get; set; }
}
