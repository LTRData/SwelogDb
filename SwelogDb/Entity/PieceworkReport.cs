using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PieceworkReport
{
    public int ReportId { get; set; }

    public string YearWeek { get; set; } = null!;

    public int PieceworkNumber { get; set; }

    public int QtyProduced { get; set; }

    public int Percentage { get; set; }

    public string Attested { get; set; } = null!;

    public decimal? Rate { get; set; }

    public string? AuditStamp { get; set; }
}
