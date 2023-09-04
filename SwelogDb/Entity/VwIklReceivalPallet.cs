using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwIklReceivalPallet
{
    public DateTime ProcessDatetime { get; set; }

    public string PalletStatus { get; set; } = null!;

    public string? PalletNo { get; set; }

    public string GoodsentryNo { get; set; } = null!;

    public decimal? QtyInPallets { get; set; }

    public string? PalletLabelYn { get; set; }

    public string? OrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? SupplierId { get; set; }

    public string? Location { get; set; }

    public string? Position { get; set; }

    public string? OurRef { get; set; }

    public string? ItemDescription { get; set; }

    public int? LabelsPerPallet { get; set; }
}
