using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesForecastItemOperation
{
    public string ForecastId { get; set; } = null!;

    public int SerialNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public string? CostCentre { get; set; }

    public string? ItemNumber { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? TotalLoad { get; set; }

    public decimal? LoadMonth1 { get; set; }

    public decimal? LoadMonth2 { get; set; }

    public decimal? LoadMonth3 { get; set; }

    public decimal? LoadMonth4 { get; set; }

    public decimal? LoadMonth5 { get; set; }

    public decimal? LoadMonth6 { get; set; }

    public decimal? LoadMonth7 { get; set; }

    public decimal? LoadMonth8 { get; set; }

    public decimal? LoadMonth9 { get; set; }

    public decimal? LoadMonth10 { get; set; }

    public decimal? LoadMonth11 { get; set; }

    public decimal? LoadMonth12 { get; set; }
}
