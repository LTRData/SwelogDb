using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class QuantityRatingDtl
{
    public string QuantityRatingId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public short PointScoreSerial { get; set; }

    public short? PointScore { get; set; }

    public short? QtyDeviation { get; set; }

    public string? AuditStamp { get; set; }
}
