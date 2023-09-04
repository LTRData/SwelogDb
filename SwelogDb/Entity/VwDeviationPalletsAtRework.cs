using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwDeviationPalletsAtRework
{
    public string? PalletNo { get; set; }

    public string? ItemNumber { get; set; }

    public int? ReworkLotNumber { get; set; }

    public decimal? QtyToRework { get; set; }

    public decimal? QtyReworked { get; set; }

    public string ReviewAction { get; set; } = null!;

    public decimal? QtyAdjusted { get; set; }
}
