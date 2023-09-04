using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductForecastTb2
{
    public string ForecastId { get; set; } = null!;

    public int SerialNumber { get; set; }

    public string? Product { get; set; }

    public short? YearNumber { get; set; }

    public decimal? TotalValue { get; set; }

    public decimal? ValueMonth1 { get; set; }

    public decimal? ValueMonth2 { get; set; }

    public decimal? ValueMonth3 { get; set; }

    public decimal? ValueMonth4 { get; set; }

    public decimal? ValueMonth5 { get; set; }

    public decimal? ValueMonth6 { get; set; }

    public decimal? ValueMonth7 { get; set; }

    public decimal? ValueMonth8 { get; set; }

    public decimal? ValueMonth9 { get; set; }

    public decimal? ValueMonth10 { get; set; }

    public decimal? ValueMonth11 { get; set; }

    public decimal? ValueMonth12 { get; set; }
}
