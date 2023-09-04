using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActualItemCostCalcTemp
{
    public string ParentItem { get; set; } = null!;

    public int Lot { get; set; }

    public string ComponentItem { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string? ItemType1 { get; set; }

    public string? ItemType2 { get; set; }

    public string? ItemTypeCompcost { get; set; }

    public string? MfgItemEstimationCase { get; set; }

    public decimal? LotSize { get; set; }

    public decimal? Factor { get; set; }

    public decimal? PriceUnitNum { get; set; }

    public decimal? TransactionQuantity { get; set; }

    public string? TransactionCode { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SeparateOrderCost { get; set; }

    public string? UserCode { get; set; }

    public int? MaterialLotNumber { get; set; }
}
