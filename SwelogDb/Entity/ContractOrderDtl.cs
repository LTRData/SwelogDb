using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ContractOrderDtl
{
    public string PurchaseOrderNumber { get; set; } = null!;

    public short SplitSequenceNo { get; set; }

    public string PurchaseLineType { get; set; } = null!;

    public int? PurchaseOrderTxtid { get; set; }

    public string? PurchaseOrderFlag { get; set; }

    public string? ItemNumber { get; set; }

    public string? SupplierItemNumber { get; set; }

    public string? GoodsMark { get; set; }

    public int? GoodsMarkTxtid { get; set; }

    public string? GoodsMarkFlag { get; set; }

    public decimal? PurchasePrice { get; set; }

    public string? PriceUnit { get; set; }

    public decimal? PurchaseOrderQuantity { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public decimal? ApprovedQuantity { get; set; }

    public decimal? SupplierDiscountPercentile { get; set; }

    public decimal? SupplierSetUpPrice { get; set; }

    public string? PurchasedItemDeliveryCode { get; set; }

    public string? DrawingNumber { get; set; }

    public string? RevisionNumber { get; set; }

    public DateTime? PurDeliveryPlanDate { get; set; }

    public DateTime? PurDeliveryFinalDate { get; set; }

    public short? OperationNumber { get; set; }

    public string? OperationDescription { get; set; }

    public decimal? OperationMarketPrice { get; set; }

    public string? AuditStamp { get; set; }
}
