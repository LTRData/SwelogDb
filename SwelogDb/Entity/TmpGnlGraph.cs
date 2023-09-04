using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpGnlGraph
{
    public int RecId { get; set; }

    public string? ReportId { get; set; }

    public short? PeriodNo { get; set; }

    public string? YearNo { get; set; }

    public decimal? Amount { get; set; }

    public int? Colour { get; set; }

    public string? Col1 { get; set; }

    public string? AuditStamp { get; set; }
}
