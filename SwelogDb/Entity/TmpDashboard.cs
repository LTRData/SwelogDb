using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpDashboard
{
    public int? ProcessId { get; set; }

    public string? SeriesId { get; set; }

    public string? SeriesColumn { get; set; }

    public string? KpiKeyId { get; set; }

    public string? LabelColumn { get; set; }

    public decimal? ValueColumn { get; set; }

    public string? ReportTitle { get; set; }

    public string? ValueAxisLabel { get; set; }

    public string? CategoryAxisLabel { get; set; }
}
