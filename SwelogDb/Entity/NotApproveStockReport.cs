using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveStockReport
{
    public int IdNotApproveStockReport { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public string? ItemNumber { get; set; }

    public string? PalletNo { get; set; }

    public string? Comments { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public decimal? QtyReviewed { get; set; }

    public string? ErrorReportId { get; set; }

    public string? OriginalPalletNo { get; set; }

    public string? NotApproveCode { get; set; }

    public int? ReportedBy { get; set; }
}
