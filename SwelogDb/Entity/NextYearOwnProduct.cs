using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NextYearOwnProduct
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? ItemSeperateOrderCost { get; set; }
}
