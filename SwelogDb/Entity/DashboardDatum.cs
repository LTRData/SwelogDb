using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DashboardDatum
{
    public int IdDashboardData { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CalculationDate { get; set; }

    public string? ModuleId { get; set; }

    public string? ChartType { get; set; }

    public string? KeyType { get; set; }

    public string? SeriesId { get; set; }

    public string? SeriesColumn { get; set; }

    public string? KpiKeyId { get; set; }

    public string? LabelColumn { get; set; }

    public decimal? ValueColumn { get; set; }

    public string? ReportTitle { get; set; }

    public string? ValueAxisLabel { get; set; }

    public string? CategoryAxisLabel { get; set; }
}
