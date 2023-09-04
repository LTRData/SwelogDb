using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SalesForecastCustomerItemValue
{
    public string ForecastId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public int? SellingPrice { get; set; }
}
