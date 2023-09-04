using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesForecastDiscount
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? DiscountPercentage { get; set; }
}
