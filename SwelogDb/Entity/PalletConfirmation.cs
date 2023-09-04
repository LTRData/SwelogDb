using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletConfirmation
{
    public int IdPalletConfirmation { get; set; }

    public string PalletNo { get; set; } = null!;

    public int OperationNo { get; set; }

    public string? ItemNo { get; set; }

    public int? LotNo { get; set; }

    public decimal? QtyConfirmed { get; set; }

    public int? ConfirmedBy { get; set; }

    public DateTime? ConfirmationDate { get; set; }

    public int? ReportedBy { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? NotCompleted { get; set; }

    public string? GoodsentryNo { get; set; }

    public string? PoNumber { get; set; }

    public string? InternalPalletNo { get; set; }

    public string? DispatchedPalletNo { get; set; }
}
