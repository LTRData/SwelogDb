using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class QualityRatingDtl
{
    public string QualityRatingId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public short? QualityOkPoint { get; set; }

    public short? QualityPointScore { get; set; }

    public string? AuditStamp { get; set; }
}
