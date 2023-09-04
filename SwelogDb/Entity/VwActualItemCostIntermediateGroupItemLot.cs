using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwActualItemCostIntermediateGroupItemLot
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? RawMaterialCost { get; set; }

    public decimal? RawMaterialOverhead { get; set; }

    public decimal? PurchaseItemCost { get; set; }

    public decimal? PurchaseFixedOrderCost { get; set; }

    public decimal? PurchaseOverheadCost { get; set; }

    public decimal? OperatorCost { get; set; }

    public decimal? OperatorSetupCost { get; set; }

    public decimal? MfgOverheadCost { get; set; }

    public decimal? CurrentTotalCost { get; set; }
}
