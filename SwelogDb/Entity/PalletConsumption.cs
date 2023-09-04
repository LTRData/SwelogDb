using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletConsumption
{
    public int IdPalletConsumption { get; set; }

    public string PalletNo { get; set; } = null!;

    public string ConsumedPalletNo { get; set; } = null!;

    public int? QtyConsumed { get; set; }

    public int? QtyAdjusted { get; set; }

    public DateTime? ReportDate { get; set; }

    public bool? UpdateReworkAction { get; set; }
}
