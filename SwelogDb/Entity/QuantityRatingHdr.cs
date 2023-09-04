﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class QuantityRatingHdr
{
    public string QuantityRatingId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public string? DefaultIndicator { get; set; }

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }
}
