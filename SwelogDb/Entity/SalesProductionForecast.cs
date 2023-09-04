using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesProductionForecast
{
    public int SerialNumber { get; set; }

    public string ForecastId { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public DateTime? DemandDate { get; set; }

    public decimal? DemandQuantity { get; set; }
}
