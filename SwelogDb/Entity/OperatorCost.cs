using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorCost
{
    public int ActivityNo { get; set; }

    public DateTime FinishDateTime { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public decimal? OperatorTime { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public decimal? OperatorCost1 { get; set; }

    public decimal? OverheadCost { get; set; }

    public int? ActivityReportedBy { get; set; }

    public string? AuditStamp { get; set; }
}
