using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpOldestPalletsForItemAndQty
{
    public string? PalletNo { get; set; }

    public decimal? PalletQty { get; set; }

    public decimal? AccumQty { get; set; }

    public string? Location { get; set; }

    public string? Position { get; set; }

    public DateTime? RegDate { get; set; }

    public string? Item { get; set; }

    public decimal? DemandQty { get; set; }

    public string? HasPalletHandling { get; set; }

    public string? Status { get; set; }

    public int? Spid { get; set; }

    public string? ControlId { get; set; }
}
