using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceCost
{
    public int ActivityNo { get; set; }

    public DateTime FinishDateTime { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public decimal? ResourceTime { get; set; }

    public decimal? SetupTime { get; set; }

    public int? NoOfSetup { get; set; }

    public decimal? ProduceQty { get; set; }

    public decimal? ResourceCost1 { get; set; }

    public string? AuditStamp { get; set; }
}
