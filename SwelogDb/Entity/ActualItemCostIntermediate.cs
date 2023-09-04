using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActualItemCostIntermediate
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string ComponentCode { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string? ComponentType { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public string? UnitOfComponent { get; set; }

    public string? TransactionCode { get; set; }

    public decimal? TransactionQuantity { get; set; }

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

    public decimal? ReceiveOrderQuantity { get; set; }

    public short? RefOprNo { get; set; }

    public decimal? DirectCost { get; set; }

    public string? DirectCostYn { get; set; }

    public string? FinalDeliveryFlag { get; set; }

    public DateTime? EventDate { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVoucherNo { get; set; }

    public string? NotSpecified { get; set; }

    public string? ErrorCostYn { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? GoodsentryNo { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public string? ComponentDescription { get; set; }
}
