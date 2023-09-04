using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesProductionForecastHdr
{
    public string ForecastId { get; set; } = null!;

    public string? ForecastDescription { get; set; }

    public int? StartYear { get; set; }

    public int? StartWeek { get; set; }
}
