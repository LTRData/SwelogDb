using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActualItemCostSpecification
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string ComponentCode { get; set; } = null!;

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

    public string? AuditStamp { get; set; }

    public decimal? TransactionQty { get; set; }

    public decimal? DirectCost { get; set; }

    public string? DirectCostYn { get; set; }
}
