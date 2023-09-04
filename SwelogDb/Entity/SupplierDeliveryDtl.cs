using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierDeliveryDtl
{
    public string DeliveryNoteNumber { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OperationNumber { get; set; }

    public int LotNumber { get; set; }

    public string ItemNumber { get; set; } = null!;

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public decimal? DesiredQuantity { get; set; }

    public double? DeliveryQuantity { get; set; }

    public string ParentItem { get; set; } = null!;

    public string? WarehouseId { get; set; }

    public string? StockLocation { get; set; }

    public decimal? SellingPriceDelivery { get; set; }

    public decimal? DiscountPercentageDelivery { get; set; }

    public decimal? DeliveredAmount { get; set; }

    public decimal? ReceivedQuantity { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? SupplierDeliveryAddress { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public virtual SupplierDeliveryHdr DeliveryNoteNumberNavigation { get; set; } = null!;
}
