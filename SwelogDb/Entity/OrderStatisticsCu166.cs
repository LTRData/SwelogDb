using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderStatisticsCu166
{
    public int SerialNumber { get; set; }

    public int? ProcessId { get; set; }

    public string? OrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? ProductGroup { get; set; }

    public decimal? BalanceQuantity { get; set; }

    public decimal? BalanceAmount { get; set; }

    public decimal? RawMaterialCost { get; set; }

    public decimal? PurchaseCost { get; set; }

    public decimal? DirectWageCost { get; set; }

    public decimal? AverageHourlyEarning { get; set; }
}
