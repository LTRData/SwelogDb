using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class N8dRatingDtl
{
    public string N8dRatingId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public short PointScoreSerial { get; set; }

    public short? PointScore { get; set; }

    public short? Noof8d { get; set; }

    public string? AuditStamp { get; set; }
}
