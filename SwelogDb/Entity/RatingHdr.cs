using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class RatingHdr
{
    public string RatingId { get; set; } = null!;

    public string? DefaultIndicator { get; set; }

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }
}
