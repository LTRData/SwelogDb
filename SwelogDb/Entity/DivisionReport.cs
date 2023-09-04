using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DivisionReport
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public string ReportActivityNo { get; set; } = null!;

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public int? ReportedBy { get; set; }

    public string? UpdateFlag { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? Finished { get; set; }

    public string ActivityType { get; set; } = null!;

    public int SequenceNo { get; set; }

    public DateTime? MpcUpdateDate { get; set; }

    public string? FinalDelivery { get; set; }

    public string? ActivityNo { get; set; }

    public string? PlannedResource { get; set; }

    public decimal? ResourceTime { get; set; }

    public int? TextId { get; set; }

    public decimal? QtyForDivision { get; set; }

    public string? StockPosition { get; set; }
}
