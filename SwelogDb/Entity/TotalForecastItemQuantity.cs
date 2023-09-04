using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TotalForecastItemQuantity
{
    public string ForecastId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public decimal? Month01Quantity { get; set; }

    public decimal? Month02Quantity { get; set; }

    public decimal? Month03Quantity { get; set; }

    public decimal? Month04Quantity { get; set; }

    public decimal? Month05Quantity { get; set; }

    public decimal? Month06Quantity { get; set; }

    public decimal? Month07Quantity { get; set; }

    public decimal? Month08Quantity { get; set; }

    public decimal? Month09Quantity { get; set; }

    public decimal? Month10Quantity { get; set; }

    public decimal? Month11Quantity { get; set; }

    public decimal? Month12Quantity { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? TotalItemValue { get; set; }
}
