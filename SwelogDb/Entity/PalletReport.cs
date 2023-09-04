using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletReport
{
    public int IdPalletReport { get; set; }

    public string? PalletNo { get; set; }

    public string? ItemNo { get; set; }

    public int? LotNo { get; set; }

    public int? OperationNo { get; set; }

    public DateTime? ReportDate { get; set; }

    public decimal? QtyReported { get; set; }

    public string? Finished { get; set; }

    public int? ReportedBy { get; set; }

    public DateTime? ConfirmationDate { get; set; }

    public int? DeviationTxtid { get; set; }
}
