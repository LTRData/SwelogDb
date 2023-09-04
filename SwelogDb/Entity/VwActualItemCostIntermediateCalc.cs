using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwActualItemCostIntermediateCalc
{
    public string ParentItem { get; set; } = null!;

    public int Lot { get; set; }

    public string ComponentItem { get; set; } = null!;

    public string? ComponentType { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public string? UnitOfComponent { get; set; }

    public decimal? RawMaterialCost { get; set; }

    public decimal? RawMaterialOverhead { get; set; }

    public decimal? PurchaseItemCost { get; set; }

    public decimal? PurchaseFixedOrderCost { get; set; }

    public decimal? PurchaseOverheadCost { get; set; }

    public decimal? OperatorCost { get; set; }

    public decimal? OperatorSetupCost { get; set; }

    public decimal? MfgOverheadCost { get; set; }

    public decimal? CurrentTotalCost { get; set; }

    public decimal? TransactionQuantity { get; set; }

    public decimal? DirectCost { get; set; }

    public string? DirectCostYn { get; set; }

    public DateTime TransactionDate { get; set; }

    public string? NotSpecified { get; set; }

    public string? ItemType1 { get; set; }

    public string? ItemType2 { get; set; }

    public string? ItemTypeCompcost { get; set; }

    public string? MfgItemEstimationCase { get; set; }

    public decimal? LotSize { get; set; }

    public decimal? Factor { get; set; }

    public decimal? PriceUnitNum { get; set; }

    public string? TransactionCode { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SeparateOrderCost { get; set; }

    public string? UserCode { get; set; }

    public int? MaterialLotNumber { get; set; }
}
