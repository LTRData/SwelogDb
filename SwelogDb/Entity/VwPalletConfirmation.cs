using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPalletConfirmation
{
    public string? PalletNo { get; set; }

    public int? OperationNo { get; set; }

    public string? ItemNo { get; set; }

    public int? LotNo { get; set; }

    public string? DeliverFullPallet { get; set; }

    public decimal? QtyConfirmed { get; set; }

    public string PalletType { get; set; } = null!;
}
