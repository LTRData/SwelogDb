using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Fix021231Costprice
{
    public string ItemNumber { get; set; } = null!;

    public string? CalcWay { get; set; }

    public DateTime? LastCostpriceUpdate2002 { get; set; }

    public DateTime? FirstCostpriceUpdate2003 { get; set; }

    public DateTime? UsedTransaction { get; set; }

    public decimal? CostPrice { get; set; }
}
