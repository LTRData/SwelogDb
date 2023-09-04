using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class QualityScheme
{
    public string QualityId { get; set; } = null!;

    public short? SupplyTimely { get; set; }

    public short? SupplyQty { get; set; }

    public short? SupplyQuality { get; set; }

    public short? OwnGrade { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? ValidFrom { get; set; }
}
