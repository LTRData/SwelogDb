using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReworkReport
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime DateTime { get; set; }

    public int ActivityNo { get; set; }

    public decimal? QtyToRework { get; set; }

    public int? ApprovedBy { get; set; }

    public string? AuditStamp { get; set; }
}
