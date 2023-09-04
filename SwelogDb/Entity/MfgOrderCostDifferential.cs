using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderCostDifferential
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public DateTime? FinalDeliveryDate { get; set; }

    public decimal? TotalDeliveredQuantity { get; set; }

    public decimal? UsedCost { get; set; }

    public decimal? CalculatedDifference { get; set; }

    public decimal? AdjustmentValue { get; set; }

    public string? AuditStamp { get; set; }
}
