using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosPlannedOrder
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public decimal? OrderQuantity { get; set; }

    public DateTime? OrderStartDate { get; set; }

    public DateTime? OrderFinishDate { get; set; }

    public int? OldLotNumber { get; set; }

    public string? AuditStamp { get; set; }

    public string? OrderLine { get; set; }

    public string? OrderNumber { get; set; }

    public string? FirstDemandOnThatDay { get; set; }

    public decimal? ExpiringBalance { get; set; }

    public int? ExpiringDays { get; set; }
}
