using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MpcDivisionReport
{
    public int KeyNo { get; set; }

    public int ReportKeyNo { get; set; }

    public DateTime ReportDateTime { get; set; }

    public int ActivityNo { get; set; }

    public decimal QtyProduced { get; set; }

    public decimal OrderQty { get; set; }

    public decimal PlannedResourceTime { get; set; }

    public decimal PropResourceTime { get; set; }

    public decimal ActualResourceTime { get; set; }

    public string DivisionPwtCode { get; set; } = null!;

    public string DirectPwtCode { get; set; } = null!;

    public decimal? QtyNotApproved { get; set; }
}
