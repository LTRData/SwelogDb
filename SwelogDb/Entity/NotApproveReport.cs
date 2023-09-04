using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveReport
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public string ActivityNo { get; set; } = null!;

    public string NotApproveCode { get; set; } = null!;

    public decimal? QtyNotApproved { get; set; }

    public string? AttestionStatus { get; set; }

    public string? AuditStamp { get; set; }

    public int SequenceNo { get; set; }

    public string ActivityType { get; set; } = null!;

    public string? ProductionGroupId { get; set; }

    public decimal? QtyReviewed { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public short? OperationNumber { get; set; }

    public string? ComponentPart { get; set; }

    public string? PalletNo { get; set; }

    public string? BlockedFlag { get; set; }

    public int? BlockedDescTxtid { get; set; }

    public string? StockPalletNo { get; set; }

    public string? ErrorReportId { get; set; }

    public string? AutoReworkFlag { get; set; }

    public string? GoodsentryNo { get; set; }
}
