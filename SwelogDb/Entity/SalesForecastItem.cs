using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesForecastItem
{
    public string ForecastId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;
}
