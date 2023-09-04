using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TotalForecastDetail
{
    public string TotalForecastId { get; set; } = null!;

    public string SalesForecastId { get; set; } = null!;
}
