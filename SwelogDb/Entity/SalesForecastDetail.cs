using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesForecastDetail
{
    public string ForecastId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public decimal? Quantity { get; set; }
}
