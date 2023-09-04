using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwNonUpdatedProductionReport
{
    public string? ActivityNo { get; set; }

    public string ActivityType { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public int SequenceNo { get; set; }

    public string ReportType { get; set; } = null!;

    public int? ReportedBy { get; set; }

    public string? FinalDelivery { get; set; }
}
