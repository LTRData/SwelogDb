using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GrossRequirement
{
    public string ItemNumber { get; set; } = null!;

    public short SequenceNumber { get; set; }

    public DateTime? ItemStartDate { get; set; }

    public DateTime? ItemReqdDate { get; set; }

    public decimal? ItemRequiredQuantity { get; set; }

    public string? AuditStamp { get; set; }
}
