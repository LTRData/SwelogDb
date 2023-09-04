using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesForecastCustomer
{
    public string ForecastId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public int? TotalValue { get; set; }
}
